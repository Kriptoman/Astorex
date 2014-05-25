DashboardView = Backbone.View.extend({
	el: ".navbar",

	events: {
		"click #menu a": "onMenuItemClick",
	},

	initialize: function () {
		$("#menu > li:first", this.el).addClass("active");
	},

	onMenuItemClick: function () {
		var menuItems = $("#menu li", this.el);


	},
});