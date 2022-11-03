using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education
{
    public partial class Uspev : Form
    {
        public Uspev()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Uspev_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GazievaDataSet.Subjects_Gazieva". При необходимости она может быть перемещена или удалена.
            this.subjects_GazievaTableAdapter.Fill(this.education_GazievaDataSet.Subjects_Gazieva);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GazievaDataSet.Uspev_Gazieva". При необходимости она может быть перемещена или удалена.
            this.uspev_GazievaTableAdapter.Fill(this.education_GazievaDataSet.Uspev_Gazieva);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GazievaDataSet.Students_uspev". При необходимости она может быть перемещена или удалена.
            this.students_uspevTableAdapter.Fill(this.education_GazievaDataSet.Students_uspev);

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void students_uspevBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
