using ClientWPF.DataBinding.Elements;
using DTO.Read;
using System.Collections.Generic;

namespace ClientWPF.DataBinding.Container
{
    public class ItemsContainer
    {
        public FilterItem FilterItem { get; set; }
        public List<CourseReadDTO> courses { get; set; } = new List<CourseReadDTO>();
        public List<QuizReadDTO> quizzes { get; set; } = new List<QuizReadDTO>();

        public List<IconItem> IconList { get; set; } = new List<IconItem>();
        public ItemsContainer()
        {
            FilterItem = new FilterItem();
        }
        
    }
}
