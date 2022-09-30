// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task 38");

Random rnd = new Random();

double[] arr = new double[10];

for(int i = 0; i < arr.Length; i++) arr[i] = Math.Round(rnd.NextDouble() * 1000, 4);

double dif = arr.Max() - arr.Min();

Console.WriteLine($"Max {arr.Max()} Min {arr.Min()} -> разность {dif}");
