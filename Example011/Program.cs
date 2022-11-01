Console.WriteLine("Введите число");
    int x = Convert.ToInt32(Console.ReadLine());
    int num = x;
    int m = 1;
    int result_count = 0;
    while(num > 0)
    {
        num = num / 10;
        result_count++;
    }
    while (result_count > 2) {
         m *= 10;
         result_count--;
    }
    int result_number = (x % m) + (x / (m * 10)) * m;
    Console.WriteLine(result_number);
