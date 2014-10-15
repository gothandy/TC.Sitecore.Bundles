using System.Web.Optimization;
using Sitecore;
using Sitecore.Pipelines;

namespace TC.Sitecore.Bundles
{
    public class BundleConfig
    {
        [UsedImplicitly]
        public virtual void Process(PipelineArgs args)
        {
            RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/JavaScript").Include("~/Scripts/*.js"));

            bundles.Add(new StyleBundle("~/bundles/StyleSheet").Include("~/Content/*.css"));
        }

    }
}