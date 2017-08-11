angular.module('app.controllers').controller('FormController', ['$scope', 'ApiService', function($scope, ApiService) {
    $scope.date = '';
    $scope.time = '';
    $scope.order = {
        firstName: '',
        lastName: '',
        phoneNumber: '',
        pizzaType: '',
        quantity: '',
        deliveryDate: this.date + this.time,
        totalCost: ''
    };

    function getPizzaTypes() {
        var serviceCall = ApiService.getPizzaTypes();
        serviceCall
            .then(function (result) {
                $scope.pizzaTypes = result.data;
            })
            .catch(function (error) {
                $log.error('There was an error retrieving the pizza type data. ', error);
            });
    }

    function submitOrder() {
        var serviceCall = ApiService.postOrders(this.order);
        serviceCall
            .then(function (result) {
                $scope.success = result.data;
            })
            .catch(function (error) {
                $log.error('There was an error submitting the order. ', error);
            });
    }

    getPizzaTypes();
}]);