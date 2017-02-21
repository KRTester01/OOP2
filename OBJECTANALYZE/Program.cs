using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJECTANALYZE
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReaders = new fileReader();
            var code = fileReaders.ReadInTheFile();

            var analyzer = new SourceFileAnalyzer();
            var results = analyzer.GetTheMethodDetails();

            Console.WriteLine("Please enter a file name");
        }
                   public string FileName = Console.ReadLine();
    }
                }
  
