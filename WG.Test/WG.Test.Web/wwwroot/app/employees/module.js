"use strict";

angular.module('employees', ['ui.router'])
    .config(function ($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('employees', {
                url: '/',
                templateUrl: 'app/employees/views/employees.html',
                controller: 'employeesController',
                controllerAs: 'employeesCtrl'
            });

        $urlRouterProvider.otherwise('/');
    });
