using FlashCards.Models;

namespace FlashCards.Interfaces
{
    internal interface IFlashCardLoader
    {
        List<FlashCardModel> CreateFlashCardsForTopic(string fileName, string title);
    }

}