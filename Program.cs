using System;
using System.IO;

namespace Enums_Stretch_Zachory
{
    //Sets months and their number values.
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        //My birthday turned into variables to be stored.
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Sep;
            int myBirthDay = 10;
            int myBirthYear = 2004;
            //String that holds a sentence for my birthday.
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

            //Prints text to the screen then prints more text to the screen.
            File.WriteAllText("myfile.txt", "This is my text file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (!File.Exists("newFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            //Prints birtday string to the screen.
            File.AppendAllText("newFile.txt", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
    }
}
