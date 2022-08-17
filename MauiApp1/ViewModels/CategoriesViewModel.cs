using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FlashCards.Interfaces;
using FlashCards.Models;
using FlashCards.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.ViewModels
{
    public partial class CategoriesViewModel : ObservableObject
    {
        ICategoryLoader categoryLoader;

        public List<CategoryModel> Categories { get; set; }

        public CategoriesViewModel()
        {
           categoryLoader = ServiceHelper.GetService<ICategoryLoader>();

            Categories = categoryLoader.Categories;
        }

        [RelayCommand]
        async Task SelectCategory(CategoryModel selectedCategory)
        {

            await Shell.Current.GoToAsync($"///SelectedCategoryPage", new Dictionary<string, object>
            {
                ["SelectedCategory"] = selectedCategory
            });
        }

    }
}
