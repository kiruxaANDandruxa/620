using ConsoleApp1212.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
///кроотв

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №5");
            Console.WriteLine("1-30");
            int sm = Convert.ToInt32(Console.ReadLine());

            bool a, b, c, x, y, z;


            switch (sm)
            {
                case 1:
                    a = true;
                    b = false;
                    c = false;

                    Calculator1 calculator1 = new Calculator1(a, b, c);
                    calculator1.DisplayResults1();
                    break;

                case 2:
                    x = false;
                    y = true;
                    z = false;

                    Calculator2 calculator2 = new Calculator2(x, y, z);
                    calculator2.DisplayResults2();
                    break;

                case 3:
                    double x31 = 1;
                    double y31 = 2;
                    double x32 = 2;
                    double y32 = -2;

                    Calculator3 calculator3 = new Calculator3(x31, y31, x32, y32);
                    calculator3.DisplayResults3();
                    break;

                case 4:
                    Console.WriteLine("Введите значение А");
                    double a4 = Convert.ToDouble(Console.ReadLine());

                    Calculator4 calculator4 = new Calculator4(a4);
                    calculator4.DisplayResults4();
                    break;

                case 5:
                    Console.WriteLine("Введите значение А");
                    double a5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    double b5 = Convert.ToDouble(Console.ReadLine());

                    Calculator5 calculator5 = new Calculator5(a5, b5);
                    calculator5.DisplayResults5();
                    break;

                case 6:
                    x = false;
                    y = false;
                    z = true;

                    Calculator6 calculator6 = new Calculator6(x, y, z);
                    calculator6.DisplayResults6();
                    break;

                case 7:
                    Console.WriteLine("Введите значение X");
                    double x7 = Convert.ToDouble(Console.ReadLine());

                    Calculator7 calculator7 = new Calculator7(x7);
                    calculator7.DisplayResults7();
                    break;

                case 8:
                    double x81 = 1;
                    double y81 = 2;
                    double x82 = 2;
                    double y82 = 1;

                    Calculator8 calculator8 = new Calculator8(x81, y81, x82, y82);
                    calculator8.DisplayResults8();
                    break;

                case 9:
                    double x91 = 1;
                    double y91 = 2;
                    double x92 = 2;
                    double y92 = 1;

                    Calculator9 calculator9 = new Calculator9(x91, y91, x92, y92);
                    calculator9.DisplayResults9();
                    break;

                case 10:
                    a = true;
                    b = false;
                    c = true;

                    Calculator10 calculator10 = new Calculator10(a, b, c);
                    calculator10.DisplayResults10();
                    break;

                case 11:
                    double x111 = 1;
                    double y111 = 2;
                    double x112 = 2;
                    double y112 = 1;

                    Calculator11 calculator11 = new Calculator11(x111, y111, x112, y112);
                    calculator11.DisplayResults11();
                    break;

                case 12:
                    Console.WriteLine("Введите значение А");
                    double a12 = Convert.ToDouble(Console.ReadLine());

                    Calculator12 calculator12 = new Calculator12(a12);
                    calculator12.DisplayResults12();
                    break;

                case 13:
                    Console.WriteLine("Введите значение A");
                    double a13 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    double b13 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение C");
                    double c13 = Convert.ToDouble(Console.ReadLine());

                    Calculator13 calculator13 = new Calculator13(a13, b13, c13);
                    calculator13.DisplayResults13();
                    break;

                case 14:
                    Console.WriteLine("Введите значение A");
                    double a14 = Convert.ToDouble(Console.ReadLine());

                    Calculator14 calculator14 = new Calculator14(a14);
                    calculator14.DisplayResults14();
                    break;

                case 15:
                    Console.WriteLine("Введите значение A");
                    double a15 = Convert.ToDouble(Console.ReadLine());

                    Calculator15 calculator15 = new Calculator15(a15);
                    calculator15.DisplayResults15();
                    break;

                case 16:
                    Console.WriteLine("Введите значение X");
                    double x16 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Y");
                    double y16 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Z");
                    double z16 = Convert.ToDouble(Console.ReadLine());

                    Calculator16 calculator16 = new Calculator16(x16, y16, z16);
                    calculator16.DisplayResults16();
                    break;

                case 17:
                    Console.WriteLine("Введите значение X");
                    double x17 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Y");
                    double y17 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Z");
                    double z17 = Convert.ToDouble(Console.ReadLine());

                    Calculator17 calculator17 = new Calculator17(x17, y17, z17);
                    calculator17.DisplayResults17();
                    break;

                case 18:
                    a = true;
                    b = false;
                    c = false;

                    Calculator18 calculator18 = new Calculator18(a, b, c);
                    calculator18.DisplayResults18();
                    break;

                case 19:
                    a = false;
                    b = false;
                    c = true;

                    Calculator19 calculator19 = new Calculator19(a, b, c);
                    calculator19.DisplayResults19();
                    break;

                case 20:
                    Console.WriteLine("Введите значение X");
                    double x20 = Convert.ToDouble(Console.ReadLine());

                    Calculator20 calculator20 = new Calculator20(x20);
                    calculator20.DisplayResults20();
                    break;

                case 21:
                    x = false;
                    y = false;
                    z = true;

                    Calculator21 calculator21 = new Calculator21(x, y, z);
                    calculator21.DisplayResults21();
                    break;

                case 22:
                    Console.WriteLine("Введите значение X");
                    double x22 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение Y");
                    double y22 = Convert.ToDouble(Console.ReadLine());

                    Calculator22 calculator22 = new Calculator22(x22, y22);
                    calculator22.DisplayResults22();
                    break;

                case 23:
                    Console.WriteLine("Введите значение A");
                    double a23 = Convert.ToDouble(Console.ReadLine());

                    Calculator23 calculator23 = new Calculator23(a23);
                    calculator23.DisplayResults23();
                    break;

                case 24:
                    Console.WriteLine("Введите значение A");
                    double a24 = Convert.ToDouble(Console.ReadLine());

                    Calculator24 calculator24 = new Calculator24(a24);
                    calculator24.DisplayResults24();
                    break;

                case 25:
                    Console.WriteLine("Введите значение A");
                    double a25 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B");
                    double b25 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение C");
                    double c25 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение D");
                    double d25 = Convert.ToDouble(Console.ReadLine());

                    Calculator25 calculator25 = new Calculator25(a25, b25, c25, d25);
                    calculator25.DisplayResults25();
                    break;

                case 26:
                    Console.WriteLine("Введите значение X");
                    double x26 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение X");
                    double y26 = Convert.ToDouble(Console.ReadLine());

                    Calculator26 calculator26 = new Calculator26(x26, y26);
                    calculator26.DisplayResults26();
                    break;

                case 27:
                    Console.WriteLine("Введите значение X");
                    double x27 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение X");
                    double y27 = Convert.ToDouble(Console.ReadLine());

                    Calculator27 calculator27 = new Calculator27(x27, y27);
                    calculator27.DisplayResults27();
                    break;

                case 28:
                    Console.WriteLine("Введите значение X");
                    double x28 = Convert.ToDouble(Console.ReadLine());

                    Calculator28 calculator28 = new Calculator28(x28);
                    calculator28.DisplayResults28();
                    break;

                case 29:
                    Console.WriteLine("Введите значение X");
                    double x29 = Convert.ToDouble(Console.ReadLine());

                    Calculator29 calculator29 = new Calculator29(x29);
                    calculator29.DisplayResults29();
                    break;

                case 30:
                    Console.WriteLine("Введите значение X");
                    double x30 = Convert.ToDouble(Console.ReadLine());

                    Calculator30 calculator30 = new Calculator30(x30);
                    calculator30.DisplayResults30();
                    break;
            }
        }
    }
}
