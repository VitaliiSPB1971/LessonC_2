for(int i = 0; i <= 100; i++){
        if (i % 100 == 0 || i % 100 == 10 || i % 100 == 10 || i % 100 == 11 || i % 100 == 12 || i % 100 == 13 || i % 100 == 14) {
            Console.WriteLine($"{i} программистов"); 
        }
        else if(i % 10 == 2 || i % 10 == 3 || i % 10 == 4){
            Console.WriteLine($"{i} программиста");
        } else if(i % 10 == 1){
            Console.WriteLine($"{i} программист");
        } else if(i % 10 == 0 || i % 10 == 5 || i % 10 == 6 || i % 10 == 7 || i % 10 == 8 || i % 10 == 9) {
            Console.WriteLine($"{i} программистов");
        }
}
