TC.Sitecore.Bundles
===================

This project creates a new pipeline within Sitecore. This pipeline allows developers to add one or more BundleConfig classes during Initialization. The aim is to be able to package together a SubLayout with Style and Script dependancies without needing to touch the main layout. Using the `Microsoft.AspNet.Web.Optimization` framework.

===================

#Instructions

Begin by installing the NuGet package. Check WebGrease is added to `Web.config` as a `dependantAssemby`.

```Install-Package TC.Sitecore.Bundles```

Add a class and use the supplied GetOrAdd methods.

```
using Sitecore;

namespace TC.Sitecore.Bundles
{
    public class BundleConfig1
    {
        [UsedImplicitly]
        public virtual void Process(BundlesPipelineArgs bundles)
        {
            bundles.GetOrAddScriptBundle("~/bundles/JavaScript").Include(
                "~/Scripts/JavaScript1.js");
            bundles.GetOrAddStyleBundle("~/bundles/StyleSheet").Include(
                "~/Content/StyleSheet1.css");
        }
    }
}
```

Create a config file.

```
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <pipelines>
      <bundleConfig>
        <processor type="TC.Sitecore.Bundles.BundleConfig1, TC.Sitecore.Bundles.Test" />
      </bundleConfig>
    </pipelines>
  </sitecore>
</configuration>
```

When working in your Layout use the usual format.

```
@Styles.Render("~/Bundles/StyleSheet")
@Scripts.Render("~/Bundles/JavaScript")
```

Dont' forget the namespace reference.

`<add namespace="System.Web.Optimization" />`

===================
Tested with Sitecore 7.2 rev. 140526

