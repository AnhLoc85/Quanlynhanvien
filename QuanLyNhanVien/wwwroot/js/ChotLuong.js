
document.addEventListener("DOMContentLoaded", function () {
    $('#TimKiem').on('click', function() {
        loadQTLuong();
    })
    configMonth();
});

function loadQTLuong() {
    var Ngay = $('#LoadLuong').val();
    $.ajax({
        type: "post",
        url: "/loadQTLuong",
        data: "Ngay=" + Ngay,
        success: function (result) {
            console.log(result)
           
        },
        error: function () {
            console.log(lỗi)
        }
    });
}
function addQTLuong() {
    var Ngay = $('#NgayChotLuong').val();
    $.ajax({
        type: "post",
        url: "/addQTLuong",
        data: "Ngay=" + Ngay,
        success: function (result) {
               alert("Chốt lương thành công ");
        },
        error: function () {
            alert("Fail");
        }
    });
}
