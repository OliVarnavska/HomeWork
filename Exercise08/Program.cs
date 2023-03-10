Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int N = 2;

if(number > 1)
{
    while(N <= number)
    {
        Console.Write(N + " ");
        N = N + 2;
    }
}