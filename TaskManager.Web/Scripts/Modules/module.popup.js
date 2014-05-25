$.popup = {

    create: function (content) {

        var options = {
            modal: true,
            resizable: false,
            autoOpen: true,
            close: function () {
                $(this).dialog("destroy").remove();
            }
        };

        var dialog = $('<div></div>')
            .html(content)
            .appendTo("body");

        options.width = $(":first-child", dialog).width() + 20;

        dialog
            .first()
            .dialog(options)
            .find("form")
            .find(":input:visible:first:not([readonly])")
            .focus();

        dialog.find(".cancel").on("click", function () { dialog.dialog("close"); });
    },

    render: function (data) {
        // implement server side/client side error processing
        this.create(data);
    },

    show: function (action) {
        $.get(action, $.proxy(this.render, this));
    }
};