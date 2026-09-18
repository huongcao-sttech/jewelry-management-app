(function ($) {
    var _productService = abp.services.app.product,
        _$modal = $('#ProductEditModal');

    // 1. function handle edit product
    $(document).on('click', '.btn-edit-product', function (e) {
        e.preventDefault();
        var productId = $(this).attr('data-id');

        abp.ajax({
            url: abp.appPath + 'Products/EditProductModal?id=' + productId,
            type: 'GET',
            dataType: 'html',
            success: function (content) {
                $('#ProductEditModal div.modal-content').html(content);
                $('#ProductEditModal').modal('show');
            },
            error: function (err) {
                abp.notify.error('Không thể nạp form chỉnh sửa!');
            }
        });
    });

    // 2. function handle save product
    function saveProduct() {
        var _$form = $('#ProductEditForm');

        if ($.isFunction(_$form.valid) && !_$form.valid()) {
            return;
        }

        var product = _$form.serializeFormToObject();

        abp.ui.setBusy(_$modal);

        _productService.update(product)
            .done(function () {
                _$modal.modal('hide');
                abp.notify.info('Cập nhật sản phẩm thành công!');
                location.reload();
            })
            .always(function () {
                abp.ui.clearBusy(_$modal);
            });
    }

    // 3. function deleteProduct
    function deleteProduct(productId) {
        if (!productId) {
            return;
        }

        abp.message.confirm(
            'Bạn có chắc muốn xóa sản phẩm này không?',
            'Xác nhận xóa',
            function (isConfirmed) {
                if (!isConfirmed) {
                    return;
                }

                _productService.delete({ id: productId })
                    .done(function () {
                        abp.notify.success('Xóa sản phẩm thành công!');
                        location.reload();
                    });
            }
        );
    }

    // listen click button save in modal ProductEditModal
    $(document).on('click', '#ProductEditModal .save-button', function (e) {
        e.preventDefault();
        saveProduct();
    });

    // listen submit form ProductEditForm
    $(document).on('submit', '#ProductEditForm', function (e) {
        e.preventDefault();
        saveProduct();
    });

    // listen click button delete product
    $(document).on('click', '.btn-delete-product', function (e) {
        e.preventDefault();
        var productId = $(this).attr('data-id');
        deleteProduct(productId);
    });

})(jQuery);
