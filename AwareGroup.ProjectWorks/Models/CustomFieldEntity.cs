using System;

namespace AwareGroup.ProjectWorks.Models
{
    public class CustomFieldEntity
    {
        public int EntitySubTypeID { get; set; }
        public string EntitySubTypeName { get; set; }
        public int EntityTypeID { get; set; }
        public string EntityTypeName { get; set; }
        public int FieldID { get; set; }
        public string Group { get; set; }
        public bool IsActive { get; set; }
        public bool IsMandatory { get; set; }
        public string Label { get; set; }
        public int Order { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string Value { get; set; }
    }
}
