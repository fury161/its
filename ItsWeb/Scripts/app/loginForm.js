var loginController = function ($scope, $location) {
    $scope.loginNameHasError = 0;
    $scope.loginPasswordHasError = 0;

    $scope.author = "nga";
    $scope.localDate = new Date();

    $scope.loginPassword = "";
    $scope.loginName = "";

    $scope.doLogin = function () {

        $scope.loginNameChange();
        $scope.loginPasswordChange();

        if ($scope.loginNameHasError > 0) return;

        /*alert('Logging in ' + $scope.loginName)*/
        $location.path("/newIncident")
    }

    $scope.loginNameChange = function () {
        $scope.loginNameHasError = 0;
        if ($scope.loginName === null) {
            $scope.loginNameHasError = 1;
        }
        if ($scope.loginName.length == 0) {
            $scope.loginNameHasError = 2;
        }
    }

    $scope.loginPasswordChange = function () {
        $scope.loginPasswordHasError = 0;
        if ($scope.loginPassword === null) {
            $scope.loginPasswordHasError = 1;
        }
        if ($scope.loginPassword.length == 0) {
            $scope.loginPasswordHasError = 2;
        }
    }

    $scope.loginNameHasErrors = function (i) {
        if ($scope.loginNameHasError == i) return true;
        else return false;
    }

    $scope.loginPasswordHasErrors = function (i) {
        if ($scope.loginPasswordHasError == i) return true;
        else return false;
    }
}