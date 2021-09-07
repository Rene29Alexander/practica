using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica
{
    public partial class dgData : Form
    {
        public dgData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btnfill_Click(object sender, EventArgs e)
        {
           



        }
        
        private List<Student> selectAllData()
        {
            //crear la consulta
            List<Student> result = (
                                    from student in Student.GetStudent()
                                    select new Student()
                                    {
                                        idStudent = student.idStudent,
                                        fisrtName = student.fisrtName,
                                        lastName = student.lastName,
                                        age = student.age,
                                        genero = student.genero


                                    }
                ).ToList();
            //retorna el resultado de la consulta
            return result;
        }

        private void dgData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgData2.Columns.Add("idStudent", "CODIGO");
            dgData2.Columns.Add("fisrtName", "NOMBRE");
            dgData2.Columns.Add("lastName", "APELLIDO");
            dgData2.Columns.Add("age", "EDAD");
            dgData2.Columns.Add("genero", "GENERO");

            foreach (var student in selectAllData())
            {
                dgData2.Rows.Add(student.idStudent, student.fisrtName, student.lastName, student.age,
                    student.genero);

            }

        }
    }
}
