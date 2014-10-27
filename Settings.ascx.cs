using System.Linq;
using CompanyName.ModuleName.Components.Common;
using DotNetNuke.Entities.Modules;

namespace CompanyName.ModuleName
{
    public partial class Settings : ModuleSettingsBase
    {
        public override void LoadSettings()
        {
            string[] views = System.IO.Directory.
                GetFiles(Server.MapPath(ControlPath + "Views/"), "*.ascx").
                Select(x => x.Substring(x.LastIndexOf("\\") + 1)).
                Where(x => !x.Contains("NoSettings.ascx")).
                ToArray();
            ddlViews.DataSource = views;
            ddlViews.DataBind();

            ddlViews.SelectedValue = Settings.ContainsKey(CustomSettings.Keys.View.ToString()) ? (string)Settings[CustomSettings.Keys.View.ToString()] : "";
        }

        public override void UpdateSettings()
        {
            var mc = new ModuleController();
            mc.UpdateModuleSetting(ModuleId, CustomSettings.Keys.View.ToString(), ddlViews.SelectedValue);
        }
    }
}