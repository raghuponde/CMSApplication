using System;
using System.Collections.Generic;
using CMSModel;
namespace CMSApplication
{


  public class Program
  {
    static List<Student> studlist = new List<Student>();

    
    public   static void Main(string[] args)
    {

    

      studlist.Add(new Student { Id = 101, Name = "Kirankumarbhai"});
      studlist.Add(new Student { Id = 102, Name = "Sureshraine" });
       studlist.Add(new Student { Id = 103, Name = "mahesh" });
      
      
      foreach (Student st in studlist)
      {
        Console.WriteLine("{0}--{1}", st.Id, st.Name);
      }


    }



  }
}


