WorkitemGridView = Backbone.View.extend({
	el: "#workitems-table",

	events: {
		"click tbody tr": "onItemClick",
	},

	initialize: function () {
		//temporary hardcoded
		this.getWorkItemUrl = "/workitems/getworkitem?id={0}";
	},

	onItemClick: function (event) {
		var itemId = $("td:first-child",event.currentTarget).text();

		$.popup.show(this.getWorkItemUrl.format(itemId));
	},
});