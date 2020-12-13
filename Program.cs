using System;
using System.Collections.Generic;

namespace _7.TelePolymorhism
{

    class Shape 
    {
    
    }
    class Rect : Shape  // class Rect inherites a class Shape
    {
      public string Name { get; set; }  //we create a property 
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            // Object obj = 5;  //Exmnpale obj accepts interger iteral!
            // List<int> list = new List<int>();
            IEnumerable<int> list = new List<int>();  //an Object inherites values of another Object
                                                      // IEnumerable is a interface that declares/ defines  one method -> GerEnumerator which returns  IEnumerator Interface
                                                      // this allows readonly access to a collection, then a collection that implements IEnumerable can be used with for each statement.
                                                      //
                                                      // Shape shape = new Rect();  //Object of a class Shape called shape -accepts values of onother class type. Rect
                                                      // this is becasue Rect somewhere in the code inherites the class Shape

            Rect rect = new Rect();
            Shape shape = new Rect();   //here come the POlymorhism //object of a parent class receives values of a Objects ot a child class ;
            // Object of a parent class type, can hold values of a Object of type child class ,  becasue child class inherites the parent class

        }
    }
}
