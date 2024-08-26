using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SMS_2.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/sb-admin-2.min.css"));
            bundles.Add(new ScriptBundle("~/Content/vendor").Include(
                "~/Content/vendor/jquery/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/Content/vendor").Include(
                "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/Content/vendor").Include(
                "~/Content/vendor/jquery-easing/jquery.easing.min.js"));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/sb-admin-2.min.js"));
            bundles.Add(new ScriptBundle("~/Content/vendor").Include(
                "~/Content/vendor/chart.js/Chart.min.js"));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/demo/chart-area-demo.js"));
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/demo/chart-pie-demo.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}