using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class SubtopicModel
    {
        public string SubtopicName { get; set; }
        public List<FlashCardModel> SubtopicFlashCards { get; set; }
        public SubtopicModel(string subtopicName, List<FlashCardModel> flashCards)      
        {
            SubtopicName = subtopicName;
            SubtopicFlashCards = flashCards;
            
        }

     

    }
}
