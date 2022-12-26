// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for(int i=0; i<n; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива: ");
    string element = Convert.ToString(Console.ReadLine());
    array[i] = element;
}    
Console.WriteLine("Исходный массив:");
for(int i=0; i<n; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();    
string[] newarray = new string[n];
int count = 0;
for (int i = 0; i<n; i++)
{
    if(array[i].Length <= 3)
    {
        newarray[count] = array[i];
        count++;
    }  
}
Console.WriteLine("Новый массив:");
for(int i=0; i<n; i++)
    Console.Write($"{newarray[i]} "); 

