using System;
using CompanyName.ModuleName.Components.Common;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Security;
using DotNetNuke.Security.Permissions;
using DotNetNuke.UI;

namespace CompanyName.ModuleName
{
    public partial class Loader : CustomModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomModuleBase form = null;
            string view = "";
            switch (Null.SetNullString(Request.QueryString["View"]))
            {
                case "":
                    view = Null.SetNullString(Settings["View"]);
                    if (view != "")
                    {
                        var settingsView = ControlUtilities.LoadControl<CustomModuleBase>(phOutput.TemplateControl, ControlPath + "Views/" + view);
                        settingsView.SelectedControl = view.Replace(".ascx", "");
                        settingsView.ID = view.Replace(".ascx", "");
                        phOutput.Controls.Add(settingsView);
                    }
                    else
                    {
                        var defaultView = ControlUtilities.LoadControl<CustomModuleBase>(phOutput.TemplateControl, ControlPath + "Views/NoSettings.ascx");
                        defaultView.SelectedControl = "NoSettings";
                        defaultView.ID = "NoSettings";
                        phOutput.Controls.Add(defaultView);
                    }

                    break;

                default:
                    view = Null.SetNullString(Request.QueryString["View"]);
                    form = ControlUtilities.LoadControl<CustomModuleBase>(phOutput.TemplateControl, ControlPath + "Views/" + view + ".ascx");
                    form.ID = view;
                    form.SelectedControl = view;
                    phOutput.Controls.Add(form);
                    break;
            }

        }

        public ModuleActionCollection ModuleActions
        {
            get
            {
                var actions = new ModuleActionCollection();
                if (ModulePermissionController.CanManageModule(ModuleConfiguration))
                {
                    actions.Add(GetNextActionID(), "Configuration", "", "", "edit.gif", EditUrl("view", "configure", "Loader"), false, SecurityAccessLevel.Edit, true, false);
                }
                return actions;
            }

        }
    }
}