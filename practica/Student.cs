using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    class Student
    {
        public int idStudent { get; set; }
        public string fisrtName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string genero { get; set; }

        //crear la collecion de datos
        public static List<Student> GetStudent()
        {
            List<Student> student = new List<Student>
            {
                new Student { idStudent=1001, fisrtName="Ana", lastName="Flores",age=22, genero="femenino"},
                new Student { idStudent=1002, fisrtName="Luis", lastName="Martines",age=21, genero="masculino"},
                new Student { idStudent=1003, fisrtName="Alex", lastName="Soto",age=23, genero="masculino"},
                new Student { idStudent=1004, fisrtName="Jorge", lastName="Navarrete",age=31, genero="masculino"},
                new Student { idStudent=1005, fisrtName="Pedro", lastName="Bonilla",age=16,genero="masculino"},
                new Student { idStudent=1006, fisrtName="Maria", lastName="Araujo",age=10,genero="femenino"},
                new Student { idStudent=1007, fisrtName="Rene", lastName="Soto",age=20,genero="masculino"},
            };

            //valor de retorno, sera la lista de estuidantes
            return student;
        }
    }
}
