angular.module('app.services').service('ApiService', function($http) {
    this.getPizzaTypes = function() {
        return $http.get('api/pizza-types');
    }

    this.getOrders = function() {
        return $http.get('api/orders');
    }

    this.postOrders = function(order) {
        return $http.post('api/orders', order);
    }
});