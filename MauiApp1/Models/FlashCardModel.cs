using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class FlashCardModel
    {
        public string Topic { get; set; }

        public string CardHeader { get; set; }

        public string Note { get; set; }

        public FlashCardModel(string topic, string title, string note)
        {
            Topic = topic;
            CardHeader = title;
            Note = note;
        }

        public FlashCardModel()
        {

        }
    }
}
