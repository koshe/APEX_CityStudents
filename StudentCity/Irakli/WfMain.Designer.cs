namespace Irakli
{
    partial class WfMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.dgCity_City_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCity_CityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCityBtnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCityBtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCityBtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bsCity = new System.Windows.Forms.BindingSource(this.components);
            this.DgStudent = new System.Windows.Forms.DataGridView();
            this.dgStudent_Student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudent_City_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudent_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudent_PersonalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudent_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsStudentsBtnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStudentsBtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStudentsBtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bsStudent = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            this.cmsCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgStudent)).BeginInit();
            this.cmsStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 489);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgStudent);
            this.splitContainer1.Size = new System.Drawing.Size(913, 489);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.TabIndex = 8;
            // 
            // dgvCity
            // 
            this.dgvCity.AllowUserToAddRows = false;
            this.dgvCity.AllowUserToDeleteRows = false;
            this.dgvCity.AllowUserToResizeColumns = false;
            this.dgvCity.AllowUserToResizeRows = false;
            this.dgvCity.AutoGenerateColumns = false;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCity_City_id,
            this.dgCity_CityName});
            this.dgvCity.ContextMenuStrip = this.cmsCity;
            this.dgvCity.DataSource = this.bsCity;
            this.dgvCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCity.Location = new System.Drawing.Point(0, 0);
            this.dgvCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCity.MultiSelect = false;
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.ReadOnly = true;
            this.dgvCity.RowHeadersVisible = false;
            this.dgvCity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCity.ShowEditingIcon = false;
            this.dgvCity.Size = new System.Drawing.Size(326, 489);
            this.dgvCity.TabIndex = 0;
            this.dgvCity.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCity_CellMouseClick);
            // 
            // dgCity_City_id
            // 
            this.dgCity_City_id.DataPropertyName = "City_id";
            this.dgCity_City_id.HeaderText = "id";
            this.dgCity_City_id.Name = "dgCity_City_id";
            this.dgCity_City_id.ReadOnly = true;
            this.dgCity_City_id.Visible = false;
            // 
            // dgCity_CityName
            // 
            this.dgCity_CityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCity_CityName.DataPropertyName = "CityName";
            this.dgCity_CityName.HeaderText = "ქალაქი";
            this.dgCity_CityName.Name = "dgCity_CityName";
            this.dgCity_CityName.ReadOnly = true;
            // 
            // cmsCity
            // 
            this.cmsCity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCityBtnAdd,
            this.cmsCityBtnEdit,
            this.cmsCityBtnDelete});
            this.cmsCity.Name = "cmsCity";
            this.cmsCity.Size = new System.Drawing.Size(140, 70);
            // 
            // cmsCityBtnAdd
            // 
            this.cmsCityBtnAdd.Name = "cmsCityBtnAdd";
            this.cmsCityBtnAdd.Size = new System.Drawing.Size(139, 22);
            this.cmsCityBtnAdd.Text = "დამატება";
            this.cmsCityBtnAdd.Click += new System.EventHandler(this.cmsCityBtnAdd_Click);
            // 
            // cmsCityBtnEdit
            // 
            this.cmsCityBtnEdit.Name = "cmsCityBtnEdit";
            this.cmsCityBtnEdit.Size = new System.Drawing.Size(139, 22);
            this.cmsCityBtnEdit.Text = "რედაქტირება";
            this.cmsCityBtnEdit.Click += new System.EventHandler(this.cmsCityBtnEdit_Click);
            // 
            // cmsCityBtnDelete
            // 
            this.cmsCityBtnDelete.Name = "cmsCityBtnDelete";
            this.cmsCityBtnDelete.Size = new System.Drawing.Size(139, 22);
            this.cmsCityBtnDelete.Text = "წაშლა";
            this.cmsCityBtnDelete.Click += new System.EventHandler(this.cmsCityBtnDelete_Click);
            // 
            // DgStudent
            // 
            this.DgStudent.AllowUserToAddRows = false;
            this.DgStudent.AllowUserToDeleteRows = false;
            this.DgStudent.AllowUserToResizeColumns = false;
            this.DgStudent.AllowUserToResizeRows = false;
            this.DgStudent.AutoGenerateColumns = false;
            this.DgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgStudent_Student_id,
            this.dgStudent_City_id,
            this.dgStudent_FullName,
            this.dgStudent_PersonalID,
            this.dgStudent_PhoneNumber});
            this.DgStudent.ContextMenuStrip = this.cmsStudents;
            this.DgStudent.DataSource = this.bsStudent;
            this.DgStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgStudent.Location = new System.Drawing.Point(0, 0);
            this.DgStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgStudent.MultiSelect = false;
            this.DgStudent.Name = "DgStudent";
            this.DgStudent.ReadOnly = true;
            this.DgStudent.RowHeadersVisible = false;
            this.DgStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgStudent.ShowEditingIcon = false;
            this.DgStudent.Size = new System.Drawing.Size(583, 489);
            this.DgStudent.TabIndex = 1;
            this.DgStudent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgStudent_CellMouseClick);
            // 
            // dgStudent_Student_id
            // 
            this.dgStudent_Student_id.DataPropertyName = "Student_id";
            this.dgStudent_Student_id.HeaderText = "id";
            this.dgStudent_Student_id.Name = "dgStudent_Student_id";
            this.dgStudent_Student_id.ReadOnly = true;
            this.dgStudent_Student_id.Visible = false;
            // 
            // dgStudent_City_id
            // 
            this.dgStudent_City_id.DataPropertyName = "City_id";
            this.dgStudent_City_id.HeaderText = "City_id";
            this.dgStudent_City_id.Name = "dgStudent_City_id";
            this.dgStudent_City_id.ReadOnly = true;
            this.dgStudent_City_id.Visible = false;
            // 
            // dgStudent_FullName
            // 
            this.dgStudent_FullName.DataPropertyName = "FullName";
            this.dgStudent_FullName.HeaderText = "სახელი";
            this.dgStudent_FullName.Name = "dgStudent_FullName";
            this.dgStudent_FullName.ReadOnly = true;
            this.dgStudent_FullName.Width = 150;
            // 
            // dgStudent_PersonalID
            // 
            this.dgStudent_PersonalID.DataPropertyName = "PersonalID";
            this.dgStudent_PersonalID.HeaderText = "პირადი ნომერი";
            this.dgStudent_PersonalID.Name = "dgStudent_PersonalID";
            this.dgStudent_PersonalID.ReadOnly = true;
            this.dgStudent_PersonalID.Width = 150;
            // 
            // dgStudent_PhoneNumber
            // 
            this.dgStudent_PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgStudent_PhoneNumber.DataPropertyName = "PhoneNumber";
            this.dgStudent_PhoneNumber.HeaderText = "ტელეფონის ნომერი";
            this.dgStudent_PhoneNumber.Name = "dgStudent_PhoneNumber";
            this.dgStudent_PhoneNumber.ReadOnly = true;
            // 
            // cmsStudents
            // 
            this.cmsStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsStudentsBtnAdd,
            this.cmsStudentsBtnEdit,
            this.cmsStudentsBtnDelete});
            this.cmsStudents.Name = "cmsStudents";
            this.cmsStudents.Size = new System.Drawing.Size(140, 70);
            // 
            // cmsStudentsBtnAdd
            // 
            this.cmsStudentsBtnAdd.Name = "cmsStudentsBtnAdd";
            this.cmsStudentsBtnAdd.Size = new System.Drawing.Size(139, 22);
            this.cmsStudentsBtnAdd.Text = "დამატება";
            this.cmsStudentsBtnAdd.Click += new System.EventHandler(this.cmsStudentsBtnAdd_Click);
            // 
            // cmsStudentsBtnEdit
            // 
            this.cmsStudentsBtnEdit.Name = "cmsStudentsBtnEdit";
            this.cmsStudentsBtnEdit.Size = new System.Drawing.Size(139, 22);
            this.cmsStudentsBtnEdit.Text = "რედაქტირება";
            this.cmsStudentsBtnEdit.Click += new System.EventHandler(this.cmsStudentsBtnEdit_Click);
            // 
            // cmsStudentsBtnDelete
            // 
            this.cmsStudentsBtnDelete.Name = "cmsStudentsBtnDelete";
            this.cmsStudentsBtnDelete.Size = new System.Drawing.Size(139, 22);
            this.cmsStudentsBtnDelete.Text = "წაშლა";
            this.cmsStudentsBtnDelete.Click += new System.EventHandler(this.cmsStudentsBtnDelete_Click);
            // 
            // WfMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 489);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WfMain";
            this.Text = "მთავარი";
            this.Load += new System.EventHandler(this.WfMain_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            this.cmsCity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgStudent)).EndInit();
            this.cmsStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudent_Student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudent_City_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudent_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudent_PersonalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStudent_PhoneNumber;
        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.BindingSource bsCity;
        private System.Windows.Forms.BindingSource bsStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCity_City_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCity_CityName;
        private System.Windows.Forms.ContextMenuStrip cmsCity;
        private System.Windows.Forms.ContextMenuStrip cmsStudents;
        private System.Windows.Forms.ToolStripMenuItem cmsCityBtnAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsCityBtnEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsCityBtnDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsStudentsBtnAdd;
        private System.Windows.Forms.ToolStripMenuItem cmsStudentsBtnEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsStudentsBtnDelete;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

