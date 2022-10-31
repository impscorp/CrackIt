// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace Crackit;

class Program
{
    public static void Main(string[] args)
    {
        string validchars = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~äÄöÖ";
        int num = 3;
        // for (int i = 0; i < 1_000; i++)
        // {
        //     Console.WriteLine("test");
        // }
        // Thread.Sleep(50);
        // Console.WriteLine(".*r");
        int c = 0;
        while (true)
        {
            //CrackIt.Lib.CrackIt.GeneratePermutationss(validchars, num, 10);
            IEnumerable<string> Pws = CrackIt.Lib.CrackIt.GeneratePermutations(validchars, num);
            // //write all pws
            foreach (string pw in Pws)
            {
                Console.WriteLine(pw);
                //c++;
                // if (c == 50)
                // {
                //     Thread.Sleep(50);
                //     c = 0;
                //     //Console.WriteLine(pw);
                //     //Console.WriteLine(".*r");
                // }


            }
            //GC.Collect();
            num++;
        }
    }
}



/*class Program
{
    public static void Main(string[] args)
    {
        string validchars = "!\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~äÄöÖ";
        
        //start crackMe.exe
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "CrackMe";
        startInfo.RedirectStandardInput = true;
        startInfo.UseShellExecute = false;
        startInfo.Arguments = "--";
        startInfo.RedirectStandardOutput = true;
        Process crackMe = Process.Start(startInfo)!;
        //declare 20 threads
        Task[] tasks = new Task[20];
        
        while (!crackMe.HasExited)
        {
            
            //start code in 20 threads
            StreamWriter stdin = crackMe.StandardInput;

            for (int i = 0; i < 20; i++)
            {
                //random number between 3 and 5 digits
                int num = new Random().Next(3, 5);
                tasks[i] = Task.Run(() =>
                {
                    //Console.WriteLine(CrackIt.Lib.CrackIt.GeneratePassword(num));
                    stdin.WriteLineAsync(CrackIt.Lib.CrackIt.GeneratePassword(num));
                });

            }
            crackMe.WaitForExit();
            if (crackMe.ExitCode.ToString() == "0")
            {
                Console.WriteLine("Password found!" + crackMe.StandardOutput.ReadToEnd());
                crackMe.Kill();
            }
            
            //Task.WaitAll(tasks);
        }
    }
}*/