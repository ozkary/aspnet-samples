(function (angular) {
    'use strict';
    var app = angular.module('appContact');
    app.factory('app.svc.contact', ['$http', svcContact]);
    
    function svcContact($http) {
        var baseRoute = '/api/contact/';
        return {
            add: add
        }

        function add(contact) {
            var token = contact.token;
            if (token && contact.sendToken) {
                $http.defaults.headers.post['X-XSRF-Token'] = contact.token;
            } else {
                delete $http.defaults.headers.post['X-XSRF-Token'];
            }

            return $http.post(baseRoute+"send", contact);
        }
    }


})(angular);