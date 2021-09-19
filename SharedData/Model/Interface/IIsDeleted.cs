using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model.Interface
{
    public abstract class IIsDeleted
    {
        public bool IsDeleted { get; set; }
    }
}
