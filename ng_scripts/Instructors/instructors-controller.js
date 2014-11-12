registrationModule.controller("InstructorsController", ['$scope', 'bootstrappedInstructors', function ($scope, bootstrappedInstructors) {
    $scope.instructors = bootstrappedInstructors.instructors;
}]);