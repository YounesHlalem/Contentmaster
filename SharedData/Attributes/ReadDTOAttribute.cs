using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.Attributes
{
    public class ReadDTOAttribute : Attribute
    {
        public Type Target { get; set; }

        public ReadDTOAttribute(Type target)
        {
            Target = target;
        }

        public static ReadDTOAttribute GetAttribute(Type t)
        {
            // Get instance of the attribute.
            ReadDTOAttribute MyAttribute = (ReadDTOAttribute)Attribute.GetCustomAttribute(t, typeof(ReadDTOAttribute));
            if (MyAttribute == null) return null;
            return MyAttribute;
        }
    }
}
