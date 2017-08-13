using System.Web.Optimization;

namespace Pizza_App
{
    public class BundleConfig
    {
        public static void RegisterScriptBundles(BundleCollection bundles)
        {
            const string APP_ROOT = "~/Scripts/app/";
            const string CONTENT_ROOT = "~/Content/";
            const string BUNDLE_PATH = "~/bundles/";

            bundles.Add(new ScriptBundle(BUNDLE_PATH + "app")
                .Include("~/Scripts/vendor/angular.min.js")
                .Include(APP_ROOT + "services/IndexService.js")
                .Include(APP_ROOT + "controllers/IndexController.js")
                .Include(APP_ROOT + "Module.js")
                .IncludeDirectory(APP_ROOT, "*.js", searchSubdirectories: true));

            bundles.Add(new StyleBundle(BUNDLE_PATH + "css")
                .Include(CONTENT_ROOT + "angular-material.css")
                .Include(CONTENT_ROOT + "angular-material-layout-attributes.css")
                .Include(CONTENT_ROOT + "angular-material-layouts.css")
                .Include(CONTENT_ROOT + "angular-material-layouts.ie_fixes.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}