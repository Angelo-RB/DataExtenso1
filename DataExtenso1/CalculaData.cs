using System;
using System.Collections.Generic;
using System.Text;

namespace DataExtenso
{
    public class CalculaData
    {
        public void Data()
        {
            TimeSpan result;

            DateTime Data1 = DateTime.Now;
            DateTime Data2 = DateTime.Parse("2/9/2012 10:10:11");
            result = Data1 - Data2;

            Console.WriteLine(result.Days / 30 / 12 + " Anos");
            Console.WriteLine(result.Days / 30 + " Meses");
            Console.WriteLine(result.Days + " Dias");
            Console.WriteLine(result.Hours + " Horas");
            Console.WriteLine(result.Minutes + " Minutos");
            Console.WriteLine(result.Seconds + " Segundos");

            //-----------------------------------Faltou Mês e ano-------------------------------------------------------------------

            //DateTime centuryBegin = new DateTime(2021, 01, 1);
            //DateTime currentDate = DateTime.Now;

            //long elapsedTicks = currentDate.Ticks - centuryBegin.Ticks;
            //TimeSpan elapsedSpan = new TimeSpan(elapsedTicks);

            //Console.WriteLine("O tempo decorrido de {0:f} até " + centuryBegin,
            //                   currentDate);

            //Console.WriteLine(" É de {0:N0} dias, {1} horas, {2} minutos, {3} segundos",
            //                  elapsedSpan.Days, elapsedSpan.Hours,
            //                  elapsedSpan.Minutes, elapsedSpan.Seconds);

            //---------------------------------Faltou Mês,ano,hora,minuto e segundo--------------------------------------------------

            //DateTime data = DateTime.Now;
            //DateTime periodo = data.AddMonths(-5);

            //String diff2 = (data - periodo).TotalDays.ToString();

            //Console.WriteLine(diff2);

            //Console.ReadLine();

            //--------------------------------Faltou Mês,ano,hora,minuto e segundo--------------------------------------------------

            //string sDataHoraAtual = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //Console.WriteLine(sDataHoraAtual);

            //DateTime today = DateTime.Now;
            //DateTime answer = today.AddDays(-2);
            //Console.WriteLine("Hoje: {0:dddd}", today);
            //Console.WriteLine("====: {0:dddd}", answer);

            //----------------------------------------------------------------------------------------------------------------------
        }
    }
}
