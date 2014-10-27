using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using DotNetNuke.Common;
using DotNetNuke.Web.Client.ClientResourceManagement;

namespace CompanyName.ModuleName.Components.Common
{
    public class Utils
    {

        public static void InjectAngular(Page page, string controlName)
        {


            var rootPath = String.Concat(HttpRuntime.AppDomainAppPath, Constants.RelativeClientPath);
            var appRoot = Globals.GetAbsoluteServerPath(page.Request);

            if (Directory.Exists(string.Concat(rootPath, controlName)))
            {
                AddFiles(page, "Common", rootPath, appRoot);
            }

            if (Directory.Exists(string.Concat(rootPath, controlName)))
            {
                AddFiles(page, controlName, rootPath, appRoot);
            }


        }

        private static void AddFiles(Page page, string controlName, string rootPath, string appRoot)
        {
            Directory.GetFiles(String.Concat(rootPath, controlName), "*.js", SearchOption.AllDirectories)
                .Reverse()
                .ToList()
                .ForEach(x => ClientResourceManager.RegisterScript(page, page.ResolveUrl(x.Replace(appRoot, "")), 400, "DnnFormBottomProvider"));
        }

    }
}