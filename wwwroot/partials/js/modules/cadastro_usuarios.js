const app = angular.module('main',['ngRoute', 'ngAnimate']);
app.config(['$routeProvider',function($routeProvider){
	$routeProvider
    .when('/', {
        templateUrl: 'principal.html'
    })
    .when('/cadastroUsuarios', {
        templateUrl: 'cadastro_usuarios.html',
        controller: 'cadastroUsuariosCtrl'
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

app.controller('cadastroUsuariosCtrl', function($scope,$http, $location){

    $scope.values = [];

    $http.get('/api/values').then(function(data){
        $scope.values = data.data; 
    })
    
    $scope.enviarDados = function(){    
        var res = $http.post('/api/values', $scope.form, { header: { 'Content-Type': 'application/json' } });
        res.then(function (data, status, headers, config) {
            console.log(data);

            $scope.form = {};

            $http.get('/api/values').then(function(data){
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