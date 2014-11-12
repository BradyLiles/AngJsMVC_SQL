registrationModule.controller("CoursesController", ['$scope', 'bootstrappedCourses', function($scope, bootstrappedCourses) {
    $scope.courses = bootstrappedCourses.courses;
}]);