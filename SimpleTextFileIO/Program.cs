
using System.IO;

// Erin Cascioli
// 1/24/25
// Demo: Text File IO (with string splitting)

namespace SimpleTextFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the streams here!
            StreamReader reader = null;
            StreamWriter writer = null;

            // Needed for local file data storage
            List<string> name = new List<string>();
            List<int> age = new List<int>();
            List<bool> pickles = new List<bool>();

            // Errors could occur if the file doesn't exist, or if the path is incorrect.
            // Use a try block with a catch and finally here!
            try
            {
                // Create a StreamReader object
                reader = new StreamReader("../../../MyTextFile.txt");
                string lineOfText = "";

                // Read each line of the file until there's no more data to read
                while ((lineOfText = reader.ReadLine()!) != null)
                {
                    // Each line of the file's format is as follows:
                    //   (string)|(int)|(bool)
                    //   Person's name|Their age|Do they like pickles?

                    // After the line has been read, split it using the pipe delimiter
                    string[] splitLineData = lineOfText.Split('|');

                    // This string array contains each person's data in separate indices! :)
                    // Add each index to the correct list.
                    // 0 --> name
                    // 1 --> age
                    // 2 --> pickles
                    name.Add(splitLineData[0]);
                    age.Add(int.Parse(splitLineData[1]));
                    pickles.Add(bool.Parse(splitLineData[2]));
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred reading the file: " + error.Message);
            }
            finally
            {
                // As long as the reader was properly initialized...
                if (reader != null)
                {
                    // Close the stream, which closes the file
                    reader.Close();
                }
            }


            //-----------------------------------------------------------------
            try
            {
                // Initialize the writing stream
                // If the file doesn't already exist, the stream will create the file for you
                writer = new StreamWriter("../../../turtle.txt");

                // Add whatever data you want to the file
                writer.WriteLine("Something else here.");
                writer.WriteLine("and more here.");

                // Data can also be added in loops if needed
                for(int i = 0; i < 10; i++)
                {
                    // Last number? Only call a Write instead of a WriteLine
                    if(i == 9)
                    {
                        writer.Write("I is " + i);
                    }
                    // All other file lines can have a WriteLine
                    else
                    {
                        writer.WriteLine("I is " + i);
                    }
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("Error occurred writing to the file: " + error.Message);
            }
            finally
            {
                if (writer != null)
                {
                    // Close the stream, which closes the file
                    // Data is not written to a file UNTIL the stream is closed! 
                    writer.Close();
                }
            }
        }
    }
}
