using Tyuiu.ShalaevaVV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ShalaevaVV.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            //пример циклической структуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            
            //пример циклической структуры находится в библиотеке классов в методе SubtractionArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));
            
            //пример циклической структуры находится в библиотеке классов в методе MiltiplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();

        }
    }
}