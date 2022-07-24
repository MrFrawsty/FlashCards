using FlashCards.Interfaces;
using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Services
{
    internal class TopicLoader : ITopicLoader
    {
        IFlashCardLoader flashCardLoader;
        public List<TopicModel> Topics { get; set; } = new List<TopicModel>();

        public void AddTopic(string fileName, string topicName)
        {
            Topics.Add(new TopicModel(topicName, flashCardLoader.CreateFlashCardsForTopic(fileName, topicName)));

        }

        public List<TopicModel> GetTopics()
        {
            return Topics;
        }

        public TopicLoader(IFlashCardLoader cardLoader)
        {
            flashCardLoader = cardLoader;
        }

    }
}
