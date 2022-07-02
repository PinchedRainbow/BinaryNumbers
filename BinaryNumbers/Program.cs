int count = 0;

for (int i = 0;; i++) { 
    //check if the current number only contains 1s and 0s and no other digits
    if (!(Convert.ToString(i).Contains('2') || Convert.ToString(i).Contains("3") || Convert.ToString(i).Contains("4") || Convert.ToString(i).Contains("5") || Convert.ToString(i).Contains("6") || Convert.ToString(i).Contains("7") || Convert.ToString(i).Contains("8") || Convert.ToString(i).Contains("9"))) {
        Console.WriteLine("Current number is: " + i);
        Console.WriteLine("The binary number is: " + Convert.ToString(i, 2));
        Console.WriteLine();
        count++;
        if (count > 1000)
        {
            break;
        }
    }
}

