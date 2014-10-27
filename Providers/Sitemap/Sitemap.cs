using System.Collections.Generic;
using DotNetNuke.Entities.Portals;
using DotNetNuke.Services.Sitemap;

namespace CompanyName.ModuleName.Providers.Sitemap
{
    public class Core : SitemapProvider
    {
        public override List<SitemapUrl> GetUrls(int portalId, PortalSettings ps, string version)
        {
            List<SitemapUrl> urls = new List<SitemapUrl>();

            return urls;
        }



    }
}