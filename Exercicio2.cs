using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico.ModalGR.CMD;

public class Exercicio2
{
    public static int[] FindRepeatedNumbers(int[] a, int[] b)
    {
        HashSet<int> repeatedNumbers = new HashSet<int>();

        foreach (int number in a)
        {
            if (Array.IndexOf(b, number) != -1 && !repeatedNumbers.Contains(number))
            {
                repeatedNumbers.Add(number);
            }
        }

        return repeatedNumbers.ToArray();
    }
}

