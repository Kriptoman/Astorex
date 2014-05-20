HomeView = Backbone.View.extend({
    el: "#view-board",

    events: {
        "change #Sprints": "onSprintChanged"
    },

    initialize: function () {
        //temporary hardcoded
        this.getWorkItemsGridUrl = "/workitems/getworkitemsgrid?sprintId={0}";

        $.get(this.getWorkItemsGridUrl.format(null), function (data) {
            $("#workitems-grid", this.el).html(data);
        });
    },

    onSprintChanged: function (event) {
        var sprintId = $(event.currentTarget).val();

        if (sprintId) {
            $.get(this.getWorkItemsGridUrl.format(sprintId), function (data) {
                $("#workitems-grid", this.el).html(data);
            });
        }
    },

});