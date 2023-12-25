using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Tyuiu.NasyrovaVR.Sprint6.Project.V5.Lib
{
    public class DataService
    {
        public string[,] LoadFromDataFile(string path)
        {
            string[] str = File.ReadAllLines(path);

            //определение количества столбцов и строк
            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }

        public double CalculateSum(double[] valueSum)
        {
            double sum = 0;
            
           
            for (int i = 0; i < valueSum.Length; i++)
            {
               sum += valueSum[i];
            }
           
            return Math.Round(sum, 2);
        }

        public double CalculateAverage(double[] values, int visibleRowCount)
        {
            if (visibleRowCount > 0)
            {
                double average = values.Sum() / visibleRowCount;
                return Math.Round(average, 2);
            }
            return 0;
        }


        public double FindMinimumValue(double[] values)
        {
            double minimum = values[0]; 

            for (int i = 1; i < values.Length; i++) // начиная с второго элемента, сравнивает с текущим мин значением
            {
                if (values[i] < minimum)
                {
                    minimum = values[i]; 
                }
            }

            return minimum; 
        }

        public double FindMaximumValue(double[] values)
        {
            double maximum = values[0];

            for (int i = 1; i < values.Length; i++) 
            {
                if (values[i] > maximum)
                {
                    maximum = values[i]; 
                }
            }

            return maximum; 
        }


    }
}
