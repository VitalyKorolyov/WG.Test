"use strict";

angular.module('createManager', ['ui.router'])
    .config(function ($stateProvider) {
        $stateProvider
            .state('createManager',
            {
                url: '/createManager',
                templateUrl: 'app/createManager/views/createManager.html',
                controller: 'createManagerController',
                controllerAs: 'createManagerCtrl'
            });
    });
