using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailAdresleriFiltreleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> emailList = new List<string>
        {
                "Alpaslan@gmail.com",
            "mehmet@yahoo.com",
            "onderunlu@gmail.com",
            "deniz@outlook.com",
            "murat@gmail.com",
            "caner@yahoo.com",
            "bulut@yahoo.com",
            "çınar@outlook.com",
            "kadir@yahoo.com"
        };

            List<string> gmailAddresses = GetGmailAddresses(emailList);

            Console.WriteLine("Gmail'e ait e-posta adresleri:");
            foreach (string email in gmailAddresses)
            {
                Console.WriteLine(email);
            }
            Console.ReadKey();
        }

        static List<string> GetGmailAddresses(List<string> emailList)
        {
            List<string> gmailAddresses = new List<string>();

            foreach (string email in emailList)
            {
                // Eğer e-posta adresi 'gmail' anahtar kelimesini içeriyor ve 'gmail.com' ile bitiyorsa
                if (email.Contains("gmail") && email.EndsWith("gmail.com"))
                {
                    gmailAddresses.Add(email);
                }
            }

            return gmailAddresses;
        }
        
    }
    }

