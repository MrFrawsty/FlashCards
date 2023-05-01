using FlashCards.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Data
{
    public class FlashCardDatabase
    {
        SQLiteAsyncConnection Database;

        public FlashCardDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTablesAsync<CategoryModel, TopicModel, FlashCardModel>();
            
        }

        
    }
}
