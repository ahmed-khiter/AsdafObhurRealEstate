$(document).on("click", "#downloadFile", function () {
    var downloadFile = $(this).data("downloadfilebyname");
    console.log(downloadFile);

    const inputEle = document.querySelector('[data-downloadFile="download"]')
    window.open(document.location.origin + "/client/DownloadFile?fileName=" + downloadFile, '_blank');
});


$(document).on("click", "#oldBill", function () {
    var clientId = $(this).data("id");
    window.open(document.location.origin + "/client/DownloadBill?clientId=" + clientId, '_blank');
});

