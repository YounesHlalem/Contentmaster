using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(RoleReadDTO))]
    public class Role : IIsDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
    }
}
