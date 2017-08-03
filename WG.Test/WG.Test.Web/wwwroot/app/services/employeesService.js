'use strict';

angular.module('app').service('employeesService', ['http', function (http) {
    var self = this;

    self.getAll = function () {
        var url = 'employees';
        return http.get(url);
    };
}]);