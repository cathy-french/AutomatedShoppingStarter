using AutomatedShopping.POMs;
namespace ElfShopper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingSite shoppingSite = new ShoppingSite();
            try
            {
 
            }
            finally
            {
                shoppingSite.SeleniumDriver.Close();
                shoppingSite.SeleniumDriver.Quit();
            }
        }

    }
}
