using Microsoft.VisualStudio.TestTools.UnitTesting;
using WF_Fraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Fraction.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void FractionConstructorDefaultTest()
        {
           Fraction fractionTest = new Fraction();
           Assert.AreEqual("0/0",fractionTest.ToString().Replace(" ",""));
        }

        /// <summary>
        /// Instantiation avec 1 numérateur
        /// </summary>
        [TestMethod()]
        public void FractionConstructorNumeratorOnlyTest()
        {
            Fraction fractionTest = new Fraction(2);
            Assert.AreEqual("2/1", fractionTest.ToString().Replace(" ", ""));

        }

        [TestMethod()]
        public void FractionConstructorAllParametersTest()
        {
            Fraction fractionTest = new Fraction(3, 7);
            Assert.AreEqual("3/7", fractionTest.ToString().Replace(" ", ""));
        }

        [TestMethod()]
        public void FractionConstructorToReduceTest()
        {
            Fraction fractionTest = new Fraction(2, 4);
            Assert.AreEqual("1/2", fractionTest.ToString().Replace(" ", ""));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Fraction fractionTest = new Fraction(5, 8);
            Assert.AreEqual("5/8", fractionTest.ToString().Replace(" ", ""));
        }

        /// <summary>
        /// Test du résultat de la division de la fraction.
        /// </summary>
        [TestMethod()]
        public void ToDoubleTest()
        {
            var f = new Fraction(4, 8);
            Assert.AreEqual(0.5, f.ToDouble(), 0.0001);
        }

        [TestMethod()]
        public void AddTest()
        {
            var f = new Fraction(4, 8);
            var f2 = new Fraction(10, 8);
            var res = f.Add(f2);
            string resString = res.ToString();
            Assert.AreEqual("680/64", resString.Replace(" ", ""));
            
        }
        /// <summary>
        /// Test de la division par 0 via la méthode ToDouble
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ToDoubleTestDivZero()
        {
            Fraction fractionTest = new Fraction(3, 0);
            fractionTest.ToDouble();
        }
    }
}