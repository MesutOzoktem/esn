using System.Web;
using System.Web.Optimization;

namespace EDUCATIONAL_SOCIAL_NETWORK
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                      "~/Content/font-awesome/css/font-awesome.css"
                ));
            bundles.Add(new StyleBundle("~/Script/alertBoxModal").Include(
                      "~/Scripts/alertBoxModal.js"
                ));

            bundles.Add(new StyleBundle("~/Content/HomePageCss").Include(
                      "~/Content/Home/lib/animate/animate.min.css",
                      "~/Content/Home/lib/ionicons/css/ionicons.min.css",
                      "~/Content/Home/lib/magnific-popup/magnific-popup.css",
                      "~/Content/Home/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/Content/HomePageJS_1").Include(
                      "~/Content/Home/lib/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/Home/lib/easing/easing.min.js",
                      "~/Content/Home/lib/wow/wow.min.js",
                      "~/Content/Home/lib/superfish/hoverIntent.js"
                      
                ));
            bundles.Add(new ScriptBundle("~/Content/HomePageJS_2").Include(
                      "~/Content/Home/lib/superfish/superfish.min.js",
                      "~/Content/Home/lib/magnific-popup/magnific-popup.min.js",
                      "~/Content/Home/contactform/contactform.js",
                      "~/Content/Home/js/main.js"
                ));
        }
    }
}