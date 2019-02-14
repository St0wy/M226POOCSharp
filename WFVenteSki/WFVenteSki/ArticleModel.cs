using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFVenteSki
{
    class ArticleModel : Model<Article>
    {
        //Constructors
        public ArticleModel(List<Article> lst) : base(lst)
        {

        }

        /// <summary>
        /// Sort the Articles in alphabetical order
        /// </summary>
        public void Sort()
        {
            List<Article> sortingList = new List<Article>();
            for (int i = 0; i < GetSize(); i++)
            {
                sortingList.Add(GetItem(i));
            }

            sortingList.Sort((Article x, Article y) =>
            {
                return x.GetDesignation().CompareTo(y.GetDesignation());
            });

            DelAll();

            foreach (Article a in sortingList)
            {
                Add(a);
            }
        }
    }
}
