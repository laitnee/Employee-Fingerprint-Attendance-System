namespace FingerprintAttendanceSystem
{
    partial class AttendanceLog
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
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtPckTo = new System.Windows.Forms.DateTimePicker();
            this.dtPckFrom = new System.Windows.Forms.DateTimePicker();
            this.empSearchTxt = new MetroFramework.Controls.MetroTextBox();
            this.btnDate = new MetroFramework.Controls.MetroButton();
            this.btnFilter = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendanceLogViewModelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceLogViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceLogViewModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceLogViewModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceLogViewModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLeave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(323, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 46);
            this.btnReset.Style = MetroFramework.MetroColorStyle.Red;
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Refresh";
            this.btnReset.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(261, 330);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 16);
            this.lblTo.TabIndex = 12;
            this.lblTo.Text = "- To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(56, 330);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 16);
            this.lblFrom.TabIndex = 13;
            this.lblFrom.Text = "From:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // dtPckTo
            // 
            this.dtPckTo.Location = new System.Drawing.Point(200, 354);
            this.dtPckTo.Name = "dtPckTo";
            this.dtPckTo.Size = new System.Drawing.Size(180, 20);
            this.dtPckTo.TabIndex = 10;
            // 
            // dtPckFrom
            // 
            this.dtPckFrom.Location = new System.Drawing.Point(12, 354);
            this.dtPckFrom.Name = "dtPckFrom";
            this.dtPckFrom.Size = new System.Drawing.Size(180, 20);
            this.dtPckFrom.TabIndex = 11;
            this.dtPckFrom.ValueChanged += new System.EventHandler(this.dtPckFrom_ValueChanged);
            // 
            // empSearchTxt
            // 
            this.empSearchTxt.Location = new System.Drawing.Point(418, 351);
            this.empSearchTxt.Name = "empSearchTxt";
            this.empSearchTxt.Size = new System.Drawing.Size(242, 23);
            this.empSearchTxt.TabIndex = 9;
            this.empSearchTxt.Text = "Search for employee";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(154, 380);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 35);
            this.btnDate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDate.TabIndex = 7;
            this.btnDate.Text = "Filter";
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(509, 381);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 34);
            this.btnFilter.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.StaffName,
            this.OnLeave,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceLogViewModelBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 313);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // attendanceLogViewModelBindingSource4
            // 
            this.attendanceLogViewModelBindingSource4.DataSource = typeof(FingerprintAttendanceSystem.Models.AttendanceLogViewModel);
            // 
            // attendanceLogViewModelBindingSource3
            // 
            this.attendanceLogViewModelBindingSource3.DataSource = typeof(FingerprintAttendanceSystem.Models.AttendanceLogViewModel);
            // 
            // attendanceLogViewModelBindingSource2
            // 
            this.attendanceLogViewModelBindingSource2.DataSource = typeof(FingerprintAttendanceSystem.Models.AttendanceLogViewModel);
            // 
            // attendanceLogViewModelBindingSource1
            // 
            this.attendanceLogViewModelBindingSource1.DataSource = typeof(FingerprintAttendanceSystem.Models.AttendanceLogViewModel);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "StaffName";
            this.StaffName.Name = "StaffName";
            this.StaffName.ReadOnly = true;
            // 
            // OnLeave
            // 
            this.OnLeave.DataPropertyName = "OnLeave";
            this.OnLeave.HeaderText = "OnLeave";
            this.OnLeave.Name = "OnLeave";
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // AttendanceLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 454);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtPckTo);
            this.Controls.Add(this.dtPckFrom);
            this.Controls.Add(this.empSearchTxt);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttendanceLog";
            this.Text = "AttendanceLog";
            this.Load += new System.EventHandler(this.AttendanceLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceLogViewModelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private MetroFramework.Controls.MetroButton btnReset;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtPckTo;
        private System.Windows.Forms.DateTimePicker dtPckFrom;
        private MetroFramework.Controls.MetroTextBox empSearchTxt;
        private MetroFramework.Controls.MetroButton btnDate;
        private MetroFramework.Controls.MetroButton btnFilter;
        private System.Windows.Forms.BindingSource attendanceLogViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.BindingSource attendanceRegisterBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource attendanceLogViewModelBindingSource1;
        private System.Windows.Forms.BindingSource attendanceLogViewModelBindingSource2;
        private System.Windows.Forms.BindingSource attendanceLogViewModelBindingSource3;
        private System.Windows.Forms.BindingSource attendanceLogViewModelBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OnLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}