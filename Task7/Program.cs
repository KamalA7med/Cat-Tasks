using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
      public  static async  Task<string>  DownloadDataAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Downloading Data : ");
                for (int i = 0; i < 30; i++)
                {
                   
                    Console.Write("| ");
                    Thread.Sleep(1000);
                }
            }
            );
            return "\nData downloaded";
        }
        static async Task  Main(string[] args)
        {
           
        string Result= await DownloadDataAsync();
         
            Console.WriteLine(Result);
            
        }
    }
}
