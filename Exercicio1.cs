using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico.ModalGR.CMD;

public class Exercicio1
{
    public static (int countLower, int countUpper) CountLowerCase(string? input, char latter)
    {
        int countLower = 0;
        int countUpper = 0;

        char latterLowerCase = Char.ToLower(latter);
        char latterUpperCase = Char.ToUpper(latter);

        foreach (char c in input)
        {
            if (c == latterLowerCase)
            {
                countLower++;
            }
            if (c == latterUpperCase)
            {
                countUpper++;
            }
        }

        return (countLower, countUpper);
    }

}

