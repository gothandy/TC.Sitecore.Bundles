using Sitecore.Pipelines;
using System.Web.Optimization;

namespace TC.Sitecore.Bundles
{
    public class BundlesPipelineArgs : PipelineArgs
    {
        private BundleCollection bundles;

        public BundlesPipelineArgs(BundleCollection bundles)
        {
            this.bundles = bundles;
        }

        public BundleCollection Bundles
        {
            get
            {
                return this.bundles;
            }
        }
    }
}