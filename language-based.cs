// Menu - todo.md

// []- While

using System;

namespace MyApp
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 4)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}


// []- Do while

using System;

 namespace MyApp
{
  public void Main(string[] args)
  {
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 4);
  }
}

// []- For loop

using System;

namespace MyApp
{
  public void Main(string[] args)
  {
    for (int i = 0; i < 4; i++)
    {
      Console.WriteLine(i);
    }
  }
}

// []- Array

using System;

namespace MyApp
{
  public void Main(string[] args)
  {
    int[] array = new int[5];
    array[2];
  }
}


// []- 4 pillars of OOP

// -----ABSTRACTION -----
// To abstract something away, to hide away the implementation.
// for eg; Lets take an example of coffee machine.
// There are 2 ways we can implement this, with abstraction and without abstraction.

// 1st with abstraction
// Have a button with the title, "Make coffee"

// 2nd without abstraction
// Have a button with the title, "Boil the water"
// Have a button with the title, "Add 1 spoon coffee powder"
// Have a button with the title, "Pour it in cup"
// Have a button with the title, "Wash the utensils"


// -----Inheritance-----
// Inheritance means you are taking some qualities from other.
// In programming terms you have 2 classes one is parent class from whom you inherit properties,
// & base/child class to where you inherit properties.
// Animal eg

// Types
// Single, Multiple(not c# supported), multilevel, hiearchical
// Multivel - Grandpa, Father:Grandpa, You:Father
// Hiearchical - Animal, Dog:Animal, Cat:Animal --2 base derives from single parent class.


// -----Encapsulation-----
// Encapsulate is a concept where we bundle data, methods into a single unit.
// Here we also control access using getters and setters.


// -----Polymorphism-----
// Polymorphism is a concept of many forms, where a single name or action can be used
// for different tasks.

// Types
// Compile time (Overloading): Same name different behaviours eg; Int a,b and Int a,b,c
// Run-time (Overriding): Where we modify the implementation of the method.


// []- Value type vs Reference type
// Value type variables store data directly in its memory location.
// int a = 10;
// int b = a;
// b = 20;
// print a -- 10
// print b -- 20

// Reference type store a reference/address that points to the actual data.
// MyClass{
// public int Value {get; set;}
// }
// MyClass x = new MyClass();
// x.Value = 10;
// MyClass y = x;
// y.Value = 20;
// Print x -- 20;
// Print y -- 20;
