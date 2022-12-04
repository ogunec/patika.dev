using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string AssignedPerson { get; set; }
        public CardDimensions Dimension { get; set; }
        public string Line { get; set; }
    }
}
