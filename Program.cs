using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HomeworkList
{
    class Program
    {
        static bool EnterOut(bool EnterOut = true)
        {
            bool res = true;
            if (EnterOut)
            {
                Console.Write("Вошел\t");
                return res;
            }
            else
            {
                Console.Write("Вышел\t");
                res = false;
            }
            return res;
        }
        static void Print(string Office, DateTime date, bool _enterOut)
        {
            Console.WriteLine("{0}\t{1}\t{2}", date, Office, EnterOut(_enterOut));
        }
        static void File(StreamWriter myStream, string Office, DateTime date, bool _enterOut)
        {
            myStream.WriteLine("{0}\t{1}\t{2}", date, Office);
        }
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string myLog = @"\List.txt";
            StreamWriter myStream = new StreamWriter(path + myLog);
            Console.WriteLine("Путь к папке МоиДокументы текущего пользователья: {0}", path);

            List<string> Office = new List<string>() {"Ann", "John", "Bob", "Kate", "Den"};
            DateTime date = DateTime.Now;
            bool Enter = true, Out = false;

            Print(Office[0], date, Enter);
            Print(Office[1], date, Out);
            Print(Office[2], date, Out);
            Print(Office[3], date, Enter);
            Print(Office[4], date, Enter);

            myStream.WriteLine("Вошел\t{0}\t{1}", date, Office[0]);
            myStream.WriteLine("Вышел\t{0}\t{1}", date, Office[1]);
            myStream.WriteLine("Вышел\t{0}\t{1}", date, Office[2]);
            myStream.WriteLine("Вошел\t{0}\t{1}", date, Office[3]);
            myStream.WriteLine("Вошел\t{0}\t{1}", date, Office[4]);

            myStream.Close();
        }
    }
}
