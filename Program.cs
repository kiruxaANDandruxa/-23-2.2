using System.Diagnostics;
using System.Linq.Expressions;
using ConsoleApp1;

namespace ConsoleApp3;

    internal class Program
    {

    ///Калганов Андрей и Кротов Кирилл П23-2.2

    static void Main(string[] args)
    {
        Console.WriteLine("Практическая работа №1");
        Console.WriteLine("1-30");
        int sw = Convert.ToInt32(Console.ReadLine());

        switch (sw) {

            case 1:

                double R, t1, l;

                Console.WriteLine("Введите число t");
                t1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число l");
                l = Convert.ToDouble(Console.ReadLine());

                MyTaskClass1 myTaskClass1 = new MyTaskClass1(l, t1);
                myTaskClass1.R();
                //R = 3 * Math.Pow(t1, 2)+3* Math.Pow(l, 5) + 4.9;
                //Console.WriteLine($"R = {R}");
                break;
        

            case 2:

                double K, p, y2, e;

                Console.WriteLine("Введите значение p");
                p = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение e");
                e = Convert.ToDouble(Console.ReadLine());

                MyTaskClass2 myTaskClass2 = new MyTaskClass2(p, y2, e);
                myTaskClass2.K();
                //K = Math.Log(Math.Pow(p, 2) + Math.Pow(y2, 3) + Math.Pow(e, p));
                //Console.WriteLine($"K = {K}");
                break;

            case 3:

                double G, n, y3;

                Console.WriteLine("Введите значение n");
                n = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y");
                y3 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass3 myTaskClass3 = new MyTaskClass3(n, y3);
                myTaskClass3.K();
                //G = n * (y3 + 3.5) + Math.Sqrt(y3);
                //Console.WriteLine($"G = {G}");
                break;

            case 4:

                double D, a, t4;

                Console.WriteLine("Введите значение a");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение t");
                t4 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass4 myTaskClass4 = new MyTaskClass4(a, t4);
                myTaskClass4.D();
                //D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t3, 5));
                //Console.WriteLine($"D = {D}");
                break;

            case 5:

                double L, x5;

                Console.WriteLine("Введите значение x");
                x5 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass5 myTaskClass5 = new MyTaskClass5(x5);
                myTaskClass5.L();
                //L = 1.51 * Math.Cos(Math.Pow(x5, 2)) + 2 * Math.Pow(x5, 3);
                //Console.WriteLine($"L = {L}");
                break;

            case 6:

                double M, y6, e6, x6;

                Console.WriteLine("Введите значение y");
                y6 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение e");
                e6 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение x");
                x6 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass6 myTaskClass6 = new MyTaskClass6(y6, e6, x6);
                myTaskClass6.M();
                //M = Math.Cos(2) * y + 3.6 * Math.Pow(e6, x6);
                //Console.WriteLine($"M = {M}");
                break;

            case 7:

                double N, m7;

                Console.WriteLine("Введите значение m");
                m7 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass7 myTaskClass7 = new MyTaskClass7(m7);
                myTaskClass7.N();
                //N = Math.Pow(m7, 2) + 2.8 * Math.Abs(2.8) + 0.55;
                //Console.WriteLine($"N = {N}");
                break;

            case 8:

                double T, y8;

                Console.WriteLine("Введите число y");
                y8 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass8 myTaskClass8 = new MyTaskClass8(y8);
                myTaskClass8.T();
                //T = Math.Sqrt(Math.Abs(6 * Math.Pow(y8, 2) - 0.1 * y8 + 4));
                //Console.WriteLine($"T = {T}");
                break;

            case 9:

                double V, y9, x9;

                Console.WriteLine("Введите число у");
                y9 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число x");
                x9 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass9 myTaskClass9 = new MyTaskClass9(y9, x9);
                myTaskClass9.V();
                //V = Math.Log(y9 + 0.95) + Math.Sin(Math.Pow(x9, 4));
                //Console.WriteLine($"V = {V}");
                break;

            case 10:

                double U, e10, k10, x10, y10;

                Console.WriteLine("Введите число e");
                e10 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число k");
                k10 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число x");
                x10 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число y");
                y10 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass10 myTaskClass10 = new MyTaskClass10(e10, k10, x10, y10);
                myTaskClass10.U();
                //U = Math.Pow(e10, y10) + 7.355 * Math.Pow(k10, 2) + Math.Pow(Math.Sin(x10), 2);
                //Console.WriteLine($"U = {U}");

                break;

            case 11:

                double S, y11, x11;

                Console.WriteLine("Введите число y");
                y11 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число x");
                x11 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass11 myTaskClass11 = new MyTaskClass11(y11, x11);
                myTaskClass11.S();
                //S = 9.756 * Math.Pow(y11, 7) + 2* Math.Tan(x11);
                //Console.WriteLine($"S = {S}");

                break;

            case 12:
                double K12, t12, x12;

                Console.WriteLine("Введите число t");
                t12 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число x");
                x12 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass12 myTaskClass12 = new MyTaskClass12(t12, x12);
                myTaskClass12.K();
                //K12 = 7 * Math.Pow(t12, 2) + 3 * Math.Sin(Math.Pow(x12, 3)) + 9.2;
                //Console.WriteLine($"K = {K12}");
                break;

            case 13:

                double E, y13;

                Console.WriteLine("Введите число y");
                y13 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass13 myTaskClass13 = new MyTaskClass13(y13);
                myTaskClass13.E();
                //E = Math.Sqrt(Math.Abs(3 * Math.Pow(y13, 2) + 0.5 * y13 + 4));
                //Console.WriteLine($"E = {E}");
                break;

            case 14:

                double R14, y14, e14, x14;

                Console.WriteLine("Введите число y");
                y14 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число e");
                e14 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите число x");
                x14 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass14 myTaskClass14 = new MyTaskClass14(y14, e14, x14);
                myTaskClass14.R14();
                //R14 = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y14), 2) + 6.835) + Math.Pow(e14, x14));
                //Console.WriteLine($"R = {R14}");
                break;

            case 15:
                double H, y15;

                Console.WriteLine("Введите число y");
                y15 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass15 myTaskClass15 = new MyTaskClass15(y15);
                myTaskClass15.H();
                //H = Math.Sin(Math.Pow(y15, 2)) + 2.8 * y15 + Math.Sqrt(Math.Abs(y15));
                //Console.WriteLine($"H = {H}");
                break;

            case 16:
                double S20, y16;

                Console.WriteLine("Введите значение y:");
                y16 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass16 myTaskClass16 = new MyTaskClass16(y16);
                myTaskClass16.S();
                //S20 = Math.Sqrt(Math.Cos(4 * Math.Pow(y16, 2) + 7.151));
                //Console.WriteLine($"S = {S20}");

                break;

            case 17:

                double N17, y17;

                Console.WriteLine("Введите значение y:");
                y17 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass17 myTaskClass17 = new MyTaskClass17(y17);
                myTaskClass17.N();
                //N = 3 * Math.Pow(y17, 2) + Math.Sqrt(y17 + 1);
                //Console.WriteLine($"N = {N}");

                break;

            case 18:

                double Z18, y18;

                Console.WriteLine("Введите значение y:");
                y18 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass18 myTaskClass18 = new MyTaskClass18(y18);
                myTaskClass18.Z();
                //Z18 = 3 * Math.Pow(y18, 2) + Math.Sqrt(Math.Pow(y18, 3) + 1);
                //Console.WriteLine($"Z = {Z18}");

                break;

            case 19:

                double P19, n19, y19, g19;

                Console.WriteLine("Введите значение n:");
                n19 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y19 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение g:");
                g19 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass19 myTaskClass19 = new MyTaskClass19(n19, y19, g19);
                myTaskClass19.P();
                //P19 = n19 * Math.Sqrt(Math.Pow(y19, 3) + 1.09 * g19);
                //Console.WriteLine($"P = {P19}");

                break;

            case 20:

                double U20, e20, k, x20, y20;

                Console.WriteLine("Введите значение e:");
                e20 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение k:");
                k = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение x:");
                x20 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y20 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass20 myTaskClass20 = new MyTaskClass20(e20, k, x20, y20);
                myTaskClass20.U();

                //U = Math.Pow(e20, k + y20) + Math.Tan(x20) * Math.Sqrt(y20);
                //Console.WriteLine($"U = {U}");

                break;

            case 21:

                double P, e21, h, y21;

                Console.WriteLine("Введите значение e:");
                e21 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение h:");
                h = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Введите значение y:");
                y21 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass21 myTaskClass21 = new MyTaskClass21(e21, h, y21);
                myTaskClass21.P();

                //P = Math.Pow(e21, y21 + 5.5) + 9.1 * Math.Pow(h, 3);
                //Console.WriteLine($"P = {P}");

                break;

            case 22:

                double T22, u, y22, x22;

                Console.WriteLine("Введите значение u:");
                u = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y22 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение x:");
                x22 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass22 myTaskClass22 = new MyTaskClass22(u, y22, x22);
                myTaskClass22.T();

                //T = Math.Sin(2 * u)+ Math.Log(2 * Math.Pow(y22, 2) + Math.Sqrt(x22));
                //Console.WriteLine($"T = {T}");

                break;

            case 23:

                double G23, e23, y23, f;

                Console.WriteLine("Введите значение e:");
                e23 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y23 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение f:");
                f = Convert.ToDouble(Console.ReadLine());

                MyTaskClass23 myTaskClass23 = new MyTaskClass23(e23, y23, f);
                myTaskClass23.G();

                //G = Math.Pow(e23, 2 * y23) + Math.Sin(f);
                //Console.WriteLine($"G = {G}");

                break;

            case 24:

                double F, y24;

                Console.WriteLine("Введите значение y:");
                y24 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass24 myTaskClass24 = new MyTaskClass24(y24);
                myTaskClass24.F();

                //F = 2 * Math.Sin(0.214 * Math.Pow(y24, 5) + 1);
                //Console.WriteLine($"F = {F}");

                break;

            case 25:

                double G25, e25, y25, f25;

                Console.WriteLine("Введите значение e:");
                e25 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y25 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение f:");
                f25 = Convert.ToDouble(Console.ReadLine());



                MyTaskClass25 myTaskClass25 = new MyTaskClass25(e25, y25, f25);
                myTaskClass25.G();

                //G25 = Math.Pow(e25, 2 * y25) + Math.Sin(f25);
                //Console.WriteLine($"G = {G}");

                break;

            case 26:

                double Z, p26;

                Console.WriteLine("Введите значение p:");
                p26 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass26 myTaskClass26 = new MyTaskClass26(p26);
                myTaskClass26.Z();

                //Z = Math.Pow(Math.Sin(Math.Pow(p26, 2) + 0.4), 3);
                //Console.WriteLine($"Z = {Z}");

                break;

            case 27:

                double W, v, e27, y27, x27;

                Console.WriteLine("Введите значение v:");
                v = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение e:");
                e27 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y27 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение x:");
                x27 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass27 myTaskClass27 = new MyTaskClass27(v, e27, y27, x27);
                myTaskClass27.W();

                //W = 1.03 * v + Math.Pow(e27, 2 * y27) + Math.Tan(Math.Abs(x27));
                //Console.WriteLine($"W = {W}");

                break;

            case 28:

                double T28, e28, y28, h28;

                Console.WriteLine("Введите значение e:");
                e28 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y28 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение h:");
                h28 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass28 myTaskClass28 = new MyTaskClass28(e28, y28, h28);
                myTaskClass28.T();

                //T = Math.Pow(e28, y28 + h28) + Math.Sqrt(Math.Abs(6.4 * y28));
                //Console.WriteLine($"T = {T28}");

                break;

            case 29:

                double N29, y29;

                Console.WriteLine("Введите значение y:");
                y29 = Convert.ToDouble(Console.ReadLine());

                MyTaskClass29 myTaskClass29 = new MyTaskClass29(y29);
                myTaskClass29.N();

                //N = 3 * Math.Pow(y29, 2) + Math.Sqrt(Math.Abs(y29 + 1));
                //Console.WriteLine($"N = {N}");

                break;

            case 30:

                double W30, e30, y30, r;

                Console.WriteLine("Введите значение e:");
                e30 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение y:");
                y30 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите значение r:");
                r = Convert.ToDouble(Console.ReadLine());

                MyTaskClass30 myTaskClass30 = new MyTaskClass30(e30, y30, r);
                myTaskClass30.W();

                //W = Math.Pow(e30, y30 + r) + 7.2 * Math.Sin(r);
                //Console.WriteLine($"W = {W30}");

                break;

        }
    }


    }
