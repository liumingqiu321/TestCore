using System;
using System.Threading.Tasks;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public async Task<string> GetData()
        {
            try
            {
                var data = Task.Run(() => { return "1234556"; });
                return $"{await data}";
            }
            catch(Exception ex)
            {
                return "";
            }
        }

        public async Task<string> GetDataLa() =>await Task.Run(() => { return "12345678"; });
    }
}
