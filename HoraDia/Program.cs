using System;

namespace HoraDia
{
    class Program
    {
        //Mostrar aqui um pouco do que vimos com date time, alguns casos mais comuns para facilitar
        //A manipulação 

        static void Main(string[] args)
        {
            //Quantos dias tem o mês 2 do ano 2020?
            Console.Clear();
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            //Hoje é horário de verão?    
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

            Console.WriteLine(IsWeekDay(DateTime.Now.DayOfWeek));
        }

        //ENUM dos possíveis dias da semana.
        static bool IsWeekDay(DayOfWeek today)
        {
            //      HOJE    É IGUAL A SÁBADO    OU IGUAL A DOMINGO?
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }
    }
}