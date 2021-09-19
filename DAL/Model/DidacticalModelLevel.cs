using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(DidacticalModelLevelReadDTO))]
    public class DidacticalModelLevel
	{
        public int Id { get; set; }
        public int DidacticalModelId { get; set; }
        public virtual DidacticalModel DidacticalModel { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
    }
}