angular.module('app.controllers').controller('FormController', ['$scope', '$log', 'ApiService', function ($scope, $log, ApiService) {
    getPizzas();

    $scope.pizza = '';
    $scope.order = {
        FirstName: '',
        LastName: '',
        PhoneNumber: '',
        PizzaId: '',
        Quantity: '',
        DeliveryDate: '',
        TotalCost: ''
    };

    $scope.$watchGroup(['pizza', 'order.Quantity'], function () {
        $scope.order.PizzaId = $scope.pizza.PizzaId;
        $scope.order.TotalCost = $scope.order.Quantity * $scope.pizza.Price || 0;
    });

    $scope.onlyTodayForward = function (date) {
        var yesterday = Date.now() - 86400000;

        return date > yesterday;
    }

    $scope.submitOrder = function () {
        var serviceCall = ApiService.postOrders($scope.order);
        serviceCall
            .then(function (result) {
                $scope.success = result.data;
                alert('submitted successfully', result);
            })
            .catch(function (error) {
                alert(error.data);
            });
    };

    function getPizzas() {
        var serviceCall = ApiService.getPizzas();
        serviceCall
            .then(function(result) {
                $scope.pizzas = result.data;
            })
            .catch(function(error) {
                $log.error('There was an error retrieving the pizza type data. ', error);
            });
    }
}]);