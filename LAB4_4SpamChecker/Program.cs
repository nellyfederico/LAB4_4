using System;

namespace LAB4_4SpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] blackListWord = 
            { "pills", "buy", "viagra", "XXX", "free money",
            "lifetime offer", "send money", "bank account",
            "nigeria", "online pharmacy", "h8te", "meet girls" };

            bool isSpam = false;
            string message = Console.ReadLine();
            message = message.ToLower();
            for (int i = 0; i < blackList.Length; i++)
            {
                if (message.Contains(blackList[i]))
                {
                    isSpam = true;
                }
            }


            if(isSpam == true)
            { 
                Console.WriteLine("This email is spam and it has been sent to the Spam Folder!");
            }
            else
            {
                Console.WriteLine("This email Ok!");
            }
        }
    }
}
