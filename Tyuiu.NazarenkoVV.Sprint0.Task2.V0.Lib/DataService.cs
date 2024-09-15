using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.NazarenkoVV.Sprint0.Task1.V0.Lib
{
    public class DataService
    {
        public static string GetMessage(string name)
        {
            return $"Привет..., {name}";
        }
    }
}