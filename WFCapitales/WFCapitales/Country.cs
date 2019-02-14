using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCapitales
{
    class Country
    {
        //Fields
        string countryName;
        string capital;

        //Properties
        public string CountryName { get => countryName; set => countryName = value; }
        public string Capital { get => capital; set => capital = value; }

        //Constructors
        public Country() : this("no name", "no capital")
        {

        }

        public Country(string name, string capital)
        {
            CountryName = name;
            Capital = capital;
        }

        //Methods
    }
}
