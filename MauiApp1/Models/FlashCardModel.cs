using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class FlashCardModel
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string CardHeader { get; set; }
    }
}
