using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingOperations_Feb8
{
    internal class Program
    {
        class FileWrite
        {

            public void writeData()
            {
                FileStream fs = new FileStream("C:\\FilesOperations\\test.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter the text which you want to write to the file");
                String str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
        }

        class FileRead
        {

            public void readData()
            {
                FileStream fs = new FileStream("C:\\FilesOperations\\test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show the content of the file");
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                String str=sr.ReadLine();
                while(str!= null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();
            }
        }

        public class ReadFromCurrent
        {
            public void readDataCuurent()
            {
                FileStream fs = new FileStream("C:\\FilesOperations\\test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show the content of the file");
                sr.BaseStream.Seek(0, SeekOrigin.Current);
                String str = sr.ReadLine();
                while (str!= null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();
            }
        }
        public class ReadFromEnd
        {
            public void readDataEnd()
            {
                FileStream fs = new FileStream("C:\\FilesOperations\\test.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine("Program to show the content of the file");
                sr.BaseStream.Seek(-2, SeekOrigin.End);
                String str = sr.ReadLine();
                while (str!= null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();
                sr.Close();
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            FileWrite wr = new FileWrite();
            FileRead fr = new FileRead();
            ReadFromCurrent rc = new ReadFromCurrent();
            ReadFromEnd re = new ReadFromEnd();
            do
            {
                Console.WriteLine("Choose the option to read or write:");
                Console.WriteLine("1. read data from beginning  2. write the data to file 3. Read from current 4.Read from end");
                string str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        fr.readData(); break;
                    case "2":
                        wr.writeData(); break;
                    case "3":
                        rc.readDataCuurent(); break;
                    case "4":
                        re.readDataEnd(); break;
                    default:
                        Console.WriteLine("Choose the correct one");
                        break;

                }
                
            } while (true);
        }  
            
        }
    }

