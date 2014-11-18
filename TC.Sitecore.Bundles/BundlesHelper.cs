using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace TC.Sitecore.Bundles
{
    public class BundlesHelper
    {
        private BundleCollection bundles;

        public BundlesHelper(BundleCollection bundles)
        {
            this.bundles = bundles;
        }

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
    }
}
