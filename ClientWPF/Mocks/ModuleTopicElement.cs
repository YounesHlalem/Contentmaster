using System;
using System.Collections.Generic;
using System.Text;

namespace ClientWPF.Mocks
{
    class ModuleTopicElement
    {
        public string Title { get; set; }

        public ModuleTopicElement()
        {

        }

        public ModuleTopicElement(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
