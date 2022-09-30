// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task 34");

 bool isEven(Int64 val)
 {
    if(val%2 == 0) return true;
    return false;
 }

Random rnd = new Random();

Int64[] arr = new Int64[10];

for(int i = 0; i < arr.Length; i++) arr[i] = rnd.NextInt64(100, 1000);

int count = 0;

for(int i = 0; i < arr.Length; i++)
{
  if (isEven(arr[i])) count++;
}

Console.WriteLine($"Количество четных чисел {count}");