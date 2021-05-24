const uri = "api/Book";
let books = null;
function getCount(data) {
    const el = $("#counter");
    let name = "book";
    if (data) {
        if (data > 1) {
            name = "books";
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
            const tBody = $("#books");
            $(tBody).empty();
            getCount(data.length);
            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.title))
                    .append($("<td></td>").text(item.author))
                    .append($("<td></td>").text(item.genre))
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
            books = data;
        }
    });
}
function addItem() {
    const item = {
        title: $("#add-title").val(),
        author: $("#add-author").val(),
        genre: $("#add-genre").val()
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
            $("#add-title").val("");
            $("#add-author").val("");
            $("#add-genre").val("");
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
    $.each(books, function (key, item) {
        if (item.id === id) {
            $("#edit-title").val(item.title);
            $("#edit-author").val(item.author);
            $("#edit-genre").val(item.genre);
            $("#edit-id").val(item.id);
        }
    });
    $("#spoiler").css({ display: "block" });
}
$(".my-form").on("submit", function () {
    const item = {
        title: $("#edit-title").val(),
        author: $("#edit-author").val(),
        genre: $("#edit-genre").val(),
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