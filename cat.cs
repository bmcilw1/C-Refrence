// author: Brian McIlwian
// The purpose of this program is to serve as an example and practice for writing c# code from scratch.
// The program behaves like the *nix cat utility

using System;
using System.IO;

public class cat
{
    public static void Main(string[] args)
    {
        String line;
        foreach(string filename in args)
        {
            StreamReader file;

            if (File.Exists(filename))
            {
                file = new StreamReader(@filename);

                while((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                file.Close();
            }
            else
            {
                Console.WriteLine("Oops, file {0} not found!", filename);
            }

            Console.WriteLine();
        }
    }
}
