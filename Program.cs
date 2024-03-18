using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace многочлены
{
    class Mnogoclen
    {
        int stepen;
        int[] koef;
        public Mnogoclen(int stepen, int[] koef)
        {
            this.stepen = stepen;
            this.koef = koef;
        }
        public Mnogoclen Add(Mnogoclen b)
        {
            int i;
            int MaxDlina = Math.Max(koef.Length, b.koef.Length);
            int[] temp = new int[MaxDlina];
            for (i = 0; i < MaxDlina; i++)
            {
                if (koef.Length-1 < i)
                {
                    temp[i] = b.koef[i];
                }
                else if (b.koef.Length-1 < i)
                {
                    temp[i] = koef[i];
                }
                else
                {
                    temp[i] = koef[i] + b.koef[i];
                }
            }
            Mnogoclen result = new Mnogoclen(temp.Length-1,temp);
            return result;
        }

        public Mnogoclen Minus(Mnogoclen b)
        {
            int i;
            int MaxDlina = Math.Max(koef.Length, b.koef.Length);
            int[] temp = new int[MaxDlina];
            for (i = 0; i < MaxDlina; i++)
            {
                if (koef.Length - 1 < i)
                {
                    temp[i] = b.koef[i];
                }
                else if (b.koef.Length - 1 < i)
                {
                    temp[i] = koef[i];
                }
                else
                {
                    temp[i] = koef[i] - b.koef[i];
                }
            }
            Mnogoclen result = new Mnogoclen(temp.Length - 1, temp);
            return result;
        }

        public Mnogoclen Proizved(Mnogoclen b)
        {
            int i;
            int MaxDlina = Math.Max(koef.Length, b.koef.Length);
            int[] temp = new int[MaxDlina];
            for (i = 0; i < MaxDlina; i++)
            {
                if (koef.Length - 1 < i)
                {
                    temp[i] = b.koef[i];
                }
                else if (b.koef.Length - 1 < i)
                {
                    temp[i] = koef[i];
                }
                else
                {
                    temp[i] = koef[i] + b.koef[i];

                }
            }
            Mnogoclen result = new Mnogoclen(temp.Length - 1, temp);
            return result;
        }

        public string Print()
        {
            int i;
            string result= koef[0].ToString();
            for(i=1;i<koef.Length-1;i++)
            {
                if (koef[i] >= 0)
                {
                    result += "+";
                }
                result += (koef[i] + "x^"+i);
            }
            if (koef[koef.Length - 1] >= 0)
            {
                result += "+";
            }
            result += (koef[koef.Length - 1] + "x^" + i);
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = new int[] {2, 4, 5 };
            int[] arrayB = new int[] { 7, 1, -8 };
            Mnogoclen a = new Mnogoclen(arrayA.Length-1, arrayA);
            Mnogoclen b = new Mnogoclen(arrayB.Length - 1, arrayB);
            Mnogoclen Sum = a.Add(b);
            Mnogoclen Minus= a.Minus(b);
            Console.WriteLine(a.Print());
            Console.WriteLine(b.Print());
            Console.WriteLine("сложение: " +  Sum.Print());
            Console.WriteLine("вычитание: " + Minus.Print());
            
        }
    }
}
