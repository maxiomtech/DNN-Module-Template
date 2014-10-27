using System;
using System.Web.UI;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Framework;

namespace CompanyName.ModuleName.Components.Common
{
    public class CustomModuleBase : PortalModuleBase
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ServicesFramework.Instance.RequestAjaxAntiForgerySupport();
            Control currentCtl = this;
            while ((currentCtl as PortalModuleBase) == null ||
                   (currentCtl as PortalModuleBase).ModuleConfiguration == null)
            {
                currentCtl = currentCtl.Parent;
            }

            ModuleConfiguration = ((PortalModuleBase)currentCtl).ModuleConfiguration;
            Utils.InjectAngular(this.Page, SelectedControl);
        }

        public string SelectedControl { get; set; }

        public CustomSettings NominationSettings
        {
            get { return new CustomSettings(ModuleId); }

        }

    }
}