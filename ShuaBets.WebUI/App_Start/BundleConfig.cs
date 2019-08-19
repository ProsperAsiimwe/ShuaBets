using System.Web;
using System.Web.Optimization;

namespace ShuaBets.WebUI
{
    public class BundleConfig
    {
      
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/styles/core").Include(
                   "~/Content/coreAssets/css/bootstrap.css",
                   "~/Content/coreAssets/css/slick.css",
                   "~/Content/coreAssets/js/dl-menu/component.css",
                   "~/Content/coreAssets/css/font-awesome.css",
                   "~/Content/coreAssets/css/linearicons.css",
                   "~/Content/coreAssets/css/typography.css",
                   "~/Content/coreAssets/css/widget.css",
                   "~/Content/coreAssets/css/shortcodes.css",
                   "~/Content/coreAssets/style.css",
                   "~/Content/coreAssets/css/color.css",
                   "~/Content/coreAssets/css/responsive.css",
                   "~/Content/coreAssets/css/style.css",
                   "~/Content/coreAssets/css/bootstrap-datepicker.css",
                   "~/Content/coreAssets/css/bootstrap-datetimepicker.css",
                    "~/Content/coreAssets/css/jquery.bbslider"));


            bundles.Add(new ScriptBundle("~/bundles/sitescripts").Include(
                        "~/Content/coreAssets/js/jquery.js",
                        "~/Content/coreAssets/js/bootstrap.js",
                        "~/Content/coreAssets/js/slick.min.js",
                        "~/Content/coreAssets/js/dl-menu/modernizr.custom.js",
                        "~/Content/coreAssets/js/dl-menu/jquery.dlmenu.js",
                        "~/Content/coreAssets/js/custom.js",                       
                       "~/Scripts/bootstrap.js",
                       "~/Scripts/bootstrap-datepicker.js",
                     "~/Scripts/TwitterBootstrapMvcJs.js",
                     "~/Scripts/admin/admin-datetime.js",
                     "~/Scripts/moment.js",
                     "~/Scripts/bootstrap-datetimepicker.js",
                     "~/Scripts/bootstrap-tabcollapse.js",
                     "~/Scripts/respond.js",
                     "~/Content/coreAssets/js/slider/jquery-3.2.1.min.js",
                     "~/Content/coreAssets/js/slider/jquery.bbslider.min.js"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(                    
            //         "~/Scripts/bootstrap-datepicker.js",
            //         "~/Scripts/TwitterBootstrapMvcJs.js",
            //         "~/Scripts/admin/admin-datetime.js",                    
            //         "~/Scripts/moment.js",
            //         "~/Scripts/bootstrap-datetimepicker.js",
            //         "~/Scripts/bootstrap-tabcollapse.js",                    
            //         "~/Scripts/respond.js"));


         
            bundles.Add(new StyleBundle("~/Content/styles/login").Include(
                     "~/Content/loginAssets/css/font-awesome.min.css",
                     "~/Content/loginAssets/css/style.css"));


        }
    }
}
