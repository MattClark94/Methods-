int number; 


String convert(int number)
{
    string[] numbers = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine"}; 

    int hundreds = number /100; 
    number = number % 100 ; 
    int tens = number /10; 
    number = number % 10; 
    int 

    return numbers[hundreds -1] + " " + numbers[tens -1] +" "; 
}

Console.WriteLine("please enter a number bewteen -999 & 999"); 
number = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine(" Number is " + convert(number)); 

Console.ReadKey(); 








