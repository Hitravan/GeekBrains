Console.Write(" Введите число a ");
string inputA = Console.ReadLine();
int numberA = Convert.ToInt32(inputA);

Console.Write(" Введите число b ");
string inputB = Console.ReadLine();
int numberB = Convert.ToInt32(inputB);

int sqrtNumber = numberB * numberB;

if (sqrtNumber == numberA)
{
    Console.WriteLine(" Число " + inputA + " является корнем " + inputB);
}
else
{
    Console.WriteLine(" Число " + inputA + " не является корнем " + inputB);
}
