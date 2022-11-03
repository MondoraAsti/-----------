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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void subjects_GazievaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjects_GazievaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.education_GazievaDataSet);

        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "education_GazievaDataSet.Subjects_Gazieva". При необходимости она может быть перемещена или удалена.
            this.subjects_GazievaTableAdapter.Fill(this.education_GazievaDataSet.Subjects_Gazieva);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deptLabel_Click(object sender, EventArgs e)
        {
                    }
    }
}
