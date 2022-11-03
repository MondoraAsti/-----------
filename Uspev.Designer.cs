namespace Education
{
    partial class Uspev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gruppaLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label ocenkaLabel;
            System.Windows.Forms.Label nameLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uspev));
            this.label1 = new System.Windows.Forms.Label();
            this.education_GazievaDataSet = new Education.Education_GazievaDataSet();
            this.students_uspevBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_uspevTableAdapter = new Education.Education_GazievaDataSetTableAdapters.Students_uspevTableAdapter();
            this.tableAdapterManager = new Education.Education_GazievaDataSetTableAdapters.TableAdapterManager();
            this.students_uspevBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.students_uspevBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gruppaTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uspev_GazievaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_GazievaTableAdapter = new Education.Education_GazievaDataSetTableAdapters.Uspev_GazievaTableAdapter();
            this.ocenkaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subjects_GazievaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_GazievaTableAdapter = new Education.Education_GazievaDataSetTableAdapters.Subjects_GazievaTableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            gruppaLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ocenkaLabel = new System.Windows.Forms.Label();
            nameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_GazievaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_uspevBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_uspevBindingNavigator)).BeginInit();
            this.students_uspevBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_GazievaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GazievaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gruppaLabel
            // 
            gruppaLabel.AutoSize = true;
            gruppaLabel.Location = new System.Drawing.Point(288, 151);
            gruppaLabel.Name = "gruppaLabel";
            gruppaLabel.Size = new System.Drawing.Size(45, 13);
            gruppaLabel.TabIndex = 4;
            gruppaLabel.Text = "Группа:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(301, 294);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 10;
            dataLabel.Text = "дата:";
            // 
            // ocenkaLabel
            // 
            ocenkaLabel.AutoSize = true;
            ocenkaLabel.Location = new System.Drawing.Point(290, 242);
            ocenkaLabel.Name = "ocenkaLabel";
            ocenkaLabel.Size = new System.Drawing.Size(48, 13);
            ocenkaLabel.TabIndex = 11;
            ocenkaLabel.Text = "Оценка:";
            // 
            // nameLabel1
            // 
            nameLabel1.AutoSize = true;
            nameLabel1.Location = new System.Drawing.Point(260, 195);
            nameLabel1.Name = "nameLabel1";
            nameLabel1.Size = new System.Drawing.Size(73, 13);
            nameLabel1.TabIndex = 12;
            nameLabel1.Text = "Дисциплина:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(309, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Успеваемость";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // education_GazievaDataSet
            // 
            this.education_GazievaDataSet.DataSetName = "Education_GazievaDataSet";
            this.education_GazievaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_uspevBindingSource
            // 
            this.students_uspevBindingSource.DataMember = "Students_uspev";
            this.students_uspevBindingSource.DataSource = this.education_GazievaDataSet;
            this.students_uspevBindingSource.CurrentChanged += new System.EventHandler(this.students_uspevBindingSource_CurrentChanged);
            // 
            // students_uspevTableAdapter
            // 
            this.students_uspevTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Students_GazievaTableAdapter = null;
            this.tableAdapterManager.Subjects_GazievaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Education.Education_GazievaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_GazievaTableAdapter = null;
            // 
            // students_uspevBindingNavigator
            // 
            this.students_uspevBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.students_uspevBindingNavigator.BindingSource = this.students_uspevBindingSource;
            this.students_uspevBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.students_uspevBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.students_uspevBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.students_uspevBindingNavigatorSaveItem});
            this.students_uspevBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.students_uspevBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.students_uspevBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.students_uspevBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.students_uspevBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.students_uspevBindingNavigator.Name = "students_uspevBindingNavigator";
            this.students_uspevBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.students_uspevBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.students_uspevBindingNavigator.TabIndex = 1;
            this.students_uspevBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // students_uspevBindingNavigatorSaveItem
            // 
            this.students_uspevBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.students_uspevBindingNavigatorSaveItem.Enabled = false;
            this.students_uspevBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("students_uspevBindingNavigatorSaveItem.Image")));
            this.students_uspevBindingNavigatorSaveItem.Name = "students_uspevBindingNavigatorSaveItem";
            this.students_uspevBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.students_uspevBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // gruppaTextBox
            // 
            this.gruppaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_uspevBindingSource, "gruppa", true));
            this.gruppaTextBox.Location = new System.Drawing.Point(342, 144);
            this.gruppaTextBox.Name = "gruppaTextBox";
            this.gruppaTextBox.Size = new System.Drawing.Size(136, 20);
            this.gruppaTextBox.TabIndex = 5;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.students_uspevBindingSource, "data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(342, 288);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 11;
            // 
            // uspev_GazievaBindingSource
            // 
            this.uspev_GazievaBindingSource.DataMember = "Uspev_Gazieva";
            this.uspev_GazievaBindingSource.DataSource = this.education_GazievaDataSet;
            // 
            // uspev_GazievaTableAdapter
            // 
            this.uspev_GazievaTableAdapter.ClearBeforeFill = true;
            // 
            // ocenkaMaskedTextBox
            // 
            this.ocenkaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_GazievaBindingSource, "ocenka", true));
            this.ocenkaMaskedTextBox.Location = new System.Drawing.Point(342, 239);
            this.ocenkaMaskedTextBox.Mask = "0";
            this.ocenkaMaskedTextBox.Name = "ocenkaMaskedTextBox";
            this.ocenkaMaskedTextBox.Size = new System.Drawing.Size(136, 20);
            this.ocenkaMaskedTextBox.TabIndex = 12;
            // 
            // subjects_GazievaBindingSource
            // 
            this.subjects_GazievaBindingSource.DataMember = "Subjects_Gazieva";
            this.subjects_GazievaBindingSource.DataSource = this.education_GazievaDataSet;
            // 
            // subjects_GazievaTableAdapter
            // 
            this.subjects_GazievaTableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GazievaBindingSource, "name", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.subjects_GazievaBindingSource, "name", true));
            this.nameComboBox.DataSource = this.subjects_GazievaBindingSource;
            this.nameComboBox.DisplayMember = "name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(342, 187);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(136, 21);
            this.nameComboBox.TabIndex = 13;
            this.nameComboBox.ValueMember = "name";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // studentComboBox
            // 
            this.studentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_GazievaBindingSource, "student", true));
            this.studentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.students_uspevBindingSource, "fio", true));
            this.studentComboBox.DataSource = this.students_uspevBindingSource;
            this.studentComboBox.DisplayMember = "fio";
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(342, 103);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(136, 21);
            this.studentComboBox.TabIndex = 14;
            this.studentComboBox.ValueMember = "fio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Фамилия:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Uspev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(nameLabel1);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(ocenkaLabel);
            this.Controls.Add(this.ocenkaMaskedTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(gruppaLabel);
            this.Controls.Add(this.gruppaTextBox);
            this.Controls.Add(this.students_uspevBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Uspev";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.Uspev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_GazievaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_uspevBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_uspevBindingNavigator)).EndInit();
            this.students_uspevBindingNavigator.ResumeLayout(false);
            this.students_uspevBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_GazievaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GazievaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_GazievaDataSet education_GazievaDataSet;
        private System.Windows.Forms.BindingSource students_uspevBindingSource;
        private Education_GazievaDataSetTableAdapters.Students_uspevTableAdapter students_uspevTableAdapter;
        private Education_GazievaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator students_uspevBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton students_uspevBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox gruppaTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.BindingSource uspev_GazievaBindingSource;
        private Education_GazievaDataSetTableAdapters.Uspev_GazievaTableAdapter uspev_GazievaTableAdapter;
        private System.Windows.Forms.MaskedTextBox ocenkaMaskedTextBox;
        private System.Windows.Forms.BindingSource subjects_GazievaBindingSource;
        private Education_GazievaDataSetTableAdapters.Subjects_GazievaTableAdapter subjects_GazievaTableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Label label2;
    }
}