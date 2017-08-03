"use strict";

angular.module('employees', ['ui.router'])
    .config(function ($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('employees', {
                url: '/',
                templateUrl: 'app/employees/views/employees.html',
                controller: 'employeesController',
                controllerAs: 'employeesCtrl'
            })
            .state('employees.create', {
                url: 'create',
                templateUrl: 'app/employees/views/addEmployee.html',
                controller: 'addEmployeeController',
                controllerAs: 'addEmployeeCtrl'
            });

        $urlRouterProvider.otherwise('/');
    });
