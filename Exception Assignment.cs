using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    List<int> l = new List<int>();
    l.Add(7);
    l.Add(29);
    l.Add(92);
    l.Add(9);
    l.Add(10);
    int num,i;
    Console.WriteLine("Enter a number to divide: ");
    num=Convert.ToInt32(Console.ReadLine());
    for(i=0;i<l.Count;i++){
        l[i]=l[i]/num;
    }
    Console.WriteLine("After Division: ");
    for(i=0;i<l.Count;i++){
        Console.WriteLine(l[i]);
    }
  }
}