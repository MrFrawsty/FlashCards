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
    }
}
