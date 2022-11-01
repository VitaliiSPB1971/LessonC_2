Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 8 && (number == 6 || number == 7)){
      Console.WriteLine("да");
} else if(number < 8 && (number != 6 || number != 7)){
      Console.WriteLine("нет");
}else {
      Console.WriteLine("такой недели не существует");
}
