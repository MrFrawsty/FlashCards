using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class TopicModel
    {
        public string TopicName { get; set; }

        public List<FlashCardModel> Flashcards { get; set; }

        public TopicModel(string topicName, List<FlashCardModel> flashCards)
        {
            TopicName = topicName;
            Flashcards = flashCards;
        }

    }
}
