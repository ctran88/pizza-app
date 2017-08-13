using System.Web.Optimization;

namespace Pizza_App
{
    public class BundleConfig
    {
        public static void RegisterScriptBundles(BundleCollection bundles)
        {
            const string APP_ROOT = "~/Scripts/app/";
            const string VIRTUAL_BUNDLE_PATH = "~/bundles/app";
            
            bundles.Add(new ScriptBundle(VIRTUAL_BUNDLE_PATH)
                .Include("~/Scripts/vendor/angular.js")
                .Include(APP_ROOT + "services/IndexService.js")
                .Include(APP_ROOT + "controllers/IndexController.js")
                .Include(APP_ROOT + "Module.js")
                .IncludeDirectory(APP_ROOT, "*.js", searchSubdirectories: true));

            BundleTable.EnableOptimizations = true;
        }
    }
}