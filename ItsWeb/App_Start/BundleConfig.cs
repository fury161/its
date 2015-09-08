using System.Web;
using System.Web.Optimization;

namespace ItsWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/kendo/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo")
                .Include("~/Scripts/kendo/kendo.all.js")
                .Include("~/Scripts/kendo/kendo.web.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include("~/Scripts/app/app.js")
                .Include("~/Scripts/app/index.js")
                .Include("~/Scripts/app/loginForm.js")
                .Include("~/Scripts/app/newIncident.js"));
            /*
                        // Enable CDN
                        bundles.UseCdn = true;
                        // CDN paths for kendo stylesheet files
                        var kendoCommonCssPath = "http://cdn.kendostatic.com/2013.1.319/styles/kendo.common.min.css";
                        var kendoDefaultCssPath = "http://cdn.kendostatic.com/2013.1.319/styles/kendo.default.min.css";
                        // CDN paths for kendo javascript files
                        var kendoWebJsPath = "http://cdn.kendostatic.com/2012.2.710/js/kendo.web.min.js";

                        bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

                        bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

                        // Use the development version of Modernizr to develop with and learn from. Then, when you're
                        // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
                        bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

                        #region Foundation Bundles

                        bundles.Add(Foundation.Styles());
                        bundles.Add(Foundation.Scripts());

                        // Create the CDN bundles for kendo javascript files
                        bundles.Add(new ScriptBundle("~/bundles/kendo/web/js", kendoWebJsPath).Include("~/Scripts/kendo/kendo.web.js"));
                        // The ASP.NET MVC script file is not available from the Kendo Static CDN,
                        // so we will include the bundle reference without the CDN path.
                        bundles.Add(new ScriptBundle("~/bundles/kendo/mvc/js").Include("~/Scripts/kendo/kendo.aspnetmvc.js"));
                        // Create the CDN bundles for the kendo styleshseet files
                        bundles.Add(new StyleBundle("~/bundles/kendo/common/css", kendoCommonCssPath).Include("~/Content/kendo/kendo.common.css"));
                        bundles.Add(new StyleBundle("~/bundles/kendo/default/css", kendoDefaultCssPath).Include("~/Content/kendo/kendo.default.css"));

                        #endregion Foundation Bundles
                         * */
        }
    }
}