Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "третьей цифры нет" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
