'use strict';

angular.module('employees').controller('employeesController', ["$state", "employeesService",
    function ($state, employeesService) {
        var ctrl = this;

        employeesService.getAll().then(function (employees) {
            ctrl.employees = employees;
        });

        ctrl.create = function() {
            $state.go('employees.create');
        }
    }]);
