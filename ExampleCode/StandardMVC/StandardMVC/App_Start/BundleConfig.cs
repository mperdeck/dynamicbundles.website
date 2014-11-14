using System.Web;
using System.Web.Optimization;

namespace StandardMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Need to create bundles yourself, in code. 
            // Must always make sure to include the right files in the right order.

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/shared/js").Include(
                        "~/Scripts/SharedCode.js",
                        "~/Scripts/VariousCode.js"));

            bundles.Add(new ScriptBundle("~/bundles/pile/js").Include(
                        "~/Scripts/PileOfCode.js"));

            bundles.Add(new StyleBundle("~/Content/shared/css").Include(
                        "~/Content/Reset.css",
                        "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/account/css").Include("~/Content/Account.css"));
        }
    }
}