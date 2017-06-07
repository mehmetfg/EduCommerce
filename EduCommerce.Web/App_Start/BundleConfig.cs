using System.Web;
using System.Web.Optimization;

namespace EduCommerce.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Areas/Admin/Content/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Areas/Admin/Content/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Areas/Admin/Content/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Areas/Admin/Content/plugins/jQuery/jQuery-2.1.4.min.js",
                   "~/Areas/Admin/Content/Scripts/jquery-ui.min.js",
                   "~/Areas/Admin/Content/Scripts/bootstrap.min.js",
                   "~/Areas/Admin/Content/Scripts/raphael-min.js",
                    "~/Areas/Admin/Content/plugins/morris/morris.min.js",
                   "~/Areas/Admin/Content/plugins/sparkline/jquery.sparkline.min.js",
                    "~/Areas/Admin/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                   "~/Areas/Admin/Content/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                   "~/Areas/Admin/Content/plugins/knob/jquery.knob.js",
                    "~/Areas/Admin/Content/Scripts/moment.min.js",
                   "~/Areas/Admin/Content/plugins/daterangepicker/daterangepicker.js",
                    "~/Areas/Admin/Content/plugins/datepicker/bootstrap-datepicker.js",
                   "~/Areas/Admin/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                    "~/Areas/Admin/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                   "~/Areas/Admin/Content/plugins/fastclick/fastclick.min.js",
                   "~/Areas/Admin/Content/Scripts/app.min.js",
                   "~/Areas/Admin/Content/Scripts/pages/dashboard.js",
                   "~/Areas/Admin/Content/Scripts/demo.js",
                      "~/Areas/Admin/Content/Scripts/bootstrap.js",
                      "~/Areas/Admin/Content/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Areas/Admin/Content/css").Include(
                "~/Areas/Admin/Content/bootstrap.min.css",
                "~/Areas/Admin/Content/fa/font-awesome.min.css",
                "~/Areas/Admin/Content/ionic/ionicons.min.css",
                "~/Areas/Admin/Content/AdminLTE.css",
                "~/Areas/Admin/Content/skins/_all-skins.min.css",
                "~/Areas/Admin/Content/plugins/iCheck/flat/blue.css",
                "~/Areas/Admin/Content/plugins/morris/morris.css",
                "~/Areas/Admin/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                "~/Areas/Admin/Content/plugins/datepicker/datepicker3.css",
                "~/Areas/Admin/Content/plugins/daterangepicker/daterangepicker-bs3.css",
                "~/Areas/Admin/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"));
        }
    }
}
