void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите число, определяющее количество строк в массиве");
int M = int.Parse(Console.ReadLine());
string[] mass = new string[M];
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine("Введите строку в массив:");
    mass[i] = (Console.ReadLine());
}
Print(mass);
var mass2 = mass.Where(x=>x.Length <= 3).ToArray();
Print(mass2);
