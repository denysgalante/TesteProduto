/// <reference path="../angular.intellisense.js" />

//Declarando o modulo
var app = angular.module('ngmodule', ["ngResource"]);

//Declarando o servico
app.service('ngservice', function ($http) {
    //Funcao para ler o token gerado
    this.getToken = function () {
        var res = $http.get("/GetToken");
        return res;
    };

    //Funcao para ler os produtos (MVC)
    this.getProductsMVC = function (token) {
        var res = $resource('/GetProducts/:token', {
            token: '@token'
        });

        res.get({ token: token }).$promise.then(function (resp) {
            $scope.products = resp;
        });

        return res;
    };

    //Funcao para ler os produtos (Ajax)
    this.getProductsAjax = function (token) {
        var res = $http.get("/GetProducts/" + token);
        return res;
    };
});

//Declarando o controller
app.controller('ngcontroller', function ($scope, $resource, ngservice, $timeout) {
    if(angular.isUndefined($scope.token))
        $scope.token = 'undefined';

    //Funcao para carregar o token gerado
    $scope.getToken = function () {
        var promise = ngservice.getToken();
        promise.then(function (resp) {
            $scope.token = resp.data;

            //prepara e inicia o contador
            $scope.counter = 60; //1 minuto
            $scope.stop();
            $scope.countdown();
        }, function (err) {
            $scope.message = "Falha ao obter o token. StatusCode: " + err.status + " StatusMessage: " + err.message;
        });
    };

    //Funcao para carregar os produtos (MVC)
    $scope.getProductsMVC = function () {

        var res = $resource('/GetProducts/:token', {
            token: '@token'
        });

        res.get({ token: $scope.token }).$promise.then(function (resp) {
            $scope.products = resp;
            $scope.message = "A busca pelos produtos foi realizada com sucesso.";
        }, function (err) {
            $scope.message = "Falha ao obter os produtos. StatusCode: " + err.status + " StatusMessage: " + err.statusText;
        });
    };

    //Funcao para carregar os produtos (Ajax)
    $scope.getProductsAjax = function () {
        var promise = ngservice.getProductsAjax($scope.token);
        promise.then(function (resp) {
            $scope.products = resp.data;
            $scope.message = "A busca pelos produtos foi realizada com sucesso.";
        }, function (err) {
            $scope.message = "Falha ao obter os produtos. StatusCode: " + err.status + " StatusMessage: " + err.statusText;
        });
    };

    var stopped;
    //Funcao para o contador
    $scope.countdown = function () {
        stopped = $timeout(function () {
            if ($scope.counter == "0") { $scope.stop(); }
            else { $scope.counter--; $scope.countdown(); }
        }, 1000);
    };

    $scope.stop = function () {
        $timeout.cancel(stopped);

    }
});