const app = angular.module('main',['ui.bootstrap','ngRoute', 'ngAnimate']);
app.config(['$routeProvider',function($routeProvider){
	$routeProvider
    .when('/', {
        templateUrl: 'principal.html'
    })
    .when('/cadastroClientes', {
        templateUrl: 'cadastro_clientes.html',
        controller: 'cadastroClientesCtrl'
    })
    .when('/carrinho', {
        templateUrl: 'carrinho.html',
        controller: 'cadastroProdutosCtrl'
    })
    .when('/cadastroProdutos', {
        templateUrl: 'cadastro_produtos.html',
        controller: 'cadastroProdutosCtrl'
    })
    .otherwise({redirectTo:'/'});
}]);

app.controller('cadastroClientesCtrl', function($scope,$http, $location){
    $scope.values = [];

    $http.get('/api/cliente').then(function(data){
        $scope.values = data.data; 
    })
    
    $scope.enviarDados = function(){    
        var res = $http.post('/api/cliente', $scope.form, { header: { 'Content-Type': 'application/json' } });
        res.then(function (data, status, headers, config) {
            console.log(data);

            $scope.form = {};

            $http.get('/api/cliente').then(function(data){
                $scope.values = data.data; 
            })

        });
        res.catch(function (data, status, headers, config) {
            alert("failure message: " + JSON.stringify({ data: data }));
        });  
    }

    $scope.goTo = function(where){
		$location.path(where);
	}
})