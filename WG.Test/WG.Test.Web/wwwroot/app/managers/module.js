"use strict";

angular.module('managers', ['ui.router'])
    .config(function ($stateProvider) {
        $stateProvider
            .state('managers',
            {
                url: '/managers',
                templateUrl: 'app/managers/views/managers.html',
                controller: 'managersController',
                controllerAs: 'managersCtrl'
            });
    });
