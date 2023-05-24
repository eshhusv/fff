Random r = new();
int[] mas = new int[14];
for(int i =0; i < mas.Length; i++)
    mas[i] = r.Next(-9, 10);
for (int i = 0; i < mas.Length; i++)
    Console.Write(mas[i] + " ");

Console.WriteLine();

int sum = 0, index = 0;
while (mas[index] >= 0)
{
    sum += mas[index];
    index++;
};
Console.WriteLine(sum);