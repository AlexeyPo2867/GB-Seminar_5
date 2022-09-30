Console.WriteLine("Task 36");

 

Random rnd = new Random();

int[] arr = new int[10];

for(int i = 0; i < arr.Length; i++) arr[i] = rnd.Next();

double sum = 0;

for(int i = 1; i < arr.Length; i += 2) sum += arr[i];

Console.WriteLine($"Сумма элементов: {sum}");

