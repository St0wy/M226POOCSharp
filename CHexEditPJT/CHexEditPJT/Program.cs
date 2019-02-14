using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHexEditPJT
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!(File.Exists("putty.exe")))
            {
                Console.WriteLine("File \"putty.exe\" not found ! Press any key to exit ...");
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (!(File.Exists("putty.exe.bak")))
            {
                File.Copy("putty.exe", "putty.exe.bak");
            }

            int startPos = 0x12B2; //4786
            int byteCount = 0;
            string userInput = "";
            string bytesToAdd = "";
            bool userInputOk = false;
            byte[] bytesToWrite;
            byte[] lastBytes;

            using(BinaryReader reader = new BinaryReader(File.OpenRead("putty.exe")))
            {
                try
                {
                    reader.BaseStream.Position = startPos;

                    while(BitConverter.ToString(reader.ReadBytes(1)) != "00")
                    {
                        byteCount++;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
