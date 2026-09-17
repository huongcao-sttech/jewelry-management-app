(function ($) {
    var _productService = abp.services.app.product,
        _$modal = $('#ProductEditModal');

    // 1. Mở Modal Edit khi bấm nút Edit Product
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

    // 2. Hàm xử lý lưu thông tin Product
    function saveProduct() {
        var _$form = $('#ProductEditForm');

        if ($.isFunction(_$form.valid) && !_$form.valid()) {
            return;
        }

        var product = _$form.serializeFormToObject();

        abp.ui.setBusy(_$modal);

        _productService.updateProduct(product)
            .done(function () {
                _$modal.modal('hide');
                abp.notify.info('Cập nhật sản phẩm thành công!');
                location.reload();
            })
            .always(function () {
                abp.ui.clearBusy(_$modal);
            });
    }

    // Lắng nghe sự kiện click nút Save
    $(document).on('click', '#ProductEditModal .save-button', function (e) {
        e.preventDefault();
        saveProduct();
    });

    // Lắng nghe sự kiện submit của Form Edit
    $(document).on('submit', '#ProductEditForm', function (e) {
        e.preventDefault();
        saveProduct();
    });

})(jQuery);
