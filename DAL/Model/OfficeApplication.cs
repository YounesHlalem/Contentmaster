using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(OfficeApplicationReadDTO))]
    public class OfficeApplication : IIsDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
