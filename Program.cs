using System;
using System.IO;

namespace cs_con_create_directory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\app\workspace\subject-test";

            try
            {
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine($"The directory was created successfully at {Directory.GetCreationTime(path)}." );

                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"The process failed: {e.ToString()}" );
            }
        }
    }
}
