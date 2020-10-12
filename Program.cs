using System;
using System.Drawing;

namespace ImagetoText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Settings and status
            int duplicateArguments = 0;
            string inputFilePath = null;
            string outputFilePath = null;

            // Make sure a file has been specified
            if (args.Length == 0) {
                Console.WriteLine("Please specify the file you would like to convert to text. Type --help or -h for help.");
            }
            else {
                inputFilePath = args[0];

                // Override settings based on args
                for (int argIndex = 1; argIndex < args.Length; argIndex++) {
                    switch(args[argIndex]) {
                        case "-o":
                        case "--output":
                            if (outputFilePath == null) {
                                duplicateArguments++;
                            }
                            else {
                                outputFilePath = args[argIndex + 1];
                            }
                            argIndex++;
                            break;
                    }
                }

                // Attempt to load image from specified location
            }
        }
    }
}
