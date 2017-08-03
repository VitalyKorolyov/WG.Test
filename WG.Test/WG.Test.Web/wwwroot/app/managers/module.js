"use strict";

angular.module('managers', ['ui.router'])
    .config(function ($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('managers',
            {
                url: '/',
                templateUrl: 'app/managers/views/managers.html',
                controller: 'managersController',
                controllerAs: 'managersCtrl'
            });

        $urlRouterProvider.otherwise('/');
    });
