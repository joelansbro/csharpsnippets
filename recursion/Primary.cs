using System;

namespace recursion{
    class Primary{
        static void Main(String[] args){
            float answer = 0;
            // call the method
            answer = Power(2,2);
            Console.WriteLine("Answer is " + answer);
            bool running = true;
            while(running){
            }
        }
 // recursion in essence is a method that calls itself, with an exit condition to prevent a stack overflow
 // so below, we have to the power of
 // which times num by the method, which then times the method again and again etc until the variable power of is equal to one
 // which creates an exponent num * num * num etc
        private static float Power(float num, int powerOf){
            if(powerOf == 1){
                return num;
            }
            return num * Power(num, powerOf - 1);
        }

        private static int Factorial(int factorialNum){
            if (factorialNum == 1){
                return 1;
            }
            return factorialNum * Factorial(factorialNum - 1);
        }


    }

}