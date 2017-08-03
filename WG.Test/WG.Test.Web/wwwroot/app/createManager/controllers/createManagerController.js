'use strict';

angular.module('createManager').controller('createManagerController', ["$state", "managersService",
    function ($state, managersService) {
        var ctrl = this;

        ctrl.create = function () {
            managersService.create(ctrl.manager).then(function () {
                $state.go("managers");
            }, function () {

            });
        }
    }]);
