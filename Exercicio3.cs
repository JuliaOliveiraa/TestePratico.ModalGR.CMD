using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico.ModalGR.CMD;

public class Exercicio3
{
    public static (List<string> strings, List<double> numeros) SeparateByComma(string? dados)
    {
        List<string> strings = new List<string>();
        List<double> numeros = new List<double>();

        string[] valores = dados.Split(',');

        foreach (string valor in valores)
        {
            if (double.TryParse(valor.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double numero))
            {
                numeros.Add(numero);
            }
            else
            {
                strings.Add(valor.Trim());
            }
        }

        return (strings, numeros);
    }

}

