using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Backup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // настройки работы программы
            Backup deserialization = new Backup();
            Log_Input log_input = new Log_Input();
            log_input.Output_console(true);// выбор вывода логировня в консоль
            log_input.Output_file(true);// выбор вывода логировня в файл
            log_input.Type_Loggers(Type_Input_Loggers.Debug);// выбор уровня логировня
            //void Output_Test_String()
            //{
            //    string message = "Тестовое сообщение";
                 
            //    log_input.Error(message);
            //    log_input.Info(message);
            //    log_input.Debug(message);
            //    Console.ReadKey();
            //}
            //Output_Test_String();
            //string message = "Тестовое сообщение";
            //log_input.Debug(message);
            //Console.ReadKey();
            deserialization.Zip(deserialization.Desser_Json());
        }
    }
}
