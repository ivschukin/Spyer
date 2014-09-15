angular.module('spApp', ['ngRoute']);

angular.module('spApp').config([
  '$routeProvider',
  '$locationProvider',
  function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode(true);

    $routeProvider.when('/:controller?/:action?/:identity?', {
      templateUrl: function (params) {
        if (params.controller === null || params.controller === undefined) {
          params.controller = 'home';
        }

        if (params.action === null || params.action === undefined) {
          params.action = 'index';
        }

        return '/partials/' + params.controller + '/' + params.action;
      },
      caseInsensitiveMatch: true
    });
  }]);