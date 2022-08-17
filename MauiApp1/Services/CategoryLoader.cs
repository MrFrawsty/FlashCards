
using FlashCards.Interfaces;
using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Services
{
    public class CategoryLoader : ICategoryLoader
    {
        IFlashCardLoader cardLoader;

        public List<CategoryModel> Categories { get; set; } = new List<CategoryModel>();

        public List<TopicModel> Topics { get; }



        public void LoadCategories()
        {
            //maybe add seperate method for adding topics and build through constructor
            //then add to property

            var advancedTopics = new CategoryModel("Advanced Topics");
        
            advancedTopics.AddTopic("Interfaces", cardLoader.CreateFlashCardsForTopic("InterfaceNotes.txt", "Interfaces", "Interfaces"));

            advancedTopics.AddTopic("Access Modifiers", cardLoader.CreateFlashCardsForTopic("Protected.txt","Protected","Access Modifiers"));
            Categories.Add(advancedTopics);

            AddCardsToTopic(advancedTopics.CategoryName,"Access Modifiers", "PrivateProtected.txt", "Private Protected");

            advancedTopics.AddTopic("SOLID", cardLoader.CreateFlashCardsForTopic("SingleResponsibilityPrinciple.txt", "Single Responsibility Principle","SOLID"));
            AddCardsToTopic(advancedTopics.CategoryName, "SOLID", "OpenClosedPrinciple.txt", "Open Closed Principle");
            AddCardsToTopic(advancedTopics.CategoryName, "SOLID", "LiskovSubstitutionPrinciple.txt", "Liskov SubstitutionPrinceiple");
            AddCardsToTopic(advancedTopics.CategoryName, "SOLID", "InterfaceSegregationPrinciple.txt", "Interface Segregation Principle");
            AddCardsToTopic(advancedTopics.CategoryName, "SOLID", "DependencyInversionPrinciple.txt", "Dependency Inversion Principle");

            advancedTopics.AddTopic("Extension Methods", cardLoader.CreateFlashCardsForTopic("ExtensionMethods.txt", "Extension Methods", "Extension Methods"));

            var uiDesign = new CategoryModel($"UI/Design");
            Categories.Add(uiDesign);
            uiDesign.AddTopic("Design Fundamentals", cardLoader.CreateFlashCardsForTopic("Alignment.txt", "Alignment", "Design Fundamentals"));
            AddCardsToTopic(uiDesign.CategoryName, "Design Fundamentals", "Contrast.txt", "Contrast");
            AddCardsToTopic(uiDesign.CategoryName, "Design Fundamentals", "Whitespace.txt", "Whitespace");

            var cSharpVersions = new CategoryModel("C# Versions");
            Categories.Add(cSharpVersions);
            cSharpVersions.AddTopic("C# Version 8.0", cardLoader.CreateFlashCardsForTopic("ReadonlyMembers.txt", "Readonly Members", "C# Version 8.0"));
            AddCardsToTopic(cSharpVersions.CategoryName, "C# Version 8.0", "DefaultInterfaceMethodImplementations.txt", "Default Interface Method Implementations");
            AddCardsToTopic(cSharpVersions.CategoryName, "C# Version 8.0", "SwitchExpressions.txt", "Switch Expressions");
            AddCardsToTopic(cSharpVersions.CategoryName, "C# Version 8.0", "UsingDeclarations.txt", "Using Declarations");
            AddCardsToTopic(cSharpVersions.CategoryName, "C# Version 8.0", "IndicesAndRanges.txt", "Indices And Ranges");






        }

        public void AddCardsToTopic(string categoryName, string topicName, string fileName, string cardHeader)
        {
            //var selectedTopic = Topics.Find(x => x.TopicName == topicName);
            var targetCategory = Categories.Find(x => x.CategoryName == categoryName);
            if (targetCategory != null)
            {
                var targetTopic = targetCategory.TopicModels.Find(x => x.TopicName == topicName);

                if(targetTopic != null)
                {
                    cardLoader.AddMoreFlashCards(targetTopic.FlashCards, fileName, topicName, cardHeader);
                }
            }
                    
          
        }

        public CategoryLoader(IFlashCardLoader flashCardLoader)
        {
            cardLoader = flashCardLoader;
            LoadCategories();
        }
    }
}
