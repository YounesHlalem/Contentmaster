using System;
using System.Collections.Generic;
using System.Text;

namespace ClientWPF.Mocks
{
    class MockModuleTopic
    {
        public string Title { get; set; }
        private List<ModuleTopicElement> TopicElements { get; set; }

        public MockModuleTopic(string title)
        {
            Title = title;
            TopicElements = new List<ModuleTopicElement>();
        }

        public MockModuleTopic()
        {
            TopicElements = new List<ModuleTopicElement>();
        }

        public override string ToString()
        {
            return Title;
        }

        public void AddTopicElement(ModuleTopicElement mte)
        {
            if (mte != null)
            {
                TopicElements.Add(mte);

            }
        }

        public List<ModuleTopicElement> GetElementList()
        {
            return TopicElements;
            
        }
    }
}
