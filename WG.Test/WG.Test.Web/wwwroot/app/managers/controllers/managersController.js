'use strict';

angular.module('managers').controller('managersController', ["$state", "managersService",
    function ($state, managersService) {
        var ctrl = this;

        managersService.getAll().then(function (managers) {
            ctrl.managers = managers;
        });

        ctrl.delete = function (id, index) {
            managersService.delete(id).then(function() {
                ctrl.managers.splice(index, 1);
            });
        }
    }]);
