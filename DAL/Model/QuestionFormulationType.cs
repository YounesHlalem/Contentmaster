using System;
using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(QuestionFormulationTypeReadDTO))]
    public class QuestionFormulationType
	{
        public int Id { get; set; }
        public string Name { get; set; }
    }
}