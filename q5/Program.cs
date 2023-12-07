Console.WriteLine("Введите число");
int input = Convert.ToInt32(Console.ReadLine());
int mininput = -input;

while (input >= mininput)
{
    Console.Write(mininput + " ");

    mininput += 1;
}