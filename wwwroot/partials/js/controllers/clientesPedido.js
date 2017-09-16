app.controller('clientesPedidoCtrl', function($scope, $http){

    $scope.clientes = [];

    $scope.filtro = '';

    $http.get('/api/cliente').then(function(data){
        $scope.clientes = data.data; 
    });

})