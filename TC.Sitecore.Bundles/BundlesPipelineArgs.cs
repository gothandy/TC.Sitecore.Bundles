using Sitecore.Pipelines;
using System.Web.Optimization;

namespace TC.Sitecore.Bundles
{
    public class BundlesPipelineArgs : PipelineArgs
    {
        private BundleCollection bundles;

        public Bundle GetOrAddScriptBundle(string bundleVirtualPath)
        {
            Bundle bundle = bundles.GetBundleFor(bundleVirtualPath);

            if (bundle == null)
            {
                bundle = new ScriptBundle(bundleVirtualPath);
                bundles.Add(bundle);
            }
            return bundle;
        }

        public Bundle GetOrAddStyleBundle(string bundleVirtualPath)
        {
            Bundle bundle = bundles.GetBundleFor(bundleVirtualPath);

            if (bundle == null)
            {
                bundle = new StyleBundle(bundleVirtualPath);
                bundles.Add(bundle);
            }
            return bundle;
        }

        public BundlesPipelineArgs(BundleCollection bundles)
        {
            this.bundles = bundles;
        }
    }
}