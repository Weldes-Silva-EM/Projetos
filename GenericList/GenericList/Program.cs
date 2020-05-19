using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Calculator4<T>
    {
        public void Add(T input) { }
    }
    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {


            Calculator4<int> list1 = new Calculator4<int>();
            list1.Add(1);


            Calculator4<string> List2 = new Calculator4<string>();
            List2.Add("Pessoa");

            Calculator4<ExampleClass> list3 = new Calculator4<ExampleClass>();
            list3.Add(new ExampleClass());


            Console.ReadLine();

        }
    }
}

