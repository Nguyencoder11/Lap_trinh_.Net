// See https://aka.ms/new-console-template for more information

Console.Write("Nhap vao chuoi thu 1: ");
string input1 = Console.ReadLine();
Console.WriteLine("Cac ky tu trong chuoi:");
foreach(char c in input1)
{
    Console.WriteLine(c);
}

Console.Write("Nhap vao chuoi thu 2: ");
string input2 = Console.ReadLine();
string[] words = input2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine("Cac tu trong chuoi:");
foreach(string word in words)
{
    Console.WriteLine(word);
}


Console.Write("Nhap vao chuoi thu 3: ");
string input3 = Console.ReadLine();
Dictionary<char, int> ketqua = new Dictionary<char, int>();
foreach(char kytu in input3)
{
    if(ketqua.ContainsKey(kytu)) ketqua[kytu]++;
    else ketqua[kytu] = 1;
}

foreach (KeyValuePair<char, int> kv in ketqua)
{
    Console.WriteLine($"Ky tu '{kv.Key}' xuat hien {kv.Value} lan trong chuoi");
}