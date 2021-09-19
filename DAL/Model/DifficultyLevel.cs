using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(DifficultyLevelReadDTO))]
    public class DifficultyLevel : IIsDeleted
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
