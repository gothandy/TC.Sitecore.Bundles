using Sitecore;

namespace TC.Sitecore.Bundles
{
    public class BundleConfig2
    {
        [UsedImplicitly]
        public virtual void Process(BundlesPipelineArgs bundles)
        {
            bundles.GetOrAddScriptBundle("~/bundles/JavaScript").Include("~/Scripts/JavaScript2.js");
            bundles.GetOrAddStyleBundle("~/bundles/StyleSheet").Include("~/Content/StyleSheet2.css");
        }
    }
}