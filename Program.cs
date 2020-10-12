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
            bool help = false;
            string inputFilePath = null;
            string outputFilePath = null;

            // Print newline for cleanliness
            Console.WriteLine();

            // Make sure a file has been specified
            if (args.Length == 0) {
                Console.WriteLine("Please specify the file you would like to convert to text. Type --help or -h for help.");
            }
            else {
                inputFilePath = args[0];

                // Override settings based on args
                for (int argIndex = 1; argIndex < args.Length; argIndex++) {
                    switch(args[argIndex]) {

                        case "-h":
                        case "--help":
                            if (help) {
                                duplicateArguments++;
                            }
                            help = true;
                            break;

                        case "-o":
                        case "--output":
                            if (outputFilePath == null) {
                                duplicateArguments++;
                            }
                            else if ((argIndex + 1) >= args.Length) {
                                Console.WriteLine("Warning: Option that expects an argument was not given an argument. The option has been ignored.");
                            }
                            else {
                                outputFilePath = args[argIndex + 1];
                            }
                            argIndex++;
                            break;
                    }
                }

                // Warn about duplicate options
                    if (duplicateArguments > 0) {
                        Console.WriteLine($"Warning: {duplicateArguments.ToString()} duplicate option(s) were given. All extraneous options have been ignored.\n");
                    }

                // Help page
                if (help) {
                    Console.WriteLine(String.Join(
                        Environment.NewLine,
                        "Usage:",
                        "  ImagetoText <image path> [options]",
                        "",
                        "Options:",
                        "  -h, --help                           Shows this help page.",
                        "  -o, --output <output file path>      Path to save output files."
                    ));
                }
                else {

                }

            }

            // Print newline for clenliness
            Console.WriteLine();
        }
    }
}
