using System;

namespace DAL.model.Attributes
{
    public class CreateDTOAttribute : Attribute
    {
        public Type Target { get; set; }

        public CreateDTOAttribute(Type target)
        {
            Target = target;
        }

        public static CreateDTOAttribute GetAttribute(Type t)
        {
            // Get instance of the attribute.
            CreateDTOAttribute MyAttribute = (CreateDTOAttribute)Attribute.GetCustomAttribute(t, typeof(CreateDTOAttribute));
            if (MyAttribute == null) return null;
            return MyAttribute;
        }
    }
}
