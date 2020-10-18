
var routerApp = angular.module('routerApp', ['ui.router', 'ngResource', 'checklist-model']);

routerApp.config(function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.otherwise('/login');

    $stateProvider

        .state('login', {
            url: '/login',
            templateUrl: '../../Pages/User.html',
            controller: 'UserController'
        })

        .state('MyProfile', {
            url: '/MyProfile',
            templateUrl: '../../Pages/MyProfile.html',
            controller: 'MyProfileController'
        })

        .state('Blog', {
            url: '/ClientCreation',
            templateUrl: '../../Pages/Blog.html',
            controller: 'BlogController'
        });


});
