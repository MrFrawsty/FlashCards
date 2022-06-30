using FlashCards.Models;
using FlashCards.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.ViewModels
{
    //Mono debugger soft disconnect error happens when there's an error for any reason.
    public class MainViewModel
    {
        private FlashCardLoader cardLoader = new FlashCardLoader(); 
        public List<FlashCardModel> flashCards { get; set; }
        public List<string> Test;
        public MainViewModel()
        {
            //flashCards = cardLoader.LoadFlashCards();
            cardLoader.LoadFlashCards("SingleResponsibiltyPrinciple.txt", "Single Responsibility Principle");
            cardLoader.LoadFlashCards("Protected.txt", "Protected Access Modifier");
            cardLoader.LoadFlashCards("InterfaceNotes.txt", "Interfaces");
            flashCards = cardLoader.GetFlashCards();
        }

       
    }
}
