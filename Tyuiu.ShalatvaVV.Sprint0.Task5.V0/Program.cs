using Tyuiu.ShalaevaVV.Sprint0.Task5.V0.Lib;
//Пример линейной структуры программы
// Вызов метода сложения Addiction
Console.WriteLine("A + B = " + DataService.Addition(1, 5));
//Вызов метода вычитания Subtraction
Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
//Вызом метода умножения Multiplication
Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

//Пример разветвляющейся структуры находится в библиотеке классов в методе Division
Console.WriteLine( "A/B = " + DataService.Division(9, 3));
Console.ReadKey();