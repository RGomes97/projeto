app.controller('cadastroProdutosCtrl', function($scope, $http, $location){
    $scope.produto = {};

    $scope.enviarDados = function(){
        var res = $http.post('/api/produtos', $scope.produto, { header: { 'Content-Type': 'application/json' } });
        res.then(function (data, status, headers, config) {
            console.log(data);

            $scope.produto = {};

            $http.get('/api/produtos').then(function(data){
                console.log(data.data); 
            })

        });
        res.catch(function (data, status, headers, config) {
            alert("failure message: " + JSON.stringify({ data: data }));
        });  
    }

    $scope.buscarProduto = function(){
        $http.get('/api/produtos/' + $scope.produto.codigo).then(function(data){
            $scope.produto = data.data;
        })
    }

    $scope.goTo = function(where){
        $location.path(where);
    }

})