TC.Sitecore.Bundles
===================

An example project showing the modifications required to hook Microsoft.AspNet.Optimization into Sitecore.

===================

<H2>Instructions</H2>
Steps required to add Bundling of scripts and styles.

1. Install Microsoft.AspNet.Optimization NuGet package.
2. Write your BundleConfig.cs
https://github.com/gothandy/TC.Sitecore.Bundles/blob/master/Website/BundleConfig.cs

3. Add this to the Sitecoe initialization pipeline.
4. Add /Bundle to your IgnoreUrlPrefixes.
https://github.com/gothandy/TC.Sitecore.Bundles/blob/master/Website/App_Config/Include/TC.Sitecore.Bundles.config


5. Add namespace to Views/Web.Config.
https://github.com/gothandy/TC.Sitecore.Bundles/blob/master/Website/Views/Web.config

6. Edit your views to use Bundles.
https://github.com/gothandy/TC.Sitecore.Bundles/blob/master/Website/Views/Shared/BundleTest.cshtml

===================
<H2>Issues</H2>

- NuGet adds a reference to WebGrease to your Web.Config this can be lost if your project is outside Sitecore folder.
- Adding /Bundle to IgnoreUrlPrefixes easily broken by other modules/upgrades.
