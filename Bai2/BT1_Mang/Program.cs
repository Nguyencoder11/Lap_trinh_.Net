// See https://aka.ms/new-console-template for more information

Console.Write("Nhap kich thuoc cua mang: ");
int size = int.Parse(Console.ReadLine());

int[] arr = new int[size];
Console.WriteLine("Nhap gia tri cac phan tu cua mang:");
for (int i = 0; i < size; i++)
{
    Console.Write($"Phan tu thu {i+1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

int max = arr[0], min = arr[0];
int sum = 0;
for (int i = 0;i < size; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
    sum += arr[i];
}

Console.WriteLine("So lon nhat trong mang: " + max);
Console.WriteLine("So nho nhat trong mang: " + min);
Console.WriteLine("Tong cac phan tu trong mang: " + sum);

