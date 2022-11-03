namespace Education
{
    partial class Subjects
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
            System.Windows.Forms.Label hrsLabel1;
            System.Windows.Forms.Label predm_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label deptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            this.label1 = new System.Windows.Forms.Label();
            this.education_GazievaDataSet = new Education.Education_GazievaDataSet();
            this.subjects_GazievaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_GazievaTableAdapter = new Education.Education_GazievaDataSetTableAdapters.Subjects_GazievaTableAdapter();
            this.tableAdapterManager = new Education.Education_GazievaDataSetTableAdapters.TableAdapterManager();
            this.subjects_GazievaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjects_GazievaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hrsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.predm_idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.deptMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            hrsLabel1 = new System.Windows.Forms.Label();
            predm_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_GazievaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GazievaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GazievaBindingNavigator)).BeginInit();
            this.subjects_GazievaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hrsLabel1
            // 
            hrsLabel1.AutoSize = true;
            hrsLabel1.Location = new System.Drawing.Point(260, 182);
            hrsLabel1.Name = "hrsLabel1";
            hrsLabel1.Size = new System.Drawing.Size(93, 13);
            hrsLabel1.TabIndex = 9;
            hrsLabel1.Text = "Объемы в часах:";
            // 
            // predm_idLabel
            // 
            predm_idLabel.AutoSize = true;
            predm_idLabel.Location = new System.Drawing.Point(260, 102);
            predm_idLabel.Name = "predm_idLabel";
            predm_idLabel.Size = new System.Drawing.Size(90, 13);
            predm_idLabel.TabIndex = 10;
            predm_idLabel.Text = "Идентификатор:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(314, 142);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "Имя:";
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.Location = new System.Drawing.Point(291, 238);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(55, 13);
            deptLabel.TabIndex = 12;
            deptLabel.Text = "Кафедра:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(347, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Предметы";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // education_GazievaDataSet
            // 
            this.education_GazievaDataSet.DataSetName = "Education_GazievaDataSet";
            this.education_GazievaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_GazievaTableAdapter = null;
            this.tableAdapterManager.Subjects_GazievaTableAdapter = this.subjects_GazievaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Education.Education_GazievaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_GazievaTableAdapter = null;
            // 
            // subjects_GazievaBindingNavigator
            // 
            this.subjects_GazievaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjects_GazievaBindingNavigator.BindingSource = this.subjects_GazievaBindingSource;
            this.subjects_GazievaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjects_GazievaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjects_GazievaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjects_GazievaBindingNavigatorSaveItem});
            this.subjects_GazievaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjects_GazievaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjects_GazievaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjects_GazievaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjects_GazievaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjects_GazievaBindingNavigator.Name = "subjects_GazievaBindingNavigator";
            this.subjects_GazievaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjects_GazievaBindingNavigator.Size = new System.Drawing.Size(747, 25);
            this.subjects_GazievaBindingNavigator.TabIndex = 1;
            this.subjects_GazievaBindingNavigator.Text = "bindingNavigator1";
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
            // subjects_GazievaBindingNavigatorSaveItem
            // 
            this.subjects_GazievaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjects_GazievaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjects_GazievaBindingNavigatorSaveItem.Image")));
            this.subjects_GazievaBindingNavigatorSaveItem.Name = "subjects_GazievaBindingNavigatorSaveItem";
            this.subjects_GazievaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjects_GazievaBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjects_GazievaBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjects_GazievaBindingNavigatorSaveItem_Click);
            // 
            // hrsMaskedTextBox
            // 
            this.hrsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GazievaBindingSource, "hrs", true));
            this.hrsMaskedTextBox.Location = new System.Drawing.Point(356, 175);
            this.hrsMaskedTextBox.Mask = "00:00";
            this.hrsMaskedTextBox.Name = "hrsMaskedTextBox";
            this.hrsMaskedTextBox.Size = new System.Drawing.Size(135, 20);
            this.hrsMaskedTextBox.TabIndex = 10;
            // 
            // predm_idMaskedTextBox
            // 
            this.predm_idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GazievaBindingSource, "predm_id", true));
            this.predm_idMaskedTextBox.Location = new System.Drawing.Point(356, 95);
            this.predm_idMaskedTextBox.Name = "predm_idMaskedTextBox";
            this.predm_idMaskedTextBox.Size = new System.Drawing.Size(135, 20);
            this.predm_idMaskedTextBox.TabIndex = 11;
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GazievaBindingSource, "name", true));
            this.nameMaskedTextBox.Location = new System.Drawing.Point(356, 139);
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.Size = new System.Drawing.Size(135, 20);
            this.nameMaskedTextBox.TabIndex = 12;
            // 
            // deptMaskedTextBox
            // 
            this.deptMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GazievaBindingSource, "dept", true));
            this.deptMaskedTextBox.Location = new System.Drawing.Point(356, 231);
            this.deptMaskedTextBox.Name = "deptMaskedTextBox";
            this.deptMaskedTextBox.Size = new System.Drawing.Size(135, 20);
            this.deptMaskedTextBox.TabIndex = 13;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(deptLabel);
            this.Controls.Add(this.deptMaskedTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameMaskedTextBox);
            this.Controls.Add(predm_idLabel);
            this.Controls.Add(this.predm_idMaskedTextBox);
            this.Controls.Add(hrsLabel1);
            this.Controls.Add(this.hrsMaskedTextBox);
            this.Controls.Add(this.subjects_GazievaBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Subjects";
            this.Text = "Дисциплины";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_GazievaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GazievaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GazievaBindingNavigator)).EndInit();
            this.subjects_GazievaBindingNavigator.ResumeLayout(false);
            this.subjects_GazievaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_GazievaDataSet education_GazievaDataSet;
        private System.Windows.Forms.BindingSource subjects_GazievaBindingSource;
        private Education_GazievaDataSetTableAdapters.Subjects_GazievaTableAdapter subjects_GazievaTableAdapter;
        private Education_GazievaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjects_GazievaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjects_GazievaBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox hrsMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox predm_idMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox deptMaskedTextBox;
    }
}