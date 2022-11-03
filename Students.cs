using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Education.Education_GazievaDataSetTableAdapters;

namespace Education
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void students_GazievaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.students_GazievaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_GazievaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GazievaDataSet.Students_Gazieva". При необходимости она может быть перемещена или удалена.
            this.students_GazievaTableAdapter.Fill(this.education_GazievaDataSet.Students_Gazieva);

        }
      
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private StudentsTable studentstable;

        private void button1_Click(object sender, EventArgs e)
        {
            studentstable = new StudentsTable();
            studentstable.Visible = true;
        }

        private void no_zkLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
