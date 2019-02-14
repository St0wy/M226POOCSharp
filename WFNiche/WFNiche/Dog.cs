/* 
* Project : WFNiche
* Author : Fabian Huber
* Description : Dog with a size and a name that can bark
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
    [Serializable]
    public class Dog
    {
        //Constants
        private const string START_BARK = "W";
        private const string MIDDLE_BARK = "o";
        private const string END_BARK = "uf!";
        private const string DEFAULT_DOG_NAME = "default";
        private const int DEFAULT_DOG_SIZE = 0;
        private const int SIZE_REDUCTOR = 10;

        //Fields
        string name;
        int size;

        //Properties
        public string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }

        //Constructors
        public Dog() : this(DEFAULT_DOG_NAME, DEFAULT_DOG_SIZE)
        {

        }

        public Dog(string name, int size)
        {
            Name = name;
            Size = size;
        }

        //Methods
        public string Bark()
        {
            int numberOfO = Size / SIZE_REDUCTOR;
            string bark = START_BARK;
            for (int i = 0; i < numberOfO; i++)
            {
                bark += MIDDLE_BARK;
            }
            bark += END_BARK;

            return bark;
        }
    }
}
