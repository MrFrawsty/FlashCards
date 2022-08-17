using FlashCards.Models;

namespace FlashCards.Interfaces
{
    public interface IFlashCardLoader
    {
        List<FlashCardModel> CreateFlashCardsForTopic(string fileName, string cardHeader, string topicName);

        public void AddMoreFlashCards(List<FlashCardModel> flashCards, string fileName, string topicName, string cardHeader);
    }

}