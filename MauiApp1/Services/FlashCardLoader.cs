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
    internal class FlashCardLoader : IFlashCardLoader
    {
        static readonly string directory = "FlashCards.TextFiles.";

        INoteSeparator noteSeparator;

        public FlashCardLoader(INoteSeparator separator)    
        {
            noteSeparator = separator;
        }

      //  List<FlashCardModel> flashCards = new List<FlashCardModel>();
        //public void AddFlashCard(string fileName, string title)
        //{
        //    var fullPath = $"{directory}{fileName}";
        //    var assembly = Assembly.GetExecutingAssembly();
        //    var text = string.Empty;
        //    using (Stream stream = assembly.GetManifestResourceStream(fullPath))
        //    using (StreamReader reader = new StreamReader(stream))
        //    {
        //        text = reader.ReadToEnd();
        //    }


        //    var results = noteSeparator.SeparateNotes(text);

        //    foreach(var res in results)
        //    {
        //        flashCards.Add(new FlashCardModel { Title = title, Note = res });
        //    };
        //    //var result = new FlashCardModel() { Title = title, BulletPoints = noteSeparator.SeparateNotes(text) };
        //    //flashCards.Add(result);

        //}

        public List<FlashCardModel> CreateFlashCardsForTopic(string fileName, string topicName)
        {
            var flashCards = new List<FlashCardModel>();
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
                flashCards.Add(new FlashCardModel { Title = topicName, Note = res });
            };

            return flashCards;

        }

        //public List<FlashCardModel> LoadFlashCards()
        //{
        //    var result = new List<FlashCardModel>()
        //    {
        //         {new FlashCardModel {Title = "Interfaces",
        //            BulletPoints = noteSeparator.SeparateNotes("TEST.") } },


        //       {new FlashCardModel {Title = "Abstract Classes", BulletPoints = noteSeparator.SeparateNotes(@"Think of it as a blend of a base class and an interface. Can’t be instantiated, can be inherited from.Abstract methods contain no logic.Can have full fledged methods with logic or abstract methods that must be implemented.Override keyword is used to implement abstract methods.Virtual keyword allows method to be declared and used as is, or be overridden.") } }
        //    };

        //    return result;

        //}

        //public List<FlashCardModel> GetFlashCards()
        //{
        //    return flashCards;
        //}
    }
}
