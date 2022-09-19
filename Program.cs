

// Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.


string[] createArray(string[]newarray)
{
    
       string[] RandomArray = new string[newarray.Length];
       int N = newarray.Length;
       int c = 0;
    for (int i = 0; i < N; i++)
    {
        if (newarray[i].Length < 4)
             {
   RandomArray[c] = newarray[i];
             }    
    }
    return RandomArray;

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
      
        Console.WriteLine(array[i]);
    }
    
}

string [] arr  = {"1234", "1567", "-2", "computer science"};

PrintArray(createArray(arr));