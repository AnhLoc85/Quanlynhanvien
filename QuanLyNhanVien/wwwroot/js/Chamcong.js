document.addEventListener("DOMContentLoaded", function () {
    $('#TimKiem').on('click', function() {
        TimKiem();
    })
    $('#Ngay').on('dp.change', function() {
        TimKiem();
    })
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
        console.log(response);
       // $('#DDSang').append

      }
    });
  })

function TimKiem() {
    var ngay = $('#Ngay').val();
    var maNS = $('#MaNS').val();
    $.ajax({
        type: "post",
        url: "ChamCong/TimKiem",
        data: {
            Ngay: ngay,
            MaNS: maNS,
        },
        success: function (response) {
            
        }
    });
}
function addRowTalbe(data) {
   return`<tr data-id="${data.id}"> <td class="text-center">${data.maNsNavigation.maNs}</td>
   <td class="text-start">${data.maNsNavigation.tenNs}</td>
   <td class="text-center">${data.gioVaoSang}</td>
   <td class="text-center">${data.gioRaSang}</td></tr>`
}