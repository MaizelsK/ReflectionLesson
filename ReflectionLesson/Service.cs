using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLesson
{
    public class Service
    {
        private bool isOk;

        public Guid Id { get; set; }

        public Service()
        {
            Console.WriteLine("Объект создан");
        }

        public void ToDo(int number, string str)
        {
            Console.WriteLine(str + number);
        }
    }
}
