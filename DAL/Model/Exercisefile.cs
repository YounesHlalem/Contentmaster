using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(ExercisefileReadDTO))]
    public class Exercisefile
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public bool ContainsCurrency { get; set; }
        public bool ContainsDate { get; set; }
        public bool ContainsTime { get; set; }
        public bool ContainsGeographical { get; set; }
        public bool ContainsNamesToTranslate { get; set; }

    }
}
