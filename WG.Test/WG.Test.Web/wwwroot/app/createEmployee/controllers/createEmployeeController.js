'use strict';

angular.module('createEmployee').controller('createEmployeeController', ["$state", "employeesService",
    function ($state, employeesService) {
        var ctrl = this;

        ctrl.create = function () {
            employeesService.create(ctrl.employee).then(function () {
                $state.go("employees");
            }, function () {

            });
        }
    }]);
