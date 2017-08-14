using System.Web.Optimization;

namespace Pizza_App
{
    public class BundleConfig
    {
        public static void RegisterScriptBundles(BundleCollection bundles)
        {
            const string APP_ROOT = "~/Scripts/app/";
            const string VENDOR_ROOT = "~/Scripts/vendor/";
            const string CONTENT_ROOT = "~/Content/";
            const string BUNDLE_PATH = "~/bundles/";

            // Must load angular script with module files or else throws unknown provider error
            bundles.Add(new ScriptBundle(BUNDLE_PATH + "app")
                .Include("~/Scripts/angular.js")
                .Include(APP_ROOT + "services/IndexService.js")
                .Include(APP_ROOT + "controllers/IndexController.js")
                .Include(APP_ROOT + "Module.js")
                .IncludeDirectory(APP_ROOT, "*.js", searchSubdirectories: true));

            bundles.Add(new ScriptBundle(BUNDLE_PATH + "vendor")
                .IncludeDirectory(VENDOR_ROOT, "*.js", searchSubdirectories: true));

            bundles.Add(new StyleBundle(BUNDLE_PATH + "css")
                .IncludeDirectory(CONTENT_ROOT, "*.css", searchSubdirectories: true));

            BundleTable.EnableOptimizations = true;
        }
    }
}