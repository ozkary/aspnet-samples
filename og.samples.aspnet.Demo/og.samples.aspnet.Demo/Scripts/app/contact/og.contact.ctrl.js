(function (angular) {
    'use strict';
    var app = angular.module('appContact');   
    app.controller('app.ctrl.contact', ['$scope', '$uibModal', 'app.svc.contact', 'app.const.contact','$log', ctrlContact]);

    function ctrlContact($scope, $modal, contactService, appConstants, $log) {
        var ctrl = this;
        $log.log('app.ctrl.contact');

        $scope.loading = false;
        $scope.app = appConstants;

        ctrl.initContact = function () {
            var contact = { name: '', email: '', message: '' };
            contact.token = $("input[name='__RequestVerificationToken']").val();
            contact.sendToken = true;
            return contact;
        }
        $scope.contact = ctrl.initContact();       

        ctrl.send = function () {
            var contact = $scope.contact;         
           
            var service = contactService.add(contact);
            var dialog = ctrl.showMessage('loader-template', '');

            service.success(function (data) {
                dialog.close();
                $scope.contact = ctrl.initContact();
                $scope.loading = false;
                ctrl.showMessage("contact-ok", appConstants.contactMsg);
            });

            service.error(function (err, status, headers, config, statusText) {
                dialog.close();
                var msg = statusText || appConstants.contactBadMsg;
                ctrl.showMessage('contact-err', msg);
                $scope.loading = false;
            });
        }

        ctrl.showMessage = function (template, msg) {           
            $scope.message = msg;
            var modalInstance = $modal.open({
                templateUrl: template,
                scope: $scope
            });

            ctrl.loading = false;

            return modalInstance;
        }
    }

})(angular);