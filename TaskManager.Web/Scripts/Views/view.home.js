HomeView = Backbone.View.extend({
    el: "#view-board",

    events: {
        "change #Sprints, #Employees": "onFilterChanged",
    },

    initialize: function () {
        //temporary hardcoded
        this.getWorkItemsGridUrl = "/workitems/getworkitemsgrid?sprintId={0}&userId={1}";

        $.get(this.getWorkItemsGridUrl.format(null, null), function (data) {
            $("#workitems-grid", this.el).html(data);
        });
    },

    onFilterChanged: function () {
        var sprintId = $('#Employees', this.el).val();
        var userId = $('#Sprints', this.el).val();

        $.get(this.getWorkItemsGridUrl.format(sprintId, userId), function (data) {
            $("#workitems-grid", this.el).html(data);
        });
    },
});