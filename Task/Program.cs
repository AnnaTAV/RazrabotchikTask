// Написать программу, которая из имеющегося массива строк формирут массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами
// *Пример:*
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1) 
                Console.Write($"{array[i]}, ");
            else 
                Console.Write($"{array[i]}.");
        }
    Console.WriteLine();
}

int CheckLengthArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) count++;
        }
    return count;
}

string[] FindResArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
                {
                    result[result.Length - count] = array[i];
                    count--;
                }
        }
    return result;
}

string[] StringArray =  {"1234", "1567", "5", "computer science",":-*", "GB" };
int NumArray = CheckLengthArray(StringArray);
string[] resultArray =  FindResArray(StringArray, NumArray);

PrintArray(resultArray);