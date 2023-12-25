using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NasyrovaVR.Sprint6.Project.V5.Lib;

namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double[] valuesSumTest = { 5, 10, 15, 20 };

            double sum = ds.CalculateSum(valuesSumTest);
            double wait = 50;
            double res = ds.CalculateSum(valuesSumTest);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculateAverage ()
        {
            DataService ds = new DataService();
           
            double[] values = { 10, 20, 30 };
            int visibleRowCount = 3;

            double res = ds.CalculateAverage(values, visibleRowCount);
            double wait = 20; 

            Assert.AreEqual(wait, res); 
        }

        [TestMethod]
        public void CheckMinimumValueCalculation()
        {
            DataService ds = new DataService();
            double[] valuesMinTest = { 3.5, 2.0, 5.1, 1.8, 4.9 };
            double wait = 1.8;

            double res = ds.FindMinimumValue(valuesMinTest);

            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void CheckMaximumValueCalculation()
        {
            DataService ds = new DataService();
            double[] valuesMaxTest = { 3.5, 2.0, 5.1, 1.8, 4.9 };
            double wait = 5.1;

            double res = ds.FindMaximumValue(valuesMaxTest);

            Assert.AreEqual(wait, res);
        }
    }
}
