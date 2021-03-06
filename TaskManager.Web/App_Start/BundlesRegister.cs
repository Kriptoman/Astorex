﻿using System.Web.Optimization;

namespace TaskManager.Web.App_Start
{
    public class BundlesRegister
    {
        public static void Register(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(WebsiteBundles.JsLayout).Include(
                "~/Scripts/jquery-1.9.0.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/scripts/underscore.min.js",
                "~/scripts/backbone.min.js",
                "~/scripts/jquery.blockUI.min.js",
                "~/scripts/jquery-ui-1.10.4.min.js",
                "~/scripts/modules/module.popup.js",
                "~/scripts/common.js",
                "~/scripts/views/view.workitemGrid.js",
                "~/scripts/views/view.home.js",
                "~/scripts/views/view.dashboard.js")
                );

            bundles.Add(new StyleBundle(WebsiteBundles.CssLayout).Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-theme.min.css",
                "~/Content/themes/base/jquery-ui.css",
                "~/Content/common.css")
                );
        }
    }

    public class WebsiteBundles
    {
        public const string JsLayout = "~/scripts/main.js";
        public const string JsDashboard = "~/scripts/dashboard.js";

        public const string CssLayout = "~/content/main.css";
    }
}