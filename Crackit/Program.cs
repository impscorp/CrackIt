// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        string[] passwords = new string[100000];
        for (int j = 0; j < passwords.Length; j++)
        {
            //start code in 20 threads

            Task[] tasks = new Task[20];
            for (int i = 0; i < 20; i++)
            {
                //random number between 3 and 5 digits
                int num = new Random().Next(3, 5);
                tasks[i] = Task.Run(() =>
                {
                    //go through every possibility of Generate Password
                    Console.WriteLine(CrackIt.Lib.CrackIt.GeneratePassword(num));
                    //passwords.Append(CrackIt.Lib.CrackIt.GeneratePassword(num));
                });
            }
            Task.WaitAll(tasks);
        }
    }
}



