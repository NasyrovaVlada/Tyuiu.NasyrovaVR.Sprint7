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
            int[] valuesSumTest = { 5, 10, 15, 20 };

            int sum = ds.CalculateSum(valuesSumTest);
            int wait = 50;
            int res = ds.CalculateSum(valuesSumTest);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckCalculateAverage ()
        {
            DataService ds = new DataService();
            int[] valuesAverageTest = { 5, 10, 15, 20 };
            double wait = 12.5; 

            double res = ds.CalculateAverage(valuesAverageTest);

            Assert.AreEqual(wait, res); 
        }
    }
}
