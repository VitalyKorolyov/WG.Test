'use strict';

angular.module('app').service('managersService', ['http', function (http) {
    var self = this;

    self.getAll = function () {
        var url = 'managers';
        return http.get(url);
    };
}]);