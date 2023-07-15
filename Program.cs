using System.Threading;

namespace BANKOMAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
        langQayta:
            Kirish();
            int language;         
            language = int.Parse(Console.ReadLine());
            Console.Clear();    
            int cardPass = 1111;
            double balans = 10000000;
            if (language == 1) 
            {
                passQayta:
                Console.Write("Plastik kartangizni parolini kiriting - ");
                int pass = int.Parse(Console.ReadLine());
                Console.Clear();
                if(cardPass == pass)
                {
                    qaytaBowla:
                    showMenu();
                    
                    Console.Write("Marhamat amalni tanlang - ");
                qaytaMenu:
                    int selectMenu = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if(selectMenu == 1)
                    {
                        int tanla;
                        
                    qaytaBalans:
                        
                        Console.WriteLine($"Balansingizda {balans} so`m pul mavjud.");
                        Console.WriteLine("0: Orqaga.");
                        Console.Write("Tanlang: ");
                        tanla = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (tanla == 0)
                        {
                            showMenu();
                            Console.Write("Marhamat amalni tanlang - ");
                            goto qaytaMenu;
                        }
                        else
                        {
                            Console.WriteLine("Xatolik qayatadan kiritng! \n");
                            Thread.Sleep(2000);
                            goto qaytaBalans;
                        }
                    }

                    if(selectMenu == 2)
                    {
                        naqtPul();
                        Console.Write("Marhamat tanlang: ");
                        int naqtpul = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(naqtpul == 1)
                        {
                            qayta50:
                            Console.WriteLine("50 000 so`m ");
                            Console.WriteLine("KOMISSIYA = " + 500 + " so`m");
                            Console.WriteLine("1: HA");
                            Console.WriteLine("2: Yo`q");
                            Console.Write("Tanlang: ");
                            int ha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (ha == 1) 
                            {
                                Console.WriteLine("Muvofaqiyatli!\n");
                                //Console.WriteLine("Kartangizni oling!\n");
                                Thread.Sleep(2000);
                                Console.WriteLine("Pulingizni oling!\n");
                                Thread.Sleep(3000);
                                Console.WriteLine("Yana amal bajarasizmi?\n1. Ha \t\t 2. Yo`q \n");
                                Console.Write("Tanlang: ");
                                int yangiAmal = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (yangiAmal == 1)
                                {
                                    double newBalans = balans - (50000 + 500);
                                    balans = newBalans;
                                    goto qaytaBowla;
                                }
                                else if (yangiAmal == 2)
                                {
                                    Console.WriteLine("Marhamat kartangizni oling;");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Xatolik!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto qayta50;
                            }
                        }

                        else if (naqtpul == 2)
                        {
                        qayta100:
                            Console.WriteLine("100 000 so`m ");
                            Console.WriteLine("KOMISSIYA = " + 1000 + " so`m");
                            Console.WriteLine("1: HA");
                            Console.WriteLine("2: Yo`q");
                            Console.Write("Tanlang: ");
                            int ha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (ha == 1)
                            {
                                Console.WriteLine("Muvofaqiyatli!\n");
                                //Console.WriteLine("Kartangizni oling!\n");
                                Thread.Sleep(3000);
                                Console.WriteLine("Pulingizni oling!\n");
                                Console.WriteLine("Yana amal bajarasizmi?\n1. Ha \t\t 2. Yo`q \n");
                                Console.Write("Tanlang: ");
                                int yangiAmal = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (yangiAmal == 1)
                                {
                                    double newBalans = balans - (100000 + 100);
                                    balans = newBalans;
                                    goto qaytaBowla;
                                }
                                else if (yangiAmal == 2)
                                {
                                    Console.WriteLine("Marhamat kartangizni oling;");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Xatolik!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto qayta100;
                            }
                        }

                        else if (naqtpul == 3)
                        {
                        qayta200:
                            Console.WriteLine("200 000 so`m ");
                            Console.WriteLine("KOMISSIYA = " + 2000 + " so`m");
                            Console.WriteLine("1: HA");
                            Console.WriteLine("2: Yo`q");
                            Console.Write("Tanlang: ");
                            int ha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (ha == 1)
                            {
                                Console.WriteLine("Muvofaqiyatli!\n");
                                //Console.WriteLine("Kartangizni oling!\n");
                                Thread.Sleep(3000);
                                Console.WriteLine("Pulingizni oling!\n");
                                Console.WriteLine("Yana amal bajarasizmi?\n1. Ha \t\t 2. Yo`q \n");
                                Console.Write("Tanlang: ");
                                
                                int yangiAmal = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (yangiAmal == 1)
                                {
                                    double newBalans = balans - (200000 + 200);
                                    balans = newBalans;
                                    goto qaytaBowla;
                                }
                                else if (yangiAmal == 2)
                                {
                                    Console.WriteLine("Marhamat kartangizni oling;");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Xatolik!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto qayta200;
                            }
                        }

                        else if (naqtpul == 4)
                        {
                        qayta300:
                            Console.WriteLine("300 000 so`m ");
                            Console.WriteLine("KOMISSIYA = " + 3000 + " so`m");
                            Console.WriteLine("1: HA");
                            Console.WriteLine("2: Yo`q");
                            Console.Write("Tanlang: ");
                            int ha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (ha == 1)
                            {
                                Console.WriteLine("Muvofaqiyatli!\n");
                               // Console.WriteLine("Kartangizni oling!\n");
                                Thread.Sleep(3000);
                                Console.WriteLine("Pulingizni oling!\n");
                                Console.WriteLine("Yana amal bajarasizmi?\n1. Ha \t\t 2. Yo`q \n");
                                Console.Write("Tanlang: ");
                                int yangiAmal = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (yangiAmal == 1)
                                {
                                    double newBalans = balans - (300000 + 300);
                                    balans = newBalans;
                                    goto qaytaBowla;
                                }
                                else if (yangiAmal == 2)
                                {
                                    Console.WriteLine("Marhamat kartangizni oling;");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Xatolik!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto qayta300;
                            }
                        }

                        else if (naqtpul == 5)
                        {
                        qayta400:
                            Console.WriteLine("400 000 so`m ");
                            Console.WriteLine("KOMISSIYA = " + 4000 + " so`m");
                            Console.WriteLine("1: HA");
                            Console.WriteLine("2: Yo`q");
                            Console.Write("Tanlang: ");
                            int ha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if (ha == 1)
                            {
                                Console.WriteLine("Muvofaqiyatli!\n");
                               // Console.WriteLine("Kartangizni oling!\n");
                                Thread.Sleep(3000);
                                Console.WriteLine("Pulingizni oling!\n");
                                Thread.Sleep(3000);
                                Console.WriteLine("Yana amal bajarasizmi?\n1. Ha \t\t 2. Yo`q \n");
                                Console.Write("Tanlang: ");
                                
                                int yangiAmal = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (yangiAmal == 1)
                                {
                                    double newBalans = balans - (400000 + 400);
                                    balans = newBalans;
                                    goto qaytaBowla;
                                }
                                else if (yangiAmal == 2)
                                {
                                    Console.WriteLine("Marhamat kartangizni oling;");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Xatolik!");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto qayta400;
                            }
                        }

                        else if(naqtpul == 6)
                        {
                            qaytaBowqaSumma:
                            qaytaSumma:
                            Console.Write("Marhamat summani kiritng -> ");
                            int summa = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if(summa < balans)
                            {
                                if(summa % 10000 == 0)
                                {
                                    Console.WriteLine("KOMISSIYA = " + (summa * 0.01f) + " so`m");
                                    Console.WriteLine("1: HA");
                                    Console.WriteLine("2: Yo`q");
                                    Console.Write("Tanlang: ");
                                    int ha = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    if (ha == 1)
                                    {
                                        Console.WriteLine("Muvofaqiyatli!\n");
                                       // Console.WriteLine("Kartangizni oling!\n");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("Pulingizni oling!");
                                        Console.WriteLine("Yana amal bajarasizmi?\n1. Ha \t\t 2. Yo`q");
                                        Console.Write("Tanlang: ");
                                        int yangiAmal = int.Parse(Console.ReadLine());
                                        Console.Clear();
                                        if (yangiAmal == 1)
                                        {
                                            double newBalans = balans - (summa * 0.01f);
                                            balans = newBalans;
                                            goto qaytaBowla;
                                        }
                                        else if(yangiAmal == 2)
                                        {
                                            Console.WriteLine("Marhamat kartangizni oling;");
                                        }                                       
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kartangizni oling;");
                                    }
                                }

                                else
                                {
                                    Console.WriteLine("Xatolik! Faqat 10000 so`mlik kupyurada pul ololasiz.");
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    goto qaytaBowqaSumma;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sizning kartangizda mablag` yetarli emas. Qaytadan urunib ko`ring! ");
                                goto qaytaBowqaSumma;
                            }

                        }

                        else if(naqtpul == 0)
                        {
                            goto qaytaBowla;
                        }
                        
                        else
                        {
                            Console.WriteLine("To`gri operatr tanlang!");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto qaytaBowla;
                        }
                    }

                    else if(selectMenu == 3)
                    {
                        qaytaSms:
                        SmsUlash();
                        Console.Write("Tanlang: ");
                        int smsulash = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(smsulash == 1)
                        {
                            Console.Write("Qaysi raqamga ulamoqchisiz --> +9989 ");
                            // 900000000
                            int phoneNum = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if(phoneNum >= 900000000 && phoneNum <= 999999999)
                            {
                                Console.WriteLine("\t\t\tMuvofaqiyatli ulandi;");
                                Console.WriteLine("\t Yana amal bajarasizmi \n1: Ha. \t\t\t\t2:Yo`q.");
                                Console.Write("Tanlang - ");
                                int c = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if(c == 1)
                                {
                                    goto qaytaBowla;
                                }
                                else
                                {
                                    Console.WriteLine("Kartangizni oling;");
                                }
                            }
                        }
                        else if(smsulash == 2)
                        {
                            Console.WriteLine("Sizning 8600 **** **** 5992 kartangiz -> 91 **** 22 56 ga ulangan;");
                            Console.WriteLine("1: Sms xabarnomani o`chirish. \t\t 2: Orqaga");
                            Console.Write("Tanlang - ");
                            int d = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if(d == 1)
                            {
                                qaytaRand:
                                Random rnd = new Random();
                                int randNum1 = rnd.Next(1000,9999);
                                Console.WriteLine("91 **** 22 56 sms orqali kod yuborildi; \t\t\t\t\t\t\t Sms kod - " + randNum1);
                                //Console.Write("Kodni kiritng - ");
                                Console.Write("Kodni kiritng - ");
                                int randomSon = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if(randNum1 == randomSon)
                                {
                                    Console.WriteLine("\t\tMuvofaqiyatli bajarildi;");
                                    Console.WriteLine("\t Yana amal bajarasizmi? \n1: Ha. \t\t\t\t2:Yo`q.\n");
                                    Console.Write("Tanlang - ");
                                    int g = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    if (g == 1)
                                    {
                                        goto qaytaBowla;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kartangizni oling;");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sms kod xato kiritldi. Qaytadan urunib ko`ring;");
                                    goto qaytaRand;
                                }
                            }
                            else if(d == 2)
                            {
                                goto qaytaSms;
                            }
                        }
                        else if(smsulash == 0)
                        {
                            goto qaytaBowla;
                        }
                        else
                        {
                            Console.WriteLine("Nato`g`ri amal bajardindiz. Qaytadan urunib koring!");
                            goto qaytaSms;
                        }
                    }

                    else if(selectMenu == 4)
                    {
                        ParolOzgartirish();
                        Console.Write("Tanlang - ");
                        int pass1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(pass1 == 1)
                        {
                            qaytaPass:
                            Console.WriteLine("Yangi parolni kiriting\t\t\t\t ESLATMA -> parol(4 xonali)");
                            Console.Write("NewPas =  ");
                            int newPas = int.Parse(Console.ReadLine());
                            if(newPas <= 9999 && newPas >= 1000)
                            {
                                Console.WriteLine("Yangi parolni qaytadan kiriting: ");
                                Console.Write("NewPas =  ");
                                int newPas2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if(newPas2 <= 9999 && newPas2 >= 1000 && newPas == newPas2)
                                {
                                    Console.WriteLine("Muvoffaqiyatli o`zgartirildi!");
                                    cardPass = newPas2;
                                    Console.WriteLine("1: Parolni tekshirish \t\t 0:Ortga");
                                    Console.Write("Tanlang: ");
                                    int a = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    if(a == 1)
                                    {
                                        goto passQayta;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Kartangizni Oling;");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Xatolik! Qaytadan urunib ko`ring.");
                                    Thread.Sleep(2000);
                                    Console.Clear();
                                    goto qaytaPass;
                                }
                            }                        
                            else
                            {
                                Console.WriteLine("Parol xato kiritildi! ");
                                Thread.Sleep(2000);
                                Console.Clear();
                                goto qaytaPass;
                            }


                        }
                        else
                        {
                            goto qaytaBowla;
                        }
                    }

                    else if(selectMenu == 5)
                    {
                        KreditTolovlari();
                        Console.Write("Tanlang: ");
                        int kreditRaqam = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(kreditRaqam == 1)
                        {
                            qaytaKredit:
                            Console.Write("Qancha kreditni so`ndirmoqchisiz? (so`mda) - ");
                            int krediSum = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if(krediSum > 0 && krediSum < balans) 
                            {
                                double newbalans2 = balans - krediSum;
                                Console.WriteLine("\t\t\tMuvoffaqiyatli!\n\nYana amal bajarmoqchimisiz?\n");
                                balans = newbalans2;
                                Console.WriteLine("1: Menu. \t\t\t 0: Tugatish.");
                                int b = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if(b == 1)
                                {
                                    goto qaytaBowla;
                                }
                                else
                                {
                                    Console.WriteLine("Kartangizni oling!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Mablag` yetarli emas! Qaytadan kiriting.");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto qaytaKredit;
                            }
                        }
                    }

                    else if(selectMenu == 6)
                    {
                        Console.WriteLine("Profilaktika!!!!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        goto qaytaBowla;
                    }

                    else if(selectMenu == 7)
                    {
                        Console.WriteLine("Kartangizni oling;");
                    }
                }
                else
                {
                    Console.WriteLine("Parol nato`g`ri kiritldi qaytadan urunib ko`ring!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    goto passQayta;
                }
                
            }
            else if(language == 2)
            {

            }

            else if(language == 3)
            {

            }

            else
            {
                Console.WriteLine("Hozircha bizda faqat 3 ta til bor, qaytadan kiritng;");
                Thread.Sleep(2000);
                Console.Clear();
                goto langQayta;
            }
        }

        static void Kirish()
        {
            Console.WriteLine("\t\t\t\tBankomatga hush kelibsiz!");
            Console.WriteLine("1: Uzbekcha.");
            Console.WriteLine("2: Ingilizcha.(PROFILAKTIKA!!!)");
            Console.WriteLine("3: Ruscha.(PROFILAKTIKA!!!)");
            Console.Write("Marhamat tilni tanlang - ");
        }

        static void showMenu()
        {
            Console.WriteLine("\t\t\t\tBosh Menu!");
            Console.WriteLine("1: Balansni tekshirish.");
            Console.WriteLine("2: Naqt pul olish.");
            Console.WriteLine("3: Sms xabarnoma ulash.");
            Console.WriteLine("4: Parolni ozgartirish.");
            //Console.WriteLine("5: Mobil aloqa uchun to`lov.");
            Console.WriteLine("5: Kredit so`ndirish.");
            Console.WriteLine("6: Kamunal to`lovlar.(PROFILAKTIKA)");
            Console.WriteLine("7: Dasturdan chiqish.");
            Console.WriteLine("\n");
        }

        static void naqtPul()
        {
            Console.WriteLine("\t\t\t\t Naqt pul olish!");
            Console.WriteLine("1: 50 000 so`m");
            Console.WriteLine("2: 100 000 so`m");
            Console.WriteLine("3: 200 000 so`m");
            Console.WriteLine("4: 300 000 so`m");
            Console.WriteLine("5: 400 000 so`m");
            Console.WriteLine("6: Boshqa summa!");
            Console.WriteLine("0: Ortga.");

        }

        static void ParolOzgartirish()
        {
            Console.WriteLine("\t\t\tParol ozgartirish!");
            Console.WriteLine("1: Yangi parol kiritish.");
            Console.WriteLine("0: Ortga.");
        }

        static void KreditTolovlari()
        {
            Console.WriteLine("\t\t\t Kreditni so`ndirish!");
            Console.WriteLine("1: Ta`lim krediti;");
            Console.WriteLine("0: Ortga;");
        }

        static void SmsUlash()
        {
            Console.WriteLine("\t\t\t Sms xabarnoma ulash!");
            Console.WriteLine("1: Sms xabar ulash.");
            Console.WriteLine("2: Sms xabarnomani o`chirish.");
            Console.WriteLine("0: Ortga.");
        }
    }
}