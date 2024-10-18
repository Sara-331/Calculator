using System;
public class Calculator{
 public static void Main(){

Console.Write("Enter the first number: ");
double first = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double second = Convert.ToDouble(Console.ReadLine());

Console.Write("Choose an operation ( + , - , * , / ) ");
string operation = Console.ReadLine();

double Result = 0;     // to save result start from 0
if (operation == "+"){

    Result = first + second;
}
else if (operation == "-"){

    Result = first - second;
} 
else if (operation == "*"){

    Result = first * second;
}
else if (operation == "/") {  

    Result = first / second;
}
else {
    Console.WriteLine("Error Choose the correct operation!"); // if the user add wrong operation will show this message
    return; // stop 
}
Console.WriteLine($"Result: {first} {operation} {second} = {Result}");
    }
}