
int needsize = 3;
int size = 10;

string[] array1 = new string[size];
Console.WriteLine($"Введите элементы массива {size} раз");
FillArray(array1);
Console.Clear();
PrintArray(array1);
Console.WriteLine();
Console.WriteLine();
if (GetSizeArray2(array1) == 0) 
{ 
    Console.WriteLine("искомых элементов нет");
}
else
{
    string[] array2 = CarryElement(array1);
    PrintArray(array2);
}

void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine() ?? "";

    }
}

void PrintArray(string[] arr)
{
    int arrLenght = arr.Length;
    Console.Write("[ ");
    for (int i = 0; i < arrLenght; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

int GetSizeArray2(string[] arr)
{
    int arr2size = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= needsize)
        {
            arr2size++;
        }
    }
    return arr2size;
}

string[] CarryElement(string[] arr)
{
    string[] array2 = new string[GetSizeArray2(array1)];
    for (int i = 0, j = 0; i < size; i++)
    {

        if (arr[i].Length <= needsize)
        {
            array2[j] = arr[i];
            j++;
        }
    }    
    return array2;
}