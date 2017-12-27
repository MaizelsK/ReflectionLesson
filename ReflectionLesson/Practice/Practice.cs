using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionLesson
{
    public class Practice
    {
        static public void Task1()
        {
            string str = "Kirill\nMaizels";

            Type type = typeof(String);

            MethodInfo info = type.GetMethod("Substring", new Type[] { typeof(int) });

            Console.WriteLine(info.Invoke(str, new object[] { 7 }));

            Console.ReadLine();
        }

        static public void Task2()
        {
            Type type = typeof(List<>);

            var info = type.GetMembers();

            foreach (var inf in info)
                if (inf.Name == ".ctor") Console.WriteLine(inf.Name);

            Console.ReadLine();
        }
    }
}
