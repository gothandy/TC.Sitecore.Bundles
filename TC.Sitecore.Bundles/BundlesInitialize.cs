using Sitecore;
using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace TC.Sitecore.Bundles
{
    public class BundlesInitialize
    {
        [UsedImplicitly]
        public virtual void Process(PipelineArgs args)
        {
            var bundles = new BundlesPipelineArgs(BundleTable.Bundles);

            CorePipeline.Run("bundleConfig", bundles);
        }
    }
}