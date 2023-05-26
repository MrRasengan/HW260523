// // Задача 43: Напишите программу, которая найдёт точку пересечения двух
//  прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double coordB1 = Prompt("Введите координату ");
double coordK1 = Prompt("Введите координату ");
double coordB2 = Prompt("Введите координату ");
double coordK2 = Prompt("Введите координату ");


double Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToInt32(value);
    return result;
}

double FindCoords(double x)
{
    double coordX = (coordB1 - coordB2) / (coordK1 - coordK2);
    double coordY = coordK1 * coordX + coordB1;
    return coordX;
}

bool ValidateCoords(double x, double y)
{
    if (coordK1 == coordK2)
    {
        if (coordB1 == coordB2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые паралельны");
            return false;
        }
    }
    return true;
}


double coordX = FindCoords((coordB1 - coordB2) / (coordK1 - coordK2));
double coordY = FindCoords(coordK1 * coordX + coordB1);
if (ValidateCoords(coordX, coordY))
{
    Console.WriteLine($"Точка пересечения двух прямых: {coordX} {coordY}");
}