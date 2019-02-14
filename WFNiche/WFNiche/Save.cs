/* 
* Project : WFNiche
* Author : Fabian Huber
* Description : Class to save things in xml files
* Version : 1.0
* Date : 08.11.2018
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WFNiche
{
    class Save<T>
    {
        //Properties
        XmlSerializer serializer;

        //Fields
        public XmlSerializer Serializer { get => serializer; set => serializer = value; }

        //Constructor
        public Save()
        {
            Serializer = new XmlSerializer(typeof(T));
        }

        //Methods
        public void Serialize(T item, string fileName)
        {
            
            StreamWriter file = new StreamWriter(fileName);
            Serializer.Serialize(file, item);
            file.Close();
        }

        public T Deserialize(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            T item = (T)serializer.Deserialize(file);
            file.Close();

            return item;
        }
    }
}
