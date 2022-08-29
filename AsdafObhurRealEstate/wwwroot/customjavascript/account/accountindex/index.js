

$(document).on('change', '.employee-search', function () {
    const inputEle = document.querySelector('[data-search="search-input"]')
    $.ajax({
        url: `/account/SearchUser?userName=${inputEle.value}`,
        type: "Get",
        success: (data) => {
            $("#data-table").find("tr").remove();
            data.forEach(element => {
                let dateHijri = element.createdAt;
                $("#data-table").append(`
                                      <tr>
                                        <td class="d-flex px-2">
                                            <div class="my-auto">
                                                <h6 class="mb-0 text-xs" >${element.code}</h6>
                                            </div>
                                        </td>
                                        <td>
                                        <div class="d-flex px-2">
                                            <div class="my-auto">
                                            <h6 class="mb-0 text-xs">${element.fullName}</h6>
                                            </div>
                                        </div>
                                        </td>
                                        <td>
                                        <p dir="rtl" class="text-xs font-weight-normal mb-0">${element.phoneNumber}</p>
                                        </td>
                                        <td class="align-middle">
                                            <a class="text-secondary font-weight-bold text-xs" href="/account/detailsOfEmployee?userId=${element.id}" >
                                            <span class="material-symbols-outlined">
                                                <i title="تفاصيل" class="material-icons-round opacity-10">info</i>
                                            </span>
                                            </a>

                                        <a class="del-record text-secondary font-weight-bold text-xs" data-id="${element.id}" >
                                                <span class="material-symbols-outlined">
                                                    <i title="مسح" class="material-icons-round opacity-10" >delete</i>
                                                </span>
                                            </a>
                                        </td>
                                    </tr>
                              
                                  `)
            });


        },
        error: function (eventFromParam) {
            Swal.fire({
                title: 'خطأ اثناء البحث',
            })
        }
    })
});


$(document).on('click', '.del-record', function () {
    var id = $(this).data("id");
    var data = { id };
    Swal.fire({
        title: 'هل أنت متأكد من أنك تريد المسح؟',
        text: "أنت لا تستطيع ارجاع عن هذا الاجراء بعد ذلك",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'نعم !',
        cancelButtonText: 'إالغاء !'
    }).then((result) => {
        if (result.isConfirmed) {
            debugger;
            $.ajax({
                url: '/Account/DeleteConfirmed',
                type: "POST",
                contentType: 'application/x-www-form-urlencoded',
                data: data,
                success: (data) => {
                    $(this).parent().parent().remove();
                    Swal.fire(
                        'مسح!',
                        'تم المسح بنجاح.',
                        'تم'
                    )
                },
                error: function (eventFromParam) {
                    debugger;
                    console.log(eventFromParam.responseText);
                    console.log(eventFromParam.status);
                    console.log(eventFromParam.responseJSON);
                    console.log(eventFromParam.statusText);
                    Swal.fire({
                        title: 'خطأ اثناء المسح',
                        text: "يجب مسح العملاء المرتبطتين بهذا الموظف"
                    })
                }
            })
        }
    })
});



