using FlashCards.Interfaces;
using FlashCards.Models;
using FlashCards.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1;

namespace FlashCards.ViewModels
{
    public partial class TopicsViewModel : ObservableObject
    {
        ITopicLoader topicLoader;
     
     //   public  Command SelectTopicCommand { get; }
        public List<TopicModel> Topics { get; set; }

        public TopicsViewModel()
        {
            topicLoader = ServiceHelper.GetService<ITopicLoader>();
            
            LoadAllTopics();
 
         // SelectTopicCommand = new Command<TopicModel>(async (topicModel) => await SelectTopic(topicModel));
        }


        internal void LoadAllTopics()
        {
            topicLoader.AddTopic("SingleResponsibiltyPrinciple.txt", "Single Responsibility Principle");
            topicLoader.AddTopic("Protected.txt", "Protected Access Modifier");
            topicLoader.AddTopic("InterfaceNotes.txt", "Interfaces");
            topicLoader.AddTopic("SingleResponsibiltyPrinciple.txt", "Single Responsibility Principle");
            topicLoader.AddTopic("Protected.txt", "Protected Access Modifier");
            topicLoader.AddTopic("InterfaceNotes.txt", "Interfaces");
            Topics = topicLoader.GetTopics();
        }

        [RelayCommand]
        async Task SelectTopic(TopicModel selectedTopic)
        {

            await Shell.Current.GoToAsync($"///MainPage", new Dictionary<string, object>
            {
                ["SelectedTopic"] = selectedTopic
            });
        }

    }
}
