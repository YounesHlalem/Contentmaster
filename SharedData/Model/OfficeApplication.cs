using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(OfficeApplicationReadDTO))]
    public class OfficeApplication : IIsDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
