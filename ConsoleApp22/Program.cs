using System;
using System.Reflection;

namespace ConsoleApp22
{
    public class SomeClass
    {
        public string SomeText { get; set; }

        public int SomeInt { get; set; }
        public void SomeMethod(string text)
        {
            Console.WriteLine(text  + " " +SomeText);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            //VAR
            var sc = new SomeClass();
            sc.SomeText = "Jakis tekst";
            sc.SomeMethod("test");
            sc.SomeMethod("test");
            //sc = "asd";

            //Dynamic
            dynamic sc2 = new SomeClass();
            sc2.SomeText = "Jakis tekst2";
            sc2.SomeMethod("test2");
            Console.WriteLine(sc2.GetType());

            //sc2 = true;
            //Console.WriteLine(sc2.GetType());

            sc2 = "asd";
            Console.WriteLine(sc2[2]);
            Console.WriteLine(sc2.GetType());

            //sc2 = 1.2d;
            //Console.WriteLine(sc2/2);
            //Console.WriteLine(sc2.GetType());


            //Object
            object sc3 = new SomeClass();
            Console.WriteLine(sc3.GetType());
            ((SomeClass)sc3).SomeText = "Jakis tekst2";
            ((SomeClass)sc3).SomeMethod("test2");

            sc3 = "asd";
           // Console.WriteLine(sc3[2]);
            Console.WriteLine(sc3.GetType());


            Console.ReadLine();
        }

          //var sc = new SomeClass();
          //  sc.SomeText = "Jakis tekst";
          //  sc.SomeMethod("test");

          //  //var scType = sc.GetType();
          //  //var scType = typeof(SomeClass);

          //  var scType = Type.GetType("ConsoleApp22.SomeClass");
          //  object obj = Activator.CreateInstance(scType);

          //  PropertyInfo sTPropInfo = scType.GetProperty("SomeText");
          //  sTPropInfo.SetValue(obj, "TestowyText");
          //  //var actualValue = sTPropInfo.GetValue(sc);

          //  var sMMethodInfo = scType.GetMethod("SomeMethod");
          //  var @params =  sMMethodInfo.GetParameters();
          //  sMMethodInfo.Invoke(obj, new[] { "Jakis string" });
    }
}
