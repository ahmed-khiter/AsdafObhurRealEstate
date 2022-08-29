

//#region add new item

$(document).on("click", ".add-new-otherFile", function () {

    let idOfFile = `hasFile-${currentIndex}`;
    let idOfDescriptions = `hasDescription-${currentIndex}`;

    let file = document.getElementById(`${idOfFile}`).value;

    let descriptions = document.getElementById(`${idOfDescriptions}`).value;

    if (file !== '' && descriptions !== '') {

        let removeId = "remove-" + currentIndex;


        let removeButton = document.getElementById(removeId);

        removeButton.removeChild(removeButton.lastElementChild);

        removeButton.remove();

        addNewRow();
       

    }
    else {
        Swal.fire(
            'يجب اختيار الملف و كتابة تفاصيل له.'
        )
    }
});

//#endregion




$(document).on("click", ".minus-row", function () {

    if (document.getElementById("row-" + (currentIndex - 1)) === null) {
        let deleteButton = document.getElementById("delete-" + currentIndex);
        deleteButton.removeChild(deleteButton.lastElementChild);
        deleteButton.remove();
        return;
    }
    let removeRowId = "row-" + (currentIndex - 1);
    let currentRow = "row-" + currentIndex;

    $(`table#table-file tr#${removeRowId}`).remove();
    $(`table#table-file tr#${currentRow}`).remove();

    nextIndex -= 2;
    currentIndex -= 2;
    ids -= 2;


    addNewRow();

});


function addNewRow() {
    $("#appendNewFile").append(`
                            <tr id="row-${nextIndex}">
                                <th scope="row">${nextIndex}</th>
                                <td>
                                    <input type="file" id="hasFile-${nextIndex}" name="NewOtherFiles[${ids}].NewFile" >
                                </td>
                                <td>
                                    <input id="hasDescription-${nextIndex}" name="NewOtherFiles[${ids}].Description" type="text">
                                </td>
                                <td class="d-flex justify-content-center">
                                    <button id="remove-${nextIndex}" type="button" class="add-new-otherFile table-add-btn">
                                        <i class="fas fa-plus fs-6"></i>
                                    </button>
                                </td>
                                <td>
                                        <button id="delete-${nextIndex}" style="background-color:darkred"  type="button" class="minus-row table-add-btn">
                                        <i class="fas fa-minus-circle fs-6"></i>
                                    </button>
                                </td>
                            </tr>

                    `);
    let deletButton = document.getElementById("delete-" + currentIndex);

    if (deletButton !== null) {
        deletButton.removeChild(deletButton.lastElementChild);

        deletButton.remove();
    }

    nextIndex += 1;
    currentIndex += 1;
    ids += 1;
}