using FlashCards.Interfaces;
using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Services
{
    //Look at loading from files
    public class FlashCardLoader : IFlashCardLoader
    {
        static readonly string directory = "FlashCards.TextFiles.";

        INoteSeparator noteSeparator;

        public FlashCardLoader(INoteSeparator separator)    
        {
            noteSeparator = separator;
        }

        public List<FlashCardModel> CreateFlashCardsForTopic(string fileName, string cardHeader, string topicName)
        {
            var flashCards = new List<FlashCardModel>();
            var fullPath = $"{directory}{fileName}";
            var assembly = Assembly.GetExecutingAssembly();
            var text = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(fullPath))
                //add guard clause
            using (StreamReader reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            var results = noteSeparator.SeparateNotes(text);

            //TODO create constructor in flashcard class 
            foreach (var result in results)
            {
                flashCards.Add(new FlashCardModel {CardHeader = cardHeader, Topic = topicName, Note = result });
            };

            return flashCards;

        }

        public void AddMoreFlashCards(List<FlashCardModel> flashCards, string fileName, string topicName, string cardHeader)
        {  
            var fullPath = $"{directory}{fileName}";
            var assembly = Assembly.GetExecutingAssembly();
            var text = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(fullPath))
            using (StreamReader reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            var results = noteSeparator.SeparateNotes(text);

            foreach (var res in results)
            {
                flashCards.Add(new FlashCardModel { Topic = topicName, CardHeader = cardHeader, Note = res });
            };

        }

    }
}
