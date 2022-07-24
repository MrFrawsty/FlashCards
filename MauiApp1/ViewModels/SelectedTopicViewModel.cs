using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    [QueryProperty(nameof(SelectedTopic), "SelectedTopic")]
    public partial class SelectedTopicViewModel : ObservableObject
    {
        TopicModel selectedTopic;

      
        public TopicModel SelectedTopic
        {
            get => selectedTopic;
            set
            {
                selectedTopic = value;
                OnPropertyChanged();
            }
        }



        public string TopicName { get; set; }
        public List<FlashCardModel> FlashCards { get; set; }

        public SelectedTopicViewModel()
        {
            //OnPropertyChanged();
        }

        //public void ApplyQueryAttributes(IDictionary<string, object> query)
        //{
        //    SelectedTopic = query["SelectedTopic"] as TopicModel;
        //}



        //    public List<string> Test;

        //    {
        //        //flashCards = cardLoader.LoadFlashCards();
        //        cardLoader.LoadFlashCards("SingleResponsibiltyPrinciple.txt", "Single Responsibility Principle");
        //        cardLoader.LoadFlashCards("Protected.txt", "Protected Access Modifier");
        //        cardLoader.LoadFlashCards("InterfaceNotes.txt", "Interfaces");
        //        flashCards = cardLoader.GetFlashCards();
        //    }


    }
}
