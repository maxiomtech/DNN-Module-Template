using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using Autofac;
using CompanyName.ModuleName.Components.Data;
using CompanyName.ModuleName.Components.DI;
using CompanyName.ModuleName.Components.Entities;
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

        [HttpGet]
        [AllowAnonymous]
        public TestEntity GetTestEntity()
        {
            var testEntity = new TestEntity() {Id = 0, ModuleId = ActiveModule.ModuleID, Name = "Hello World"};
            return testEntity;
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