using FlashCards.Models;

namespace FlashCards.Interfaces
{
    public interface ICategoryLoader
    {
        List<CategoryModel> Categories { get; set; }
        List<TopicModel> Topics { get; }

        void LoadCategories();
    }
}