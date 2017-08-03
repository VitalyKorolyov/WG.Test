'use strict';

angular.module('managers').controller('managersController', ["$state", "managersService",
    function ($state, managersService) {
        var ctrl = this;

        managersService.getAll().then(function (managers) {
            ctrl.managers = managers;
        });
    }]);
