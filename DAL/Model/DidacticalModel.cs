using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(DidacticalModelReadDTO))]
    public class DidacticalModel : IIsDeleted
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
