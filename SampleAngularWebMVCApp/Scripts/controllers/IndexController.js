angular.module('mainModule', ['ngRoute'])
    .config(function ($routeProvider, $httpProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/Scripts/templates/Home.html'
            })
            .when('/AboutMe', {
                templateUrl: '/Scripts/templates/AboutMe.html'
            })
            .when('/Services', {
                templateUrl: '/Scripts/templates/Services.html'
            }).
        otherwise({ redirectTo: '/Scripts/templates/Home.html' });
    })
.controller('setActiveCtrl', ['$scope', '$window', function ($scope, $window) {
    var win = $window.location.hash;
    jQuery.each(jQuery('.nav li a'), function (i, element) {
        jQuery(element).parent().removeClass('active');
        if (win == jQuery(element).attr('ng-href'))
            jQuery(element).parent().addClass('active');
    });

    $scope.setActive = function ($event) {
        jQuery($event.target).parent().siblings().removeClass('active');
        jQuery($event.target).parent().addClass('active');
    }

}]).controller('simpleGetCtrl', ['$scope', '$http', function ($scope, $http) {
    $scope.getFoo = function () {
        $http({
            method: 'GET',
            url: '/Foo/Index',
            //params: { 'foobar': new Date().getTime() }
        }).then(function successCallback(response) {
            console.log(response.data);
            $scope.foo = response.data;
        }, function errorCallback(response) {
        });
    };
    }]);
;
