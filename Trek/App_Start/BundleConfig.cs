﻿using System.Web;
using System.Web.Optimization;


namespace Trek
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.countdown.js",
                        "~/Scripts/jquery-{version}.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                            "~/Content/jquery.countdown.css",
                            "~/Content/site.css"));
            
            
        }
         
    }
}