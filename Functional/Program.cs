using BasicProgram.functional;
using System;

namespace BasicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            
            {
                Console.WriteLine("1.Replacestring\n2.LeapYear\n3.Flipcoin\n4.Powerof2\n5.HarmonicNumber\n6.Factor\n7.Gambler\n8.CouponNumber\n9.Two_D_Array\n10.Summofiinteger\n11.QudraticEquation\n12.Distance\n13.Stopwatch\n14.Windchill\n15.Tic-Tac-Toe");
                Console.WriteLine("Enter your choice :");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ReplaceString rs = new ReplaceString();
                        
                        rs.Run(); break;
                    case 2:
                        Leapyear lp = new Leapyear();
                        lp.Leap();
                        break;
                    case 3:
                        Flipcoin.Flip();
                       // fp.Flip();
                        break;
                    case 4:
                        Powerof2 pw = new Powerof2();
                        pw.power();
                        break;
                    case 5:
                        HarmonicNumber hm = new HarmonicNumber();
                        hm.Harmonic();
                        break;
                    case 6:
                       Factor fa = new Factor();
                            fa.fact();
                        break;
                    case 7:
                        Gambler ga = new Gambler();
                        ga.game();
                        break;
                    case 8:
                        CouponNumber cp = new CouponNumber();
                        cp.Coupan();
                          break;
                    case 9:
                        Two_D_Array tw = new Two_D_Array();
                        tw.Array();
                        break;
                    case 10:
                        Sumofinteger sm = new Sumofinteger();
                        sm.Sum();
                        break;
                    case 11:
                        QuadraticEquation qe = new QuadraticEquation();
                        qe.Qudratic();
                        break;
                    case 12:
                        Distance dt = new Distance();
                        dt.Calculate();
                        break;
                    case 13:
                        Stopwatch stp = new Stopwatch();
                        stp.stop();
                        break;
                    case 14:
                        WindChill chill = new WindChill();
                        chill.Wind();
                        break;
                    case 15:
                        Tic_Tac_Toe tic = new Tic_Tac_Toe();
                        tic.game();
                        break;
                    default:
                        Console.WriteLine("Invalid");

                        break;
                }


            }
        }

    }
}
