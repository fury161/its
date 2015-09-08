angular.module('its', ['ngRoute', 'kendo.directives'])
    .controller('index', function ($scope, $location) {
        IndexController($scope, $location)
    })
    .controller('loginController', function ($scope, $location) {

        loginController($scope, $location);

    })
    .controller('newIncidentController', function ($scope) {

        newIncidentController($scope);

    })
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider
            .when('/login', {
                templateUrl: "/Home/Login",
                controller: 'loginController',
            })
            .when('/newIncident', {
                templateUrl: '/Home/RegisterIncident',
                controller: 'newIncidentController',
            });

        /*$locationProvider.html5Mode(true)*/
    });
