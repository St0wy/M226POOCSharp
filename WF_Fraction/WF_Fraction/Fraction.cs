using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Fraction
{
    public class Fraction
    {
        //Champs
        private int _numerator = 0;
        private int _denominator = 0;

        //Propriétés
        private int Numerator { get => _numerator; set => _numerator = value; }
        private int Denominator { get => _denominator; set => _denominator = value; }
        //Méthodes
        /// <summary>
        /// Ctor par défaut
        /// </summary>
        public Fraction()
        {
            this.Numerator = 0;
            this.Denominator = 0;
        }
        /// <summary>
        /// Ctor avec numérateur uniquement
        /// </summary>
        /// <param name="pNum">numérateur</param>
        public Fraction(int pNum)
        {
            this.Numerator = pNum;
            this.Denominator = 1;
        }
        /// <summary>
        /// Ctor avec numérateur/dénominatuer
        /// </summary>
        /// <param name="pNum">numérateur</param>
        /// <param name="pDen">dénominatuer</param>
        public Fraction(int pNum, int pDen)
        {
            this.Numerator = pNum;
            this.Denominator = pDen;
        }
        /// <summary>
        /// Retourne un string représentant la fraction
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }
        /// <summary>
        /// Retourne valeur double de la fraction
        /// </summary>
        /// <returns></returns>
        public double ToDouble()
        {
            if (Denominator == 0)
            {
                throw new InvalidOperationException();
            }
            return (double)Numerator / Denominator;
        }
        /// <summary>
        /// Additione une fraction à celle-ci
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public Fraction Add(Fraction f)
        {
            Denominator *= f.Denominator;
            Numerator *= f.Numerator;
            f.Numerator *= Denominator;
            Numerator += f.Numerator;
            return this;
        }
        /// <summary>
        /// Simplifie la fraction
        /// </summary>
        private void Reduce()
        {

            throw new NotImplementedException();
        }
        /// <summary>
        /// Calcule le plus grand diviseur commun
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int ComputeGcd(int a, int b)
        {

        }
    }
}
