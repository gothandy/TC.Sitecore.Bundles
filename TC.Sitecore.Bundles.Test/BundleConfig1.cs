using Sitecore;

namespace TC.Sitecore.Bundles
{
    public class BundleConfig1
    {
        [UsedImplicitly]
        public virtual void Process(BundlesPipelineArgs bundles)
        {
            bundles.GetOrAddScriptBundle("~/bundles/JavaScript").Include("~/Scripts/JavaScript1.js");
            bundles.GetOrAddStyleBundle("~/bundles/StyleSheet").Include("~/Content/StyleSheet1.css");
        }
    }
}