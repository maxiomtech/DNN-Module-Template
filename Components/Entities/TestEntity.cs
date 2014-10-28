using DotNetNuke.ComponentModel.DataAnnotations;

namespace CompanyName.ModuleName.Components.Entities
{

    [PrimaryKey("Id")]
    [Scope("ModuleId")]
    [TableName("CompanyName_ModuleName_TestEntity")] //You will have to manually create this table and add it to your .SqlDataProvider
    public class TestEntity
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Name { get; set; }
    }
}