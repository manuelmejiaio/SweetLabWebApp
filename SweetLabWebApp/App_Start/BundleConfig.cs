using System.Web;
using System.Web.Optimization;

namespace SweetLabWebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/javascripts/jquery.js",
                        "~/assets/javascripts/fancybox/jquery.fancybox.pack.js"));


            bundles.Add(new ScriptBundle("~/bundles/modernizer").Include(
                        "~/assets/javascripts/modernizr.custom.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/assets/javascripts/slick.js",
                      "~/assets/javascripts/wow/wow.js",
                      "~/assets/javascripts/custom.js",
                      "~/assets/javascripts/classie.js",
                      "~/assets/javascripts/pathLoader.js",
                      "~/assets/javascripts/main.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/assets/stylesheets/css/bootstrap.css",
                      "~/assets/stylesheets/css/font-family.css",
                      "~/assets/stylesheets/css/responsive.css",
                      "~/assets/stylesheets/css/slick.css",
                      "~/assets/stylesheets/css/slick-theme.css",
                      "~/assets/stylesheets/css/style.css",
                      "~/assets/stylesheets/css/animate.css",
                      "~/assets/javascripts/fancybox/jquery.fancybox.css",
                      "~/assets/stylesheets/css/global.css",
                      "~/assets/stylesheets/css/effect2.css"));
        }
    }
}
