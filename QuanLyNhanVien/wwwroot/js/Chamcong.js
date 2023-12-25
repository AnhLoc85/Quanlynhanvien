document.addEventListener("DOMContentLoaded", function () {
    $('#TimKiem').on('click', function() {
        TimKiem();
    })
    configDateDefault();
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
       if(response != ''){
        showToast(response.message, response.statusCode);
       }
       if(response.statusCode == 200){
          var modelId = response.model1.id;
          if(response.model1.gioVaoSang != null){
              if($("tr[data-id=" + modelId + "]").length){
                  $("tr[data-id=" + modelId + "]").replaceWith(addRowTalbeSang(response.model1));
              }else{
                  $("#DDSang").append(addRowTalbeSang(response.model1));
              }
          }
          if(response.model1.gioVaoChieu != null){
              if($("tr[data-id=" + modelId + "]").length){
                  $("tr[data-id=" + modelId + "]").replaceWith(addRowTalbeChieu(response.model1));
              }else{
                  $("#DDChieu").append(addRowTalbeChieu(response.model1));
              }
          }
          if(response.model1.gioVaoToi != null){
              if($("tr[data-id=" + modelId + "]").length){
                $("tr[data-id=" + modelId + "]").replaceWith(addRowTalbeToi(response.model1));
              }else{
                  $("#DDToi").append(addRowTalbeToi(response.model1));
              }
          }
       }
      }
    });
  })

function TimKiem() {
    var ngay = $('#Ngay').val();
    var maNS = $('#MaNS').val();
    $.ajax({
        type: "post",
        url: "/ChamCong/TimKiemChamCong",
        data: {
            Ngay: ngay,
            MaNS: maNS,
        },
        success: function (response) {
          console.log(response.length, response)
        if(response.length == 1){
          if(response[0]?.gioVaoSang != null){
            $("#DDSang").empty();
            $("#DDSang").append(addRowTalbeSang(response[0]));
          }
          if(response[0]?.gioVaoChieu != null){
            $("#DDChieu").empty();
            $("#DDChieu").append(addRowTalbeChieu(response[0]));
          }
          if(response[0]?.gioVaoToi != null){
            $("#DDToi").empty();
            $("#DDToi").append(addRowTalbeToi(response[0]));
          }
        }else{
          updateDataOfTableChieu(response);
          updateDataOfTableSang(response);
          updateDataOfTableToi(response);
        }
        },
        error: function (error) {
          console.log(error);
      }
    });
}
function addRowTalbeSang(data) {
   return`<tr data-id="${data.id}"> <td class="text-center">${data.maNsNavigation.maNs}</td>
   <td class="text-start">${data.maNsNavigation.tenNs}</td>
   <td class="text-center">${data.gioVaoSang == null ? "" : formatTimeSpan(data.gioVaoSang)}</td>
   <td class="text-center">${data.gioRaSang == null ? "" : formatTimeSpan(data.gioRaSang)}</td></tr>`
}
function addRowTalbeChieu(data) {
  return`<tr data-id="${data.id}"> <td class="text-center">${data.maNsNavigation.maNs}</td>
  <td class="text-start">${data.maNsNavigation.tenNs}</td>
  <td class="text-center">${data.gioVaoChieu == null ? "" : formatTimeSpan(data.gioVaoChieu)}</td>
  <td class="text-center">${data.gioRaChieu == null ? "" : formatTimeSpan(data.gioRaChieu)}</td></tr>`
}
function addRowTalbeToi(data) {
  return`<tr data-id="${data.id}"> <td class="text-center">${data.maNsNavigation.maNs}</td>
  <td class="text-start">${data.maNsNavigation.tenNs}</td>
  <td class="text-center">${data.gioVaoToi == null ? "" : formatTimeSpan(data.gioVaoToi)}</td>
  <td class="text-center">${data.gioRaToi == null ? "" : formatTimeSpan(data.gioRaToi)}</td></tr>`
}

function updateDataOfTableSang(datas) {
  $("#DDSang").empty();
  datas.forEach(data => {
      if (data.gioVaoSang !== null) {
          $("#DDSang").append(addRowTalbeSang(data));
      }
  });
}
function updateDataOfTableChieu(datas) {
  $("#DDChieu").empty();
  datas.forEach(data => {
      if (data.gioVaoChieu !== null) {
          $("#DDChieu").append(addRowTalbeChieu(data));
      }
  });
}
function updateDataOfTableToi(datas) {
  $("#DDToi").empty();
  datas.forEach(data => {
      if (data.gioVaoToi !== null) {
          $("#DDToi").append(addRowTalbeToi(data));
      }
  });
}