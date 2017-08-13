angular.module('app.services').service('ApiService', function($http) {
    this.getPizzas = function() {
        return $http.get('api/pizzas');
    }

    this.getOrders = function() {
        return $http.get('api/orders');
    }

    this.postOrders = function(order) {
        return $http.post('api/orders', order);
    }
});