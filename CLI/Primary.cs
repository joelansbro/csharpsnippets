using System;
 
namespace CLI
{
    class Primary
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            // bring in an object!
            Methods methods = new Methods();

            // reload menu
            Console.Clear();
            // what are your options?
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Addition ");
            Console.WriteLine("2) Subtraction ");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");
 
            switch (Console.ReadLine())
            {
                case "1":
                    methods.addition();
                    return true;
                case "2":
                    methods.subtraction();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
  
        
    }
}