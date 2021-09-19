using System;
using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [CreateDTO(typeof(DidacticalModelReadDTO))]
    public class DidacticalModel : IIsDeleted
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
