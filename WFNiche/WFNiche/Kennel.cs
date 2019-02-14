/* 
* Project : WFNiche
* Author : Fabian Huber
* Description : Kennel that can contain a dog
* Version : 1.0
* Date : 08.11.2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFNiche
{
    public class Kennel
    {
        //Fields
        Dog d;

        //Properties
        internal Dog D { get => d; private set => d = value; }

        //Constructors
        public Kennel()
        {

        }

        public Kennel(Dog d)
        {
            D = d;
        }

        //Methods
        public bool In(Dog d)
        {
            if (IsOccupied())
            {
                return false;
            }
            else
            {
                D = d;
                return true;
            }
        }

        public void Out()
        {
            d = null;
        }

        public bool IsOccupied()
        {
            return D != null;
        }

        public string NameOfDogInKennel()
        {
            if(D == null)
            {
                return "";
            }
            else
            {
                return D.Name;
            }
        }
    }
}
