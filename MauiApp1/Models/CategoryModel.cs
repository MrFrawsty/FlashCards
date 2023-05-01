using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class CategoryModel
    {
        public string CategoryName { get; set; }
        public List<TopicModel> TopicModels { get; set; } = new List<TopicModel>();

        public CategoryModel()
        {
                
        }

        public CategoryModel(string name, List<TopicModel> topics)
        {
            CategoryName = name;
            TopicModels = topics;
        }

        public CategoryModel(string name)
        {
            CategoryName = name;
            
        }

        public void AddTopic(string topicName, List<FlashCardModel> flashcards)
        {  
            TopicModels.Add(new TopicModel(topicName, flashcards));
        }

       

    }
}
