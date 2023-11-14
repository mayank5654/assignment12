using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

                while (true)
                {
                    Console.WriteLine("Choose an operation:");
                    Console.WriteLine("1. Create a new file");
                    Console.WriteLine("2. Read a file");
                    Console.WriteLine("3. Append to a file");
                    Console.WriteLine("4. Delete a file");
                    Console.WriteLine("5. Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the file name: ");
                            string createFileName = Console.ReadLine();
                            Console.Write("Enter the content to write: ");
                            string createFileContent = Console.ReadLine();
                            CreateFile(createFileName, createFileContent);
                            break;

                        case 2:
                            Console.Write("Enter the file name to read: ");
                            string readFile = Console.ReadLine();
                            ReadFile(readFile);
                            break;

                        case 3:
                            Console.Write("Enter the file name to append: ");
                            string appendFileName = Console.ReadLine();
                            Console.Write("Enter the content to append: ");
                            string appendContent = Console.ReadLine();
                            AppendToFile(appendFileName, appendContent);
                            break;

                        case 4:
                            Console.Write("Enter the file name to delete: ");
                            string deleteFileName = Console.ReadLine();
                            DeleteFile(deleteFileName);
                            break;

                        case 5:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please choose a valid operation.");
                            break;
                    }
                }
            }
        //method to create a new file-------------------------
            static void CreateFile(string fileName, string content)
            {
                try
                {
                    File.WriteAllText(fileName, content);
                    Console.WriteLine($"File '{fileName}' created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating the file: {ex.Message}");
                }
            }
        //method to read the content of existing -------------
            static void ReadFile(string fileName)
            {
                try
                {
                    string content = File.ReadAllText(fileName);
                    Console.WriteLine($"Content of file '{fileName}':\n{content}");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File '{fileName}' not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading the file: {ex.Message}");
                }
            }
        //method to apppend content to an existing file-----------
            static void AppendToFile(string fileName, string content)
            {
                try
                {
                    File.AppendAllText(fileName, content);
                    Console.WriteLine($"Content appended to file '{fileName}' successfully.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File '{fileName}' not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error appending to the file: {ex.Message}");
                }
            }
        //method to delete the existing file------------------
            static void DeleteFile(string fileName)
            {
                try
                {
                    File.Delete(fileName);
                    Console.WriteLine($"File '{fileName}' deleted successfully.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File '{fileName}' not found.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting the file: {ex.Message}");
                }
            }
        

    }
}

