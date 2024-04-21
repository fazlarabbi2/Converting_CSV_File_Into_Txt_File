using System;
using System.IO;

public class CSVtoTXTConverter
{
    public static void CSV_to_Txt_Convert(string csvFilePath, string txtFilePath)
    {
        // Read all lines from the CSV file
        string[] csvLines = File.ReadAllLines(csvFilePath);

        //StreamWriter class in C# is used for writing characters to stream in a particular format.
        //https://www.c-sharpcorner.com/article/csharp-streamwriter-example/

        // Open the TXT file for writing
        using (StreamWriter writer = File.CreateText(txtFilePath))
        {
            // Write each CSV line to the TXT file
            foreach (string line in csvLines)
            {
                writer.WriteLine(line);
            }
        }
    }

    public static void Main(string[] args)
    {
        // Specify the paths to your CSV and TXT files
        string csvFilePath = @"C:\Users\Fozle Rabbi\Desktop\Visual Studio\Design Pattern\CSV_to_TXT\input.csv";
        string txtFilePath = @"C:\Users\Fozle Rabbi\Desktop\Visual Studio\Design Pattern\CSV_to_TXT\output.txt";

        // Convert the CSV file to TXT
        CSVtoTXTConverter.CSV_to_Txt_Convert(csvFilePath, txtFilePath);

        Console.WriteLine("CSV file converted to TXT successfully!");

        Console.ReadLine();
    }
}
