function hideToast() {
    $("#toast").toast('hide');
    $("#toast").removeClass("bg-success");
    $("#toast").removeClass("bg-danger");
  }
  function showToast(message, statusCode) {
    var backgrounColor;
    $("#toastContent").text(message);
    if (statusCode === 200) {
      backgrounColor = "bg-success";
      $("#toast").addClass(backgrounColor);
    } else {
      backgrounColor = "bg-danger";
      $("#toast").addClass(backgrounColor);
    }
    $("#toast").toast('show');
    setTimeout(function () {
        $("#toast").toast('hide');
    }, 2000);
  }