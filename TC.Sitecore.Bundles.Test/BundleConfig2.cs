using Sitecore;

namespace TC.Sitecore.Bundles
{
    public class BundleConfig2
    {
        [UsedImplicitly]
        public virtual void Process(BundlesPipelineArgs bundles)
        {
            BundlesHelper helper = new BundlesHelper(bundles.BundleCollection);

            helper.GetOrAddScriptBundle("~/bundles/JavaScript").Include("~/Scripts/JavaScript2.js");
            helper.GetOrAddStyleBundle("~/bundles/StyleSheet").Include("~/Content/StyleSheet2.css");
        }
    }
}