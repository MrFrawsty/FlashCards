using CommunityToolkit.Mvvm.ComponentModel;
using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.ViewModels
{
    [QueryProperty(nameof(SelectedCategory), "SelectedCategory")]
    public partial class SelectedCategoryViewModel : ObservableObject
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
    }
}
