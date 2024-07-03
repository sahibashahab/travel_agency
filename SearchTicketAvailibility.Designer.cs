namespace TravelAgencySystem
{
    partial class SearchTicketAvailibility
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cb_CurrentLoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DepartDatePick = new System.Windows.Forms.DateTimePicker();
            this.cb_Destination = new System.Windows.Forms.ComboBox();
            this.cb_TransType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ClassType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NoSeats = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "DepartureDate";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(306, 240);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(289, 23);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cb_CurrentLoc
            // 
            this.cb_CurrentLoc.FormattingEnabled = true;
            this.cb_CurrentLoc.Location = new System.Drawing.Point(198, 113);
            this.cb_CurrentLoc.Name = "cb_CurrentLoc";
            this.cb_CurrentLoc.Size = new System.Drawing.Size(195, 21);
            this.cb_CurrentLoc.TabIndex = 11;
            this.cb_CurrentLoc.DropDown += new System.EventHandler(this.cb_CurrentLoc_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Location ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination ";
            // 
            // DepartDatePick
            // 
            this.DepartDatePick.Location = new System.Drawing.Point(198, 40);
            this.DepartDatePick.Name = "DepartDatePick";
            this.DepartDatePick.Size = new System.Drawing.Size(195, 20);
            this.DepartDatePick.TabIndex = 14;
            // 
            // cb_Destination
            // 
            this.cb_Destination.FormattingEnabled = true;
            this.cb_Destination.Location = new System.Drawing.Point(198, 191);
            this.cb_Destination.Name = "cb_Destination";
            this.cb_Destination.Size = new System.Drawing.Size(195, 21);
            this.cb_Destination.TabIndex = 15;
            this.cb_Destination.DropDown += new System.EventHandler(this.cb_Destination_DropDown);
            // 
            // cb_TransType
            // 
            this.cb_TransType.FormattingEnabled = true;
            this.cb_TransType.Location = new System.Drawing.Point(632, 39);
            this.cb_TransType.Name = "cb_TransType";
            this.cb_TransType.Size = new System.Drawing.Size(125, 21);
            this.cb_TransType.TabIndex = 17;
            this.cb_TransType.DropDown += new System.EventHandler(this.cb_TransType_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Transportation Type";
            // 
            // cb_ClassType
            // 
            this.cb_ClassType.FormattingEnabled = true;
            this.cb_ClassType.Location = new System.Drawing.Point(632, 113);
            this.cb_ClassType.Name = "cb_ClassType";
            this.cb_ClassType.Size = new System.Drawing.Size(125, 21);
            this.cb_ClassType.TabIndex = 19;
            this.cb_ClassType.DropDown += new System.EventHandler(this.cb_ClassType_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Class Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "No Of Seats";
            // 
            // txt_NoSeats
            // 
            this.txt_NoSeats.Location = new System.Drawing.Point(632, 191);
            this.txt_NoSeats.Name = "txt_NoSeats";
            this.txt_NoSeats.Size = new System.Drawing.Size(125, 20);
            this.txt_NoSeats.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(814, 247);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // SearchTicketAvailibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_NoSeats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_ClassType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_TransType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Destination);
            this.Controls.Add(this.DepartDatePick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_CurrentLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchTicketAvailibility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchTicketAvailibility";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cb_CurrentLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DepartDatePick;
        private System.Windows.Forms.ComboBox cb_Destination;
        private System.Windows.Forms.ComboBox cb_TransType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ClassType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NoSeats;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}