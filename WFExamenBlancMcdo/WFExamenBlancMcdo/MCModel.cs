/**
 * WFExamenBlancMcdo
 * Fabian Huber
 * 07.03.219
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFExamenBlancMcdo
{
    public class MCModel
    {
        //Fields
        Meal[] mainCourses;
        Meal[] sideOrders;
        Meal[] drinks;
        Meal currentMainCourses;
        Meal currentSideOrder;
        Meal currentDrink;

        //Properties
        public Meal[] MainCourses { get => mainCourses; set => mainCourses = value; }
        public Meal[] SideOrders { get => sideOrders; set => sideOrders = value; }
        public Meal[] Drinks { get => drinks; set => drinks = value; }
        public Meal CurrentMainCourse { get => currentMainCourses; set => currentMainCourses = value; }
        public Meal CurrentSideOrder { get => currentSideOrder; set => currentSideOrder = value; }
        public Meal CurrentDrink { get => currentDrink; set => currentDrink = value; }

        //Constructors
        public MCModel()
        {
            MainCourses = MealDao.GetMainCourses();
            SideOrders = MealDao.GetSideOrders();
            Drinks = MealDao.GetDrinks();
            CurrentMainCourse = null;
            CurrentSideOrder = null;
            CurrentDrink = null;
        }

        //Methods
        /// <summary>
        /// Calculate the total ammount of calories from the current meals.
        /// </summary>
        /// <returns>Returns the total ammount of calories from the current meals.</returns>
        private int ComputeCalories()
        {
            int calories = 0;
            if (CurrentMainCourse != null)
            {
                calories += CurrentMainCourse.KCaloriesValue;
            }
            if (CurrentSideOrder != null)
            {
                calories += CurrentSideOrder.KCaloriesValue;
            }
            if (CurrentDrink != null)
            {
                calories += CurrentDrink.KCaloriesValue;
            }

            return calories;
        }

        /// <summary>
        /// Sets the good meal in the current meal variable and returns the total ammount of calories.
        /// </summary>
        /// <param name="mainCourseIndex">index of the main course meal.</param>
        /// <param name="sideOrderIndex">index of the side order meal.</param>
        /// <param name="drinkIndex">index of the drink meal.</param>
        /// <returns>Returns the total ammount of calories</returns>
        public int GetCalories(int mainCourseIndex, int sideOrderIndex, int drinkIndex)
        {
            if (mainCourseIndex > -1)
            {
                CurrentMainCourse = MainCourses[mainCourseIndex];
            }
            if (sideOrderIndex > -1)
            {
                CurrentSideOrder = SideOrders[sideOrderIndex];
            }
            if (drinkIndex > -1)
            {
                CurrentDrink = Drinks[drinkIndex];
            }
            int calories = ComputeCalories();

            return calories;
        }

        public override string ToString()
        {
            string mainCourseString = "";
            string sideOrderString = "";
            string drinkString = "";
            if (CurrentMainCourse != null)
            {
                mainCourseString = CurrentMainCourse.ToString();
            }
            if (CurrentSideOrder != null)
            {
                sideOrderString = currentSideOrder.ToString();
            }
            if (CurrentDrink != null)
            {
                drinkString = CurrentDrink.ToString();
            }
            string toString = $"{mainCourseString}\n{sideOrderString}\n{drinkString}";

            return toString;
        }
    }
}
