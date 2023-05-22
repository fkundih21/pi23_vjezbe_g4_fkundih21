using EvaluationManager.Models;
using EvaluationManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManager
{
    public partial class dgvStudents : Form
    {
        public dgvStudents()
        {
            InitializeComponent();
        }

        private void dgvStudents_Load(object sender, EventArgs e)
        {
            Show_Students();
        }

        private void Show_Students()
        {
            List<Student> students = StudentRepository.GetStudents();
            dgvStudents.DataSource == students;
        }

        private void dgvStudents_Load_1(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var form = new frmFinalReport();
            form.ShowDialog();
        }
    }

}