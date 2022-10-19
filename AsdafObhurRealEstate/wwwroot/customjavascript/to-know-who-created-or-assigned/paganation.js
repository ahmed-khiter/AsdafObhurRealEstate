
$(document).on("click", ".paganiation-js", function () {

    var pageNumber = $(this).data("idpage");
    let data = {
        page: pageNumber,
    };

    $.ajax({
        url: '/client/PaginationClient?userId=' + userId+'&isCreated='+isCreated,
        type: "POST",
        contentType: 'application/x-www-form-urlencoded',
        data: data,
        success: (data) => {
            $("#data-table").find("tr").remove();
            if (isDeletDisplay) {
                data.data.forEach((element) => {
                    $("#data-table").append(`
                                            <tr>
                                                <td>
                                                    <div class="d-flex px-2">
                                                        <div class="my-auto">
                                                            <h6 class="mb-0 fs-6">${element.code}</h6>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td>
                                                    <div class="d-flex px-2">
                                                        <div class="my-auto">
                                                            <h6 class="mb-0 fs-6">${element.name}</h6>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td>
                                                    <h6 dir="rtl" class="fs-6 mb-0">${element.phoneNumber}</h6>
                                                </td>
                                                    <td>
                                                    <div class="d-flex px-2">
                                                        <div class="my-auto">
                                                    <h6 class="mb-0 fs-6">${element.status}</h6>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td class="align-middle">
                                                            <a class="text-secondary font-weight-bold text-xs" href="/Client/details?clientId=${element.id}">
                                                        <span class="material-symbols-outlined fs-6">
                                                            <i title="تفاصيل" class="material-icons-round opacity-10">info</i>
                                                        </span>
                                                    </a>

                                                    <a class="del-record text-secondary font-weight-bold text-xs" data-id="${element.id}">
                                                        <span class="material-symbols-outlined">
                                                            <i title="مسح" class="material-icons-round opacity-10">delete</i>
                                                        </span>
                                                    </a>
                                                </td>
                                            </tr>
                                    `)
                });
            } else {
                data.data.forEach((element) => {
                    $("#data-table").append(`
                                    <tr>
                                        <td>
                                            <div class="d-flex px-2">
                                                <div class="my-auto">
                                                    <h6 class="mb-0 fs-6">${element.code}</h6>
                                                </div>
                                            </div>
                                        </td>
                                        <td>
                                            <div class="d-flex px-2">
                                                <div class="my-auto">
                                                    <h6 class="mb-0 fs-6">${element.name}</h6>
                                                </div>
                                            </div>
                                        </td>
                                        <td>
                                            <h6 dir="rtl" class="fs-6 mb-0">${element.phoneNumber}</h6>
                                        </td>
                                            <td>
                                            <div class="d-flex px-2">
                                                <div class="my-auto">
                                            <h6 class="mb-0 fs-6">${element.status}</h6>
                                                </div>
                                            </div>
                                        </td>
                                        <td class="align-middle">
                                            <a class="text-secondary font-weight-bold text-xs" href="/Client/details?clientId=${element.id}">
                                                <span class="material-symbols-outlined fs-6">
                                                    <i title="تفاصيل" class="material-icons-round opacity-10">info</i>
                                                </span>
                                            </a>

                                        </td>
                                    </tr>
                            `)
                });
            }
        },
        error: function (eventFromParam) {

        }
    })

});