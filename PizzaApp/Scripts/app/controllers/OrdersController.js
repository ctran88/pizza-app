angular.module('app.controllers').controller('OrdersController', ['$scope', '$log', 'ApiService', function($scope, $log, ApiService) {
    getAllOrders();

    function getAllOrders() {
        var serviceCall = ApiService.getOrders();
        serviceCall
            .then(function (result) {
                $scope.orders = result.data;
            })
            .catch(function (error) {
                $log.error('There was an error retrieving the order data. ', error);
            });
    }
}]);