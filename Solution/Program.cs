Console.Clear();

string[] SelectingRowsOfSize(string[] arr, int size)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= size) count++;        
    }

    string[] result = new string[count];
    for (int i = 0, j = 0 ; i < arr.Length; i++)
    {
        if(arr[i].Length <= size) result[j++] = arr[i];        
    }
    return result;
}

int sizeString = 3;
string[] array = new[] {"www", "http", "hello", "777", "Russia", "-", "23", "world", "Kazan", "O_o"};
Console.WriteLine($"Исходный массив: {string.Join(", ", array)}");

string[] newArray = SelectingRowsOfSize(array, sizeString);
Console.WriteLine($"Полученный массив, cостоящий из строк длинной (<= {sizeString}): {string.Join(", ", newArray)}");
