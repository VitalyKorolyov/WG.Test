'use strict';

angular.module('createEmployee').controller('createEmployeeController',
    ["$state", "employeesService", "managersService",
        function($state, employeesService, managersService) {
            var ctrl = this;

            managersService.getAll().then(function(managers) {
                ctrl.managers = managers;
            });

            ctrl.create = function() {
                employeesService.create(ctrl.employee).then(function() {
                        $state.go("employees");
                    },
                    function() {

                    });
            }
        }
    ]);
