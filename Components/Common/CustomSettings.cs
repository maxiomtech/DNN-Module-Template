using System.Collections;
using DotNetNuke.Entities.Modules;

namespace CompanyName.ModuleName.Components.Common
{
    public class CustomSettings
    {
         public CustomSettings(int ModuleId)
        {
            var mc = new ModuleController();
            var moduleSettings = mc.GetModuleSettings(ModuleId);


            foreach (DictionaryEntry moduleSetting in moduleSettings)
            {
                var prop = this.GetType().GetProperty(moduleSetting.Key.ToString());
                if (prop != null)
                {
                    this.GetType().GetProperty(prop.Name).SetValue(this,moduleSetting.Value);
                }
            }

        }

         public CustomSettings() { }

        public enum Keys
        {
            View
        }


        public string View { get; set; }


    }
}