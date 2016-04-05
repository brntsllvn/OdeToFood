using System.Web.Mvc;
using NUnit.Framework;
using OdeToFood.Controllers;
using System.Collections.Generic;
using OdeToFood.Entities;
using OdeToFood.Models;

namespace OdeToFood.Tests.Controllers
{
    [TestFixture]
    public class IngredientControllerTests
    {
        [Test]
        public void IngredientIndexAssignsListOfIngredients()
        {
            //Arrange
            var _db = new OdeToFoodDb();

            _db.Ingredients.Add(new Ingredient() { Name = "Broccoli" });
            _db.Ingredients.Add(new Ingredient() { Name = "Carrot"   });
            _db.Ingredients.Add(new Ingredient() { Name = "Bagel"    });

            //Act
            var ingredientController = new IngredientController();
            var result = ingredientController.Index() as ViewResult;

            //Assert
            Assert.That(_db.Ingredients, Is.EqualTo(result.Model));
        }
    }
}