function hideToast() {
    $("#toast").toast('hide');
    $("#toast").removeClass("bg-success");
    $("#toast").removeClass("bg-danger");
  }
  function showToast(message, statusCode) {
    var backgrounColor;
    $("#toastContent").text(message);
    if (statusCode === 200) {
      $("#toast").removeClass('bg-danger');
      backgrounColor = "bg-success";
      $("#toast").addClass(backgrounColor);
    } else {
      backgrounColor = "bg-danger";
      $("#toast").addClass(backgrounColor);
      $("#toast").removeClass('bg-success');
    }
    $("#toast").toast('show');
    setTimeout(function () {
        $("#toast").toast('hide');
    }, 2000);
  }
  function formatTimeSpan(timeSpanValue) {
    var time = new Date("2000-01-01T" + timeSpanValue); // Đặt ngày mặc định (2000-01-01) cho phần ngày
    var hours = time.getHours().toString().padStart(2, '0'); // Lấy giờ và thêm số 0 nếu cần thiết
    var minutes = time.getMinutes().toString().padStart(2, '0'); // Lấy phút và thêm số 0 nếu cần thiết
    return hours + ":" + minutes;
}
function configDateDefault() {
    var today = new Date();
    $('.date-default').datetimepicker({
    locale: 'vi',
    useStrict: true,
    defaultDate: today,
    format: "DD-MM-yyyy",
    extraFormats: ["DD-MM-yyyy", "DD/MM/yyyy", "yyyy"],
    icons: {
        date: "ti ti-calendar",
        up: "ti ti-chevron-up",
        down: "ti ti-chevron-down",
        previous: 'ti ti-chevron-left',
        next: 'ti ti-chevron-right',
        time: "ti ti-alarm"
    },
    keyBinds: {
        left: null,
        right: null,
    }
  });
}

function configTime() {
  $('.input-time').datetimepicker({
  locale: 'vi',
  useStrict: true,
  format: "HH:mm",
  icons: {
      date: "ti ti-calendar",
      up: "ti ti-chevron-up",
      down: "ti ti-chevron-down",
      previous: 'ti ti-chevron-left',
      next: 'ti ti-chevron-right',
      time: "ti ti-alarm"
  },
});
}
function formatDay(inputString) {
  if (inputString) {
      var inputDate = new Date(inputString);
      var day = inputDate.getDate();
      if (day < 10) {
          day = '0' + day;
      }
      var month = inputDate.getMonth() + 1;
      if (month < 10) {
          month = '0' + month;
      }
      var year = inputDate.getFullYear();
      return day + '-' + month + '-' + year;
  } else {
      return ""
  }
}

function configMonth() {
    var today = new Date();
    $('.input-month').datetimepicker({
  locale: 'vi',
  useStrict: true,
    defaultDate: today,
    format: "MM-yyyy",
  icons: {
      date: "ti ti-calendar",
      up: "ti ti-chevron-up",
      down: "ti ti-chevron-down",
      previous: 'ti ti-chevron-left',
      next: 'ti ti-chevron-right',
      time: "ti ti-alarm"
  },
});
}

function formatEvenNumber(number) {
  if (number == null) return 0;
  return number.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}
function roundToInteger(number) {
  if (number == null) return 0;
  return Math.round(number).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}
