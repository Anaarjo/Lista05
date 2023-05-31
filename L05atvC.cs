/*c) Verifique se uma lista está vazia.*/

using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
      
      var students = new List<Student>() { 
                /*new Student(){ Id = 1, Name="Bill" },
                new Student(){ Id = 2, Name="Steve" },
                new Student(){ Id = 3, Name="Ram" },
                new Student(){ Id = 4, Name="Abdul" },
				new Student(){ Id = 5, Name="Bill" }*/
		};
		// vazia
    string mensagem = students.Count == 0 ? "A lista está vazia" : "A lista contém elementos";
      Console.WriteLine(mensagem);
		
	}
}

public class Student
{ 
	public int Id { get; set; }
	public string Name { get; set; }
}
    
