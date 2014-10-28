using System;
using CompanyName.ModuleName.Components.Common;
using DotNetNuke.Common;

namespace CompanyName.ModuleName.Views
{
    public partial class Configuration : CustomModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsEditable)
            {
                Response.Redirect(Globals.NavigateURL(TabId));
            }
        }
    }
}