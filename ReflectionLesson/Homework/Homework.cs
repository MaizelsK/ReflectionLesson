using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLesson
{
    public class Homework
    {
        static public void Task1()
        {
            Type type = typeof(Console);

            var methods = type.GetMethods();

            foreach(var method in methods)
                Console.WriteLine(method.Name);

            Console.ReadLine();
        }

        static public void Task2()
        {
            Person person = new Person { Name = "Kirill", Age = 19, Phone = "1235846230" };

            Type type = typeof(Person);

            var properties = type.GetProperties();

            foreach (var proper in properties)
            {
                Console.Write(proper.Name + ": ");
                Console.WriteLine(proper.GetValue(person));
            }

            Console.ReadLine();
        }
    }
}
