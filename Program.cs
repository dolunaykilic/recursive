using System;

public class Program

{

 public static void Main()
        {
            int number;
            int exponent;
            
            Console.Write( "Base: " );
            number = Convert.ToInt32( Console.ReadLine() );

            Console.Write( "Exponent: " );
            exponent = Convert.ToInt32( Console.ReadLine() );

            int output = Pow(number,exponent);    
            Console.Write( "Recursive: " + output); 
        }

 public static int Pow(int numberBase,int exponent)    
        {    
            if (exponent == 0) {
                return 1;
            } 
            else {
                return numberBase * Pow(numberBase,exponent - 1);
            }   
        } 
}