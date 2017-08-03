'use strict';

angular.module('app').service('managersService', ['http', function (http) {
    var self = this;

    self.getAll = function () {
        var url = 'managers';
        return http.get(url);
    };

    self.create = function(model) {
        var url = 'managers/create';
        return http.post(url, model);
    }

    self.delete = function(id) {
        var url = 'managers/delete/' + id;
        return http.delete(url);
    }
}]);