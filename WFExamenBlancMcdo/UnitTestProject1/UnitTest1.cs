/**
 * WFExamenBlancMcdo
 * Fabian Huber
 * 07.03.219
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WFExamenBlancMcdo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Meal meal;
        MCModel model;
        Random rnd;

        [TestMethod]
        public void DefaultCaloriesForMealAreEmpty()
        {
            meal = new Meal();

            Assert.AreEqual(meal.KCaloriesValue, 0);
            Assert.AreEqual(meal.Name, "");
        }

        [TestMethod]
        public void ModelCurrentVarAreNull()
        {
            model = new MCModel();
            
            Assert.AreEqual(model.CurrentMainCourse, null);
            Assert.AreEqual(model.CurrentSideOrder, null);
            Assert.AreEqual(model.CurrentDrink, null);
        }

        [TestMethod]
        public void GetCaloriesReturnsTheGoodAmountOfCallories()
        {
            model = new MCModel();
            rnd = new Random();

            int idMainCourse = rnd.Next(model.MainCourses.Length);
            int idSideOrder = rnd.Next(model.SideOrders.Length);
            int idDrink = rnd.Next(model.Drinks.Length);

            int calMainCourse = model.MainCourses[idMainCourse].KCaloriesValue;
            int calSideOrder = model.SideOrders[idSideOrder].KCaloriesValue;
            int calDrink = model.Drinks[idDrink].KCaloriesValue;
            int totalCal = calDrink + calMainCourse + calSideOrder;

            Assert.AreEqual(model.GetCalories(idMainCourse, idSideOrder, idDrink), totalCal);
        }
    }
}
