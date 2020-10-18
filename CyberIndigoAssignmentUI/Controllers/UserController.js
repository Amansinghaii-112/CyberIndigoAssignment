routerApp.controller("UserController", function ($http, $scope, $resource, $location, $timeout) {

    alert("User controller called successfully");

    $scope.userPageStatus = 'login';
    $scope.PasswordStatus = '';

    // response message.
    $scope.successMsg = "";
    $scope.ErrorMsg = "";

    $scope.check = function () {

        console.log("---------check User Check--------->");

        var UserDtoList = [];
        UserDtoList.push($scope.UserDTO);

        $http.post('http://localhost:59765/User/Check', UserDtoList)
            .then(function (data) {

                if (data.data == true) {
                    $scope.successMsg = " || Welcome || Successfully login...";
                    $scope.ErrorMsg = "";

                } else {
                    $scope.ErrorMsg = "Login failed";
                    $scope.successMsg = "";
                }

            });

    };

    $scope.userPageDrive = function (operation) {
        if (operation == 'SignUp') {
            $scope.userPageStatus = 'SignUp';
        } else {
            $scope.userPageStatus = 'login';
        }
    }

    $scope.add = function () {

        var UserDtoList = [];

        if ($scope.UserDTO.UserPassword != $scope.UserDTO.ConfirmUserPassword) {

            $scope.PasswordStatus = 'NotSame';

        } else {

            UserDtoList.push($scope.UserDTO);

            var request = $resource("http://localhost:59765/User/Add");
            request.save(UserDtoList,
                function (data) {        // success function

                    $scope.successMsg = " || Welcome ||Sign Up Successfully...";
                    $scope.PasswordStatus = '';
                    $scope.userPageStatus = 'login';
                }
                ,
                function (data) {

                    // error function
                    $scope.duplicateError = data.data.Error.Message;
                }
            );
        }
    };

});