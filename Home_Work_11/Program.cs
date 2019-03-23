using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Home_Work_11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TWENTY = 20;
            const int TWO = 2;
            int AmountOfElements = 0;
            int maximumElement = 0;
            int positionSecondMaximumElement = 0;

            Random random = new Random();
            List<int> myList = new List<int>(TWENTY);


           
            WriteLine("Созданный лист: ");

            for (int i = 0; i < myList.Capacity; i++)
            {
                myList.Add(random.Next(0, TWENTY));
                Write($"{myList[i]},  ");
            }

            for (int i = 0; i < myList.Capacity; i++)
            {
                if (i % TWO == 0)
                {
                    AmountOfElements += myList[i];
                }
            }

            
            for (int i = 1; i < myList.Count; i++)
            {
                if (myList[i] > myList[maximumElement])
                {
                    maximumElement = i;
                }
            }

            
            for (int i = 1; i < myList.Count; i++)
            {
                if (i != maximumElement && myList[i] > myList[positionSecondMaximumElement] && myList[i] != myList[maximumElement])
                {
                    positionSecondMaximumElement = i;
                }
            }


            WriteLine($"\n\nВторое максимальное значение {myList[positionSecondMaximumElement]}, его позиция - {positionSecondMaximumElement}");
            WriteLine($"\nСумма чисел на четных позициях - {AmountOfElements}");
            ReadKey();
        }
    }
}
