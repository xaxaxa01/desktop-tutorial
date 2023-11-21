using System;

string str = "";
int lenght;
bool result;
int number;
do
{
    Console.WriteLine("введите челое положительное число: ");
    str = Convert.ToString(Console.ReadLine());
    lenght = str.Length;
    result = int.TryParse(str, out int num);
    number = Convert.ToInt32(str);
} while(lenght == 0 || result == false || number == 0);

for (int i = 1; i <= number; i++)
{
    Console.Write(i + " ");
}
for (int i = number - 1; i >= 1; i--)
{
    Console.Write(i + " ");
}
