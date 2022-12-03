using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sakacirobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-ŞAKACI SHACO-:BİR SİHİR GÖSTERİSİNE NE DERSİN");
            string a1 = "BAK ARKANDA NE VAR";
            string a2 = "ÇOK EĞLENCELİ OLUCAK";
            string a3 = "ALEMİN SOYTARISI OLDUM";
            string a4 = "İŞTE GİDİYORUZ";
            string a5 = "SOL SAĞ SOL SAĞ ";
            string a6 = "BAK BİR VARIM BİR YOKUM";
            string a7 = "AZICIK DAHA YAVAŞ";
            string a8 = "SIRADA Kİ NUAMARAM İÇİN SENİ YOK EDİCEM";
            while (true)
            {
                string ask = Console.ReadLine();
                Console.WriteLine("-SHACO-:IRWHQIOTJHQWDSHJDFJIOTHIQW");
                Console.ForegroundColor = ConsoleColor.White;
                if (ask == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-SHACO-:ALEMİN SOYTARISI OLDUM");
                }

                if (ask == "a")
                {
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine("-SHACO-:SOL SAĞ SOL SAĞ SOL SAĞ SOL SAĞ");
                }
                if (ask == "şaka")
                {              
                    string[] shaco = {a1,a2,a3,a4,a5,a6,a7,a8};
                    Random rastgele=new Random();
                    int sakaci;
                    sakaci=rastgele.Next(0, shaco.Length);
                    Console.WriteLine(shaco[sakaci]);

                    if (sakaci ==0)
                    {
                        SoundPlayer a11 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a11.wav");
                        a11.Play();
                    }
                    if (sakaci == 1)
                    {
                        SoundPlayer a22 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a22.wav");
                        a22.Play();
                    }
                    if (sakaci == 2)
                    {
                        SoundPlayer a33 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a33.wav");
                        a33.Play();
                    }
                    if (sakaci == 3)
                    {
                        SoundPlayer a44 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a44.wav");
                        a44.Play();
                    }
                    if (sakaci == 4)
                    {
                        SoundPlayer a55 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a55.wav");
                        a55.Play();
                    }
                    if (sakaci == 5)
                    {
                        SoundPlayer a66 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a66.wav");
                        a66.Play();
                    }
                    if (sakaci == 6)
                    {
                        SoundPlayer a77 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a77.wav");
                        a77.Play();
                    }
                    if (sakaci == 7)
                    {
                        SoundPlayer a88 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a88.wav");
                        a88.Play();
                    }
                    
                }
                if (ask == "yeter" || ask== "YETER")
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("-ÜZGÜN SHACO-:NEDEN BU KADAR CİDDİSİN");
                    SoundPlayer a31 = new SoundPlayer(@"C:\Users\Saffet\Downloads\Music\a31.wav");
                    a31.Play();
                    break;
                }
            }
            Console.ReadLine();
        }
    }

}
