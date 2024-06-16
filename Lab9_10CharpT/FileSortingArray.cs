using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class FileSortingArray
    {
        public void SortNumbers(string filePath)
        {
            ArrayList positiveNumbers = new ArrayList();
            ArrayList negativeNumbers = new ArrayList();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    int number = int.Parse(reader.ReadLine());

                    if (number >= 0)
                        positiveNumbers.Add(number);
                    else
                        negativeNumbers.Add(number);
                }
            }

            Console.WriteLine("Позитивні числа:");
            PrintNumbers(positiveNumbers);

            Console.WriteLine("\nНегативні числа:");
            PrintNumbers(negativeNumbers);
        }

        private void PrintNumbers(ArrayList numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void Run()
        {
            string filePath = "inputArray.txt";
            SortNumbers(filePath);
        }
    }
}
