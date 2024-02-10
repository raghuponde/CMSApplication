using System;
using System.Collections.Generic;
using CMSModel;
namespace CMSApplication
{


  public class Program
  {
    static List<Student> studlist  = new List<Student>();

    
    public   static void Main(string[] args)
    {

    
    Console.WriteLine("Hellowssssfjndfkjdn nd  ");
      studlist.Add(new Student { Id = 101, Name = "Kirankumarbhai"});
     
      

      studlist.Add(new Student { Id = 104, Name = "mahesh raine111" });

      studlist.Add(new Student { Id = 105, Name = "mahesh raine111" });
      
      foreach (Student st in studlist)
      {
        Console.WriteLine("{0}--{1}", st.Id, st.Name);
      }


    }



  }
}


