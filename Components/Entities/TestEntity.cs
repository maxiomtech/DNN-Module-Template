using DotNetNuke.ComponentModel.DataAnnotations;

namespace CompanyName.ModuleName.Components.Entities
{

    [PrimaryKey("Id")]
    [Scope("ModuleId")]
    [TableName("CompanyName_ModuleName_TestEntity")]
    public class TestEntity
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Name { get; set; }
    }
}