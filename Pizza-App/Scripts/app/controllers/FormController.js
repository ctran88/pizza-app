angular.module('app.controllers').controller('FormController', ['$scope', '$log', 'ApiService', function($scope, $log, ApiService) {
    $scope.today = new Date;
    $scope.minDate = new Date($scope.today.getTime() - ($scope.today.getTimezoneOffset() * 60000)).toISOString().slice(0, -8);
    
    $scope.order = {
        firstName: '',
        lastName: '',
        phoneNumber: '',
        pizzaType: '',
        quantity: 1,
        deliveryDate: '',
        totalCost: ''
    };

    $scope.$watchGroup(['order.pizzaType', 'order.quantity'], function() {
        $scope.order.totalCost = $scope.order.quantity * $scope.order.pizzaType.Price || 0;
    });

    $scope.submitOrder = function() {
        var serviceCall = ApiService.postOrders($scope.order);
        serviceCall
            .then(function(result) {
                $scope.success = result.data;
                alert('submitted successfully', $scope.success);
                location.reload();
            })
            .catch(function(error) {
                $log.error('There was an error submitting the order. ', error);
            });
    }

    function getPizzaTypes() {
        var serviceCall = ApiService.getPizzaTypes();
        serviceCall
            .then(function(result) {
                $scope.pizzaTypes = result.data;
            })
            .catch(function(error) {
                $log.error('There was an error retrieving the pizza type data. ', error);
            });
    }

    getPizzaTypes();
}]);