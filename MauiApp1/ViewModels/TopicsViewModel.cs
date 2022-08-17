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
    [QueryProperty(nameof(SelectedCategory), "SelectedCategory")]
    public partial class TopicsViewModel : ObservableObject
    {
        CategoryModel selectedCategory;
        public CategoryModel SelectedCategory
        {
            get => selectedCategory;
            set
            {
                selectedCategory = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        async Task SelectTopic(TopicModel selectedTopic)
        {
            await Shell.Current.GoToAsync($"///SelectedTopicPage", new Dictionary<string, object>
            {
                ["SelectedTopic"] = selectedTopic
            });
        }

    }
}
