document.addEventListener("DOMContentLoaded", function () {
    quaTrinhLamViec()
 });
 function quaTrinhLamViec() {
   $.ajax({
     type: "post",
     url: "/TrangChu/ThongTinNhanVien",
     success: function (response) {
          console.log(response)
          $('.ngaycong').text(response.ngayCong);
          $('.ngaytangca').text(response.tangCa);
          $('.giotangca').text(response.gioTangCa);
          $('.ditre').text(response.soNgayDiTre);
          $('.thangluong').text('Lương ước tính tháng ' + response.thoiGian.thang);
          $('.luonguoctinh').text(roundToInteger(response.luongUocTinh)+ ' đồng');
          $('.namluong').text('Năm ' +response.thoiGian.nam);
          $('.tenns').text(response.nhanSu.tenNs);
          updateDataphat(response.phat);
          updateDatathuong(response.thuong);
          updateDataphucap(response.phuCap);

     },
     error: function () {
         alert("Fail");
     }
 });
 }
 function getthuong(data)
 {
    return `<tr>
       <td>
         <i class="fab fa-bootstrap fa-lg text-primary me-3"></i> <strong>Thưởng</strong>
       </td>
       <td>${formatDay(data.tgthuong)}</td>
       <td>${data.maThuongNavigation.noiDung}</td>
       <td>
       </td>
       <td class="text-end"><span class="badge bg-label-success me-1">${formatEvenNumber(data.tienThuong)}</span></td>
     </tr>`;
 }
 function getphat(data)
 {
    return `<tr>
    <td>
      <i class="fab fa-bootstrap fa-lg text-primary me-3"></i> <strong>Phạt</strong>
    </td>
    <td>${formatDay(data.tgphat)}</td>
    <td>${data.maPhatNavigation.noiDung}</td>
    <td>
    </td>
    <td class="text-end"><span class="badge bg-label-danger me-1">${formatEvenNumber(data.tienPhat)}</span></td>
  </tr>`;
 }
 function getphucap(data)
 {
   return  `<tr>
       <td>
         <i class="fab fa-bootstrap fa-lg text-primary me-3"></i> <strong>Phụ cấp</strong>
       </td>
       <td></td>
       <td>${data.maPcNavigation.khoanPhuCap}</td>
       <td>${data.maHspcNavigation.heSoPhuCap}
       </td>
       <td class="text-end"></td>
     </tr>`;
 }
 function updateDatathuong(datas) {
    datas.map((data) =>
        $("#tbody-qtthuongphat").append(getthuong(data))
    );
}
function updateDataphat(datas) {
    datas.map((data) =>
        $("#tbody-qtthuongphat").append(getphat(data))
    );
}
function updateDataphucap(datas) {
    datas.map((data) =>
        $("#tbody-qtthuongphat").append(getphucap(data))
    );
}