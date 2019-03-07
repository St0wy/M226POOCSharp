/**
 * WFExamenBlancMcdo
 * Fabian Huber
 * 07.03.219
 */
using System;
using System.Collections.Generic;

namespace WFExamenBlancMcdo
{
    public class MealDao
    {
        private const char SEP = ';';
        private static readonly string[] MAIN_COURSES = new string[]
        {
            "Big Mac;509",
            "Mc Chicken;445",
            "Mc Nuggets;170",
            "Big Tasty;246",
            "Royal Cheese;507"
        };
        private static readonly string[] SIDE_ORDERS = new string[] 
        {
            "French Fries;350",
            "Cowboy Potatoes;210",
            "Green Salad;50"
        };
        private static readonly string[] DRINKS = new string[] 
        {
            "Coca Cola;175",
            "Zero Coke;1",
            "Ice Tea;26",
            "Water;0"
        };

        public static Meal[] GetMainCourses()
        {
            List<Meal> lstMainCourses = new List<Meal>();
            for (int i = 0; i < MAIN_COURSES.Length; i++)
            {
                String[] sT = MAIN_COURSES[i].Split(SEP);
                string name = sT[0];
                int kCal = Convert.ToInt32(sT[1]);
                lstMainCourses.Add(new Meal(name, kCal));
            }

            return lstMainCourses.ToArray();
        }
        public static Meal[] GetSideOrders()
        {
            List<Meal> lstSideOrders = new List<Meal>();
            for (int i = 0; i < SIDE_ORDERS.Length; i++)
            {
                String[] sT = SIDE_ORDERS[i].Split(SEP);
                string name = sT[0];
                int kCal = Convert.ToInt32(sT[1]);
                lstSideOrders.Add(new Meal(name, kCal));
            }

            return lstSideOrders.ToArray();
        }
        public static Meal[] GetDrinks()
        {
            List<Meal> lstDrinks = new List<Meal>();
            for (int i = 0; i < DRINKS.Length; i++)
            {
                String[] sT = DRINKS[i].Split(SEP);
                string name = sT[0];
                int kCal = Convert.ToInt32(sT[1]);
                lstDrinks.Add(new Meal(name, kCal));
            }

            return lstDrinks.ToArray();
        }
    }
}
