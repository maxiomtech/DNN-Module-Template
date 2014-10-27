using Autofac;
using CompanyName.ModuleName.Components.Data;
using CompanyName.ModuleName.Components.DI;
using DotNetNuke.Web.Api;

namespace CompanyName.ModuleName.Components.WebApi
{
    public class ModuleNameController : DnnApiController
    {

        public IDataRepository DataRepository { get; set; }
        
        public ModuleNameController()
        {
            Bindings.Container.InjectUnsetProperties(this);
        }


        //Primary Attributes

        //[HttpPost]
        //[HttpGet]
        //[AllowAnonymous]
        //[RequireHost]
        //[ValidateAntiForgeryToken]
        //[DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
        //[DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
        



    }
}