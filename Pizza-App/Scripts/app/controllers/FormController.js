angular.module('app.controllers').controller('FormController', ['$scope', '$log', 'ApiService', function ($scope, $log, ApiService) {
    getPizzas();

    $scope.pizza = '';
    $scope.date = '';
    $scope.time = '';
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

    $scope.submitOrder = function (form) {
        var valid = checkDeliveryDateTime();

        if (valid) {
            form.time.$error.mintime = false;
            form.time.$invalid = false;
            form.time.$valid = true;
        } else {
            form.time.$error.mintime = true;
            form.time.$invalid = true;
            form.time.$valid = false;
            return;
        }

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

    function checkDeliveryDateTime() {
        $scope.order.DeliveryDate = new Date($scope.date.getFullYear(), $scope.date.getMonth(), $scope.date.getDate(),
                                             $scope.time.getHours(), $scope.time.getMinutes(), $scope.time.getSeconds());

        return $scope.order.DeliveryDate > new Date();
    }

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