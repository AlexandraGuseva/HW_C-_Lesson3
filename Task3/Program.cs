// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

// Input
Console.Write("Please, input a number: ");
int cube = Convert.ToInt32(Console.ReadLine());

// Methods
void Cube(int[] cube)
{
    int counter = 0;
    while (counter < cube.Length)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintCubeArry(int[] coll)
{
    int index = 1;
    while (index < coll.Length)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}

// Body

int[] arry = new int[cube+1];
Cube(arry);
PrintCubeArry(arry);