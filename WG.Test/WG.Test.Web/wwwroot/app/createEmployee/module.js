"use strict";

angular.module('createEmployee', ['ui.router'])
    .config(function ($stateProvider) {
        $stateProvider
            .state('createEmployee',
            {
                url: '/createEmployee',
                templateUrl: 'app/createEmployee/views/createEmployee.html',
                controller: 'createEmployeeController',
                controllerAs: 'createEmployeeCtrl'
            });
    });
