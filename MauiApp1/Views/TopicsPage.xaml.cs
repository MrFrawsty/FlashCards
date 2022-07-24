using FlashCards.Interfaces;
using FlashCards.Services;
using FlashCards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace FlashCards.Views
{
   
    public partial class TopicsPage : ContentPage
    {
        
        public TopicsPage()
        {
            InitializeComponent();
            BindingContext = ServiceHelper.GetService<TopicsViewModel>();
        }

     
    }
}