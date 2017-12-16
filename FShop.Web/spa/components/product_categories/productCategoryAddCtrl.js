﻿(function (app) {
    app.controller('productCategoryAddCtrl', productCategoryAddCtrl);

    productCategoryAddCtrl.$inject = ['$scope', 'apiService','notificationService','$state'];
    function productCategoryAddCtrl($scope, apiService, notificationService, $state) {
        $scope.productCate = {
            CreateDate: new Date(),
            Status: true
        }
        $scope.AddProductCategory = AddProductCategory;
        angular.element(function () {
            loadParentCategory();
        });
        function AddProductCategory() {
            apiService.post('/api/ProductCategory/Add', $scope.productCate, function () {
                notificationService.displaySuccess('Thêm mới thành công');
                $state.go('productCategory');
            }, function (error) {
                notificationService.displayError('Thêm mới thất bại');
            });
        }
        function loadParentCategory() {
            apiService.get('/api/ProductCategory/GetAllParents', null, function (result) {
                $scope.productCategory = result.data.Data;
            }, function () {
                console.log('Không tìm thấy dữ liệu !!!');
            });
        }

    }
})(angular.module('fshop.productCategory'));