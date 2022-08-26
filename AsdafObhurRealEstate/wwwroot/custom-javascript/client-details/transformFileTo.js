$(document).on("click", "#transformToFinancial", function () {
    var clientId = $(this).data("getclientid");
    $.ajax({
        url: '/Client/TransformFileToFinancial?clientId=' + clientId,
        type: "POST",
        contentType: 'application/x-www-form-urlencoded',
        data: clientId,
        success: (data) => {
            document.location.reload();
        },
        error: function (eventFromParam) {
            Swal.fire("حدث خطأ أثناء التحويل للماليه حاول مرة اخرى")
        }
    })
});


$(document).on("click", "#finishFile", function () {

    var clientId = $(this).data("getclientid");
    $.ajax({
        url: '/Client/FinisedFile?clientId=' + clientId,
        type: "POST",
        contentType: 'application/x-www-form-urlencoded',
        data: clientId,
        success: (data) => {
        },
        error: function (eventFromParam) {
            Swal.fire(eventFromParam.responseText);
        }
    })
});