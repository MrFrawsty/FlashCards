using FlashCards.Models;

namespace FlashCards.Interfaces
{
    public interface ITopicLoader
    {
        List<TopicModel> Topics { get; set; }

        public void AddTopic(string fileName, string topicName);

        public List<TopicModel> GetTopics();
    }
}