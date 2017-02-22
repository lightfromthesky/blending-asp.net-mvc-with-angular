﻿using System.Web;
using System.Web.Optimization;

namespace SampleAngularWebMVCApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/angular", "https://ajax.googleapis.com/ajax/libs/angularjs/1.5.6/angular.min.js").Include(
                        "~/Scripts/angular.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-route", "https://ajax.googleapis.com/ajax/libs/angularjs/1.5.6/angular-route.js").Include(
                       "~/Scripts/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-indexCtrl").Include(
           "~/Scripts/controllers/IndexController.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
