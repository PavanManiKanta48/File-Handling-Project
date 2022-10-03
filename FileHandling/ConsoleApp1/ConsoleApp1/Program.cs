using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"..\..\text.txt"; 
            string file = File.ReadAllText(filepath);
            Console.WriteLine(file);

            Console.WriteLine("\n path of text file :" + filepath);
            //Read all the charecter from the text file
            int count = File.ReadAllText(filepath).Length;
            Console.WriteLine("\n Total characters :" + count);

            
            //Name and extention of text file
            FileInfo fullPath = new FileInfo(filepath);  //give the location Of the file
            string fileName = fullPath.Name; //gives file name
            string fileExtension = fullPath.Extension;  //Gives extension
            Console.WriteLine("\n name of text file : " + fileName);
            Console.WriteLine("\n extensition of text file :" + fileExtension);
            
            string[] Wcount = file.Split(' '); //count start from 0 to 93 total 94 words.
            //count of wordtextfile
            int wordCount = 0;
            foreach (string str in Wcount)
            {
                if (str != string.Empty)
                {
                    wordCount++;
                }
            }
            Console.WriteLine("\n count of word from text file : " + wordCount);
            Console.ReadLine();
            // File.Delete(@"..\..\text.txt");
            // copy text file from another folder where you copied
            string file1 = @"..\..\text.txt";
            string destination = @"..\..\textcopy.txt";
            File.Copy(file1, destination, true);
        }
    }
}
