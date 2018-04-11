using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SimpleBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Admin/Styles")
                .Include("~/content/Styles/bootstrap.css")
                .Include("~/content/Styles/Admin.css")
            );

            bundles.Add(new StyleBundle("~/Styles")
                .Include("~/content/Styles/bootstrap.css")
                .Include("~/content/Styles/Site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
            .Include("~/scripts/jquery-1.8.0.js")
            .Include("~/scripts(jquey.validate.js")
            .Include("~/scripts/jquey.validate.unobtrusive.js")
            .Include("~/scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~admin/scripts")
            .Include("~/scripts/jquery-1.8.0.js")
            .Include("~/scripts/jquey.validate.js")
            .Include("~/scripts/jquey.validate.unobtrusive.js")
            .Include("~/scripts/bootstrap.js"));
            

        }
    }
}