    int[] numbers = new int[] { 10, 2, 32, 4, 11, 6, 7, 51, 15, 10 };
    // 1 вариант
    int count = 0;
    foreach (int number in numbers)
        if (number >= 10 && number <= 90)
            count++;
 
    Console.WriteLine (" от 10 до 90: " + count);
    // 2 вариант
    // Console.WriteLine ($" от 10 до 90: {numbers.Where (n => (n >= 10 && n <= 90)).Count()}");