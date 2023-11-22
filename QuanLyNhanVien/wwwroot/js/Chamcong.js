document.addEventListener("DOMContentLoaded", function () {
});

$('#MaDinhDanh').on('focus', function (event) {
    this.select();
  })
  $('#MaDinhDanh').on('keypress', function (event) {
    if (event.keyCode === 13) {
      var maDinhDanh = $(this).val();
    }
    $.ajax({
      type: "post",
      url: "/ChamCong/QuetQRChamCong",
      data: "maDD=" + maDinhDanh,
      success: function (response) {
        $('#DDSang').append

        $('#MaDinhDanh').val('');
      }
    });
  })