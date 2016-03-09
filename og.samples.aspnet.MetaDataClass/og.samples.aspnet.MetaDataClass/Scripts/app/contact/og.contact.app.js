(function (angular) {
    'use strict';
    var app = angular.module('appContact', ['ngRoute', 'ui.bootstrap']);

    var constContact = {
        contactMsg: "Thanks. Your request was sent.",
        contactTitle: "Contact Us",
        contactBadMsg: "Sorry, we were not able to send your message. Please Try again.",
        contactEmail: "ozkary@ozkary.com",
        contactAddress: "ozkary.com",
        contactCityState: "Cyber Space",
        contactPhone: "",
        btnOk: 'OK'
    }

    app.constant('app.const.contact', constContact);
    
   
})(angular);                            