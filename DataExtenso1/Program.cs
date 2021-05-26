using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtenso
{
    public class Program
    {
        static CalculaData calculaData = new CalculaData();

        static void Main(string[] args)
        {
            calculaData.Data();
            Console.ReadKey();            
        }
    }
}
