void FillArray(ref string[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Console.ReadLine();
}
void ShrinkArray(ref string[] array)
{
    array = array.Where(val => val.Length <= 3).ToArray();
}
Console.Clear();
Console.Write("Введите количество строк: ");
int strings_count = int.Parse(Console.ReadLine());
string[] array = new string[strings_count];
Console.WriteLine("Введите строки: ");
FillArray(ref array);
ShrinkArray(ref array);
Console.WriteLine("Результат: ");
for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);