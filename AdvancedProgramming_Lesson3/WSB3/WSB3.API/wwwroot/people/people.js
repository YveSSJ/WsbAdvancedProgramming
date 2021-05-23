const uri = "api/Person";
let people = null;
function getCount(data) {
    const el = $("#counter");
    let name = "person";
    if (data) {
        if (data > 1) {
            name = "people";
        }
        el.text(data + " " + name);
    } else {
        el.text("No " + name);
    }
}
$(document).ready(function () {
    getData();
});
function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#people");
            $(tBody).empty();
            getCount(data.length);
            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.firstName))
                    .append($("<td></td>").text(item.lastName))
                    .append(
                        $("<td></td>").append(
                            $("<button>Edit</button>").on("click", function () {
                                editItem(item.id);
                            })
                        )
                    )
                    .append(
                        $("<td></td>").append(
                            $("<button>Delete</button>").on("click", function () {
                                deleteItem(item.id);
                            })
                        )
                    );
                tr.appendTo(tBody);
            });
            people = data;
        }
    });
}
function addItem() {
    const item = {
        firstName: $("#add-firstName").val(),
        lastName: $("#add-lastName").val()
    };
    $.ajax({
        type: "POST",
        accepts: "application/json",
        url: uri,
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
            $("#add-firstName").val("");
            $("#add-lastName").val("");
        }
    });
}
function deleteItem(id) {
    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        success: function (result) {
            getData();
        }
    });
}
function editItem(id) {
    $.each(people, function (key, item) {
        if (item.id === id) {
            $("#edit-firstName").val(item.firstName);
            $("#edit-lastName").val(item.lastName);
            $("#edit-id").val(item.id);
        }
    });
    $("#spoiler").css({ display: "block" });
}
$(".my-form").on("submit", function () {
    const item = {
        firstName: $("#edit-firstName").val(),
        lastName: $("#edit-lastName").val(),
        id: $("#edit-id").val()
    };
    $.ajax({
        url: uri + "/" + $("#edit-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        success: function (result) {
            getData();
        }
    });
    closeInput();
    return false;
});
function closeInput() {
    $("#spoiler").css({ display: "none" });
}