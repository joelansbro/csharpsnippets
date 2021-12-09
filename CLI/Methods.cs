using System;

namespace CLI{
    public class Methods{
// to capture the input methods for the mother methods
        public string CaptureString()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }
        public int CaptureInt(){
            Console.Write("Enter the integer you want");
            return Convert.ToInt32(Console.ReadLine());
        }

// the mother methods that we're accessing with the cases
    public void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");
 
            char[] charArray = CaptureString().ToCharArray();
            Array.Reverse(charArray);
            DisplayResultString(String.Concat(charArray));
        }
        public void addition(){
            Console.Clear();
            Console.WriteLine("Calculating...");
            int x = CaptureInt();
            int y = CaptureInt();
            int z = x + y;
            DisplayResultInt(z);
        }

        public void subtraction(){
            Console.Clear();
            Console.WriteLine("Calculating...");
            int x = CaptureInt();
            int y = CaptureInt();
            int z = x - y;
            DisplayResultInt(z);
        }

// methods to display the results
        public void DisplayResultInt(int result){
            Console.WriteLine($"\r\nYour result is: {result}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
        public void DisplayResultString(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

    }
}