using System;
using System.Collections.Generic;
using System.Text;

namespace ClientWPF.Mocks
{
    class MockModule
    {
        public string Title { get; set; }
        private List<MockModuleTopic> topics;

        public MockModule(string title)
        {
            Title = title;
            topics = new List<MockModuleTopic>();
        }

        public MockModule()
        {
            topics = new List<MockModuleTopic>();
        }

        public void AddTopic(MockModuleTopic t)
        {
            topics.Add(t);
        }

        public List<MockModuleTopic> GetMockModuleTopics()
        {
            return topics;
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
