'use strict';

angular.module('employees').controller('employeesController',
    ["$state", "employeesService", "managersService",
        function($state, employeesService, managersService) {
            var ctrl = this;

            employeesService.getAll().then(function(employees) {
                ctrl.employees = employees;
            });

            managersService.getAll().then(function(managers) {
                ctrl.managers = managers;
            });

            ctrl.create = function() {
                $state.go('employees.create');
            }

            ctrl.update = function (index) {
                employeesService.update(ctrl.employees[index]).then(function () {});
            }

            ctrl.delete = function(id, index) {
                employeesService.delete(id).then(function() {
                    ctrl.employees.splice(index, 1);
                });
            }
        }
    ]);
