namespace Education
{
    partial class Students
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
            System.Windows.Forms.Label no_zkLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label grLabel;
            System.Windows.Forms.Label biogrLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.label1 = new System.Windows.Forms.Label();
            this.education_GazievaDataSet = new Education.Education_GazievaDataSet();
            this.students_GazievaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_GazievaTableAdapter = new Education.Education_GazievaDataSetTableAdapters.Students_GazievaTableAdapter();
            this.tableAdapterManager = new Education.Education_GazievaDataSetTableAdapters.TableAdapterManager();
            this.students_GazievaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.students_GazievaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_zkTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            this.grTextBox = new System.Windows.Forms.TextBox();
            this.biogrTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            no_zkLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            grLabel = new System.Windows.Forms.Label();
            biogrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_GazievaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GazievaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GazievaBindingNavigator)).BeginInit();
            this.students_GazievaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_zkLabel
            // 
            no_zkLabel.AutoSize = true;
            no_zkLabel.Location = new System.Drawing.Point(31, 140);
            no_zkLabel.Name = "no_zkLabel";
            no_zkLabel.Size = new System.Drawing.Size(134, 13);
            no_zkLabel.TabIndex = 2;
            no_zkLabel.Text = "Номер зачетной книжки:";
            no_zkLabel.Click += new System.EventHandler(this.no_zkLabel_Click);
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(106, 185);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 4;
            famLabel.Text = "Фамилия:";
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Location = new System.Drawing.Point(124, 226);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(32, 13);
            imLabel.TabIndex = 6;
            imLabel.Text = "Имя:";
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(108, 266);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(57, 13);
            otLabel.TabIndex = 8;
            otLabel.Text = "Отчество:";
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Location = new System.Drawing.Point(77, 309);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(88, 13);
            specLabel.TabIndex = 10;
            specLabel.Text = "Специальность:";
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Location = new System.Drawing.Point(135, 355);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(34, 13);
            kursLabel.TabIndex = 12;
            kursLabel.Text = "Курс:";
            // 
            // grLabel
            // 
            grLabel.AutoSize = true;
            grLabel.Location = new System.Drawing.Point(120, 406);
            grLabel.Name = "grLabel";
            grLabel.Size = new System.Drawing.Size(45, 13);
            grLabel.TabIndex = 14;
            grLabel.Text = "Группа:";
            // 
            // biogrLabel
            // 
            biogrLabel.AutoSize = true;
            biogrLabel.Location = new System.Drawing.Point(99, 454);
            biogrLabel.Name = "biogrLabel";
            biogrLabel.Size = new System.Drawing.Size(66, 13);
            biogrLabel.TabIndex = 16;
            biogrLabel.Text = "Биография:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(189, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // education_GazievaDataSet
            // 
            this.education_GazievaDataSet.DataSetName = "Education_GazievaDataSet";
            this.education_GazievaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_GazievaBindingSource
            // 
            this.students_GazievaBindingSource.DataMember = "Students_Gazieva";
            this.students_GazievaBindingSource.DataSource = this.education_GazievaDataSet;
            // 
            // students_GazievaTableAdapter
            // 
            this.students_GazievaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_GazievaTableAdapter = this.students_GazievaTableAdapter;
            this.tableAdapterManager.Subjects_GazievaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Education.Education_GazievaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_GazievaTableAdapter = null;
            // 
            // students_GazievaBindingNavigator
            // 
            this.students_GazievaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.students_GazievaBindingNavigator.BindingSource = this.students_GazievaBindingSource;
            this.students_GazievaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.students_GazievaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.students_GazievaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.students_GazievaBindingNavigatorSaveItem});
            this.students_GazievaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.students_GazievaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.students_GazievaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.students_GazievaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.students_GazievaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.students_GazievaBindingNavigator.Name = "students_GazievaBindingNavigator";
            this.students_GazievaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.students_GazievaBindingNavigator.Size = new System.Drawing.Size(940, 25);
            this.students_GazievaBindingNavigator.TabIndex = 1;
            this.students_GazievaBindingNavigator.Text = "bindingNavigator1";
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
            // students_GazievaBindingNavigatorSaveItem
            // 
            this.students_GazievaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.students_GazievaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("students_GazievaBindingNavigatorSaveItem.Image")));
            this.students_GazievaBindingNavigatorSaveItem.Name = "students_GazievaBindingNavigatorSaveItem";
            this.students_GazievaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.students_GazievaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.students_GazievaBindingNavigatorSaveItem.Click += new System.EventHandler(this.students_GazievaBindingNavigatorSaveItem_Click);
            // 
            // no_zkTextBox
            // 
            this.no_zkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "no_zk", true));
            this.no_zkTextBox.Location = new System.Drawing.Point(171, 133);
            this.no_zkTextBox.Name = "no_zkTextBox";
            this.no_zkTextBox.Size = new System.Drawing.Size(135, 20);
            this.no_zkTextBox.TabIndex = 3;
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(171, 178);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(135, 20);
            this.famTextBox.TabIndex = 5;
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "im", true));
            this.imTextBox.Location = new System.Drawing.Point(171, 219);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(135, 20);
            this.imTextBox.TabIndex = 7;
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "ot", true));
            this.otTextBox.Location = new System.Drawing.Point(171, 259);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(135, 20);
            this.otTextBox.TabIndex = 9;
            // 
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(171, 302);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(135, 20);
            this.specTextBox.TabIndex = 11;
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "kurs", true));
            this.kursTextBox.Location = new System.Drawing.Point(171, 352);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(135, 20);
            this.kursTextBox.TabIndex = 13;
            // 
            // grTextBox
            // 
            this.grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "gr", true));
            this.grTextBox.Location = new System.Drawing.Point(171, 399);
            this.grTextBox.Name = "grTextBox";
            this.grTextBox.Size = new System.Drawing.Size(135, 20);
            this.grTextBox.TabIndex = 15;
            // 
            // biogrTextBox
            // 
            this.biogrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GazievaBindingSource, "biogr", true));
            this.biogrTextBox.Location = new System.Drawing.Point(171, 447);
            this.biogrTextBox.Name = "biogrTextBox";
            this.biogrTextBox.Size = new System.Drawing.Size(135, 20);
            this.biogrTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(biogrLabel);
            this.Controls.Add(this.biogrTextBox);
            this.Controls.Add(grLabel);
            this.Controls.Add(this.grTextBox);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursTextBox);
            this.Controls.Add(specLabel);
            this.Controls.Add(this.specTextBox);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(no_zkLabel);
            this.Controls.Add(this.no_zkTextBox);
            this.Controls.Add(this.students_GazievaBindingNavigator);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Students";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_GazievaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GazievaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GazievaBindingNavigator)).EndInit();
            this.students_GazievaBindingNavigator.ResumeLayout(false);
            this.students_GazievaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_GazievaDataSet education_GazievaDataSet;
        private System.Windows.Forms.BindingSource students_GazievaBindingSource;
        private Education_GazievaDataSetTableAdapters.Students_GazievaTableAdapter students_GazievaTableAdapter;
        private Education_GazievaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator students_GazievaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton students_GazievaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_zkTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
        private System.Windows.Forms.TextBox grTextBox;
        private System.Windows.Forms.TextBox biogrTextBox;
        private System.Windows.Forms.Button button1;
    }
}