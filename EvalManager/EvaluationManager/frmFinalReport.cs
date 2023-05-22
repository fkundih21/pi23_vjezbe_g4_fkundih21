using EvaluationManager.Models;
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
    public partial class frmFinalReport : Form
    {
        public frmFinalReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<StudentReportView> GenerateStudentReport()
        {
            var allStudents = StudentRepository.GetStudents();
            var examReport = new List<StudentReportView>();
            foreach (var student in allStudents)
            {
                if (student.HasSignature()== true)
                {
                    var examReport = new StudentReportView(student);
                    examReports.Add(examReport);
                }
            }return examReport;
        }

        private void frmFinalReport_Load(object sender, EventArgs e)
        {
            var results = GenerateStudentReport();
            dgvResults.DataSource = results;
    }
}
