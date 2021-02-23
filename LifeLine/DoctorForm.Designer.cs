namespace LifeLine
{
    partial class DoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.docDegree = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocExp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.specification = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DoctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.coouncialFees = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblDName = new System.Windows.Forms.Label();
            this.lblfees = new System.Windows.Forms.Label();
            this.lblspeci = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.docId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 92);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Life Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LimeGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(398, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOCTOR";
            // 
            // docDegree
            // 
            this.docDegree.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.docDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docDegree.HintForeColor = System.Drawing.Color.Empty;
            this.docDegree.HintText = "";
            this.docDegree.isPassword = false;
            this.docDegree.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docDegree.LineIdleColor = System.Drawing.Color.Gray;
            this.docDegree.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docDegree.LineThickness = 3;
            this.docDegree.Location = new System.Drawing.Point(55, 253);
            this.docDegree.Margin = new System.Windows.Forms.Padding(4);
            this.docDegree.Name = "docDegree";
            this.docDegree.Size = new System.Drawing.Size(147, 36);
            this.docDegree.TabIndex = 1;
            this.docDegree.Text = "Degree";
            this.docDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.docDegree.MouseEnter += new System.EventHandler(this.docDegree_MouseEnter);
            this.docDegree.MouseLeave += new System.EventHandler(this.docDegree_MouseLeave);
            // 
            // DocName
            // 
            this.DocName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DocName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocName.HintForeColor = System.Drawing.Color.Empty;
            this.DocName.HintText = "";
            this.DocName.isPassword = false;
            this.DocName.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocName.LineIdleColor = System.Drawing.Color.Gray;
            this.DocName.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocName.LineThickness = 3;
            this.DocName.Location = new System.Drawing.Point(55, 140);
            this.DocName.Margin = new System.Windows.Forms.Padding(4);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(147, 30);
            this.DocName.TabIndex = 2;
            this.DocName.Text = "Doctor Name";
            this.DocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocName.MouseEnter += new System.EventHandler(this.DocName_MouseEnter);
            this.DocName.MouseLeave += new System.EventHandler(this.DocName_MouseLeave);
            // 
            // DocExp
            // 
            this.DocExp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DocExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocExp.HintForeColor = System.Drawing.Color.Empty;
            this.DocExp.HintText = "";
            this.DocExp.isPassword = false;
            this.DocExp.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.DocExp.LineIdleColor = System.Drawing.Color.Gray;
            this.DocExp.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.DocExp.LineThickness = 3;
            this.DocExp.Location = new System.Drawing.Point(55, 199);
            this.DocExp.Margin = new System.Windows.Forms.Padding(4);
            this.DocExp.Name = "DocExp";
            this.DocExp.Size = new System.Drawing.Size(147, 30);
            this.DocExp.TabIndex = 3;
            this.DocExp.Text = "Years Of Experience";
            this.DocExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocExp.MouseEnter += new System.EventHandler(this.DocExp_MouseEnter);
            this.DocExp.MouseLeave += new System.EventHandler(this.DocExp_MouseLeave);
            // 
            // specification
            // 
            this.specification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.specification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.specification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.specification.HintForeColor = System.Drawing.Color.Empty;
            this.specification.HintText = "";
            this.specification.isPassword = false;
            this.specification.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.specification.LineIdleColor = System.Drawing.Color.Gray;
            this.specification.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.specification.LineThickness = 3;
            this.specification.Location = new System.Drawing.Point(55, 313);
            this.specification.Margin = new System.Windows.Forms.Padding(4);
            this.specification.Name = "specification";
            this.specification.Size = new System.Drawing.Size(147, 30);
            this.specification.TabIndex = 4;
            this.specification.Text = "Specification";
            this.specification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.specification.MouseEnter += new System.EventHandler(this.specification_MouseEnter);
            this.specification.MouseLeave += new System.EventHandler(this.specification_MouseLeave);
            // 
            // DoctorGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DoctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorGV.EnableHeadersVisualStyles = false;
            this.DoctorGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.Location = new System.Drawing.Point(368, 144);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.RowHeadersVisible = false;
            this.DoctorGV.RowTemplate.Height = 30;
            this.DoctorGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorGV.Size = new System.Drawing.Size(565, 380);
            this.DoctorGV.TabIndex = 5;
            this.DoctorGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.DoctorGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DoctorGV.ThemeStyle.ReadOnly = false;
            this.DoctorGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.ThemeStyle.RowsStyle.Height = 30;
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(43, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(142, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(252, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(142, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // coouncialFees
            // 
            this.coouncialFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.coouncialFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.coouncialFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coouncialFees.HintForeColor = System.Drawing.Color.Empty;
            this.coouncialFees.HintText = "";
            this.coouncialFees.isPassword = false;
            this.coouncialFees.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.coouncialFees.LineIdleColor = System.Drawing.Color.Gray;
            this.coouncialFees.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.coouncialFees.LineThickness = 3;
            this.coouncialFees.Location = new System.Drawing.Point(55, 366);
            this.coouncialFees.Margin = new System.Windows.Forms.Padding(4);
            this.coouncialFees.Name = "coouncialFees";
            this.coouncialFees.Size = new System.Drawing.Size(147, 30);
            this.coouncialFees.TabIndex = 10;
            this.coouncialFees.Text = "Counseling Fees";
            this.coouncialFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.coouncialFees.MouseEnter += new System.EventHandler(this.coouncialFees_MouseEnter);
            this.coouncialFees.MouseLeave += new System.EventHandler(this.coouncialFees_MouseLeave);
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Location = new System.Drawing.Point(52, 123);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(70, 13);
            this.lblDName.TabIndex = 11;
            this.lblDName.Text = "Doctor Name";
            // 
            // lblfees
            // 
            this.lblfees.AutoSize = true;
            this.lblfees.Location = new System.Drawing.Point(52, 347);
            this.lblfees.Name = "lblfees";
            this.lblfees.Size = new System.Drawing.Size(85, 13);
            this.lblfees.TabIndex = 12;
            this.lblfees.Text = "Counseling Fees";
            // 
            // lblspeci
            // 
            this.lblspeci.AutoSize = true;
            this.lblspeci.Location = new System.Drawing.Point(52, 296);
            this.lblspeci.Name = "lblspeci";
            this.lblspeci.Size = new System.Drawing.Size(68, 13);
            this.lblspeci.TabIndex = 13;
            this.lblspeci.Text = "Specification";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(52, 237);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(42, 13);
            this.lblDegree.TabIndex = 14;
            this.lblDegree.Text = "Degree";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(52, 174);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(60, 13);
            this.lblExp.TabIndex = 15;
            this.lblExp.Text = "Experience";
            // 
            // docId
            // 
            this.docId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.docId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docId.HintForeColor = System.Drawing.Color.Empty;
            this.docId.HintText = "";
            this.docId.isPassword = false;
            this.docId.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.docId.LineIdleColor = System.Drawing.Color.Gray;
            this.docId.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.docId.LineThickness = 3;
            this.docId.Location = new System.Drawing.Point(198, 106);
            this.docId.Margin = new System.Windows.Forms.Padding(4);
            this.docId.Name = "docId";
            this.docId.Size = new System.Drawing.Size(104, 30);
            this.docId.TabIndex = 16;
            this.docId.Text = "id";
            this.docId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(945, 597);
            this.Controls.Add(this.docId);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblspeci);
            this.Controls.Add(this.lblfees);
            this.Controls.Add(this.lblDName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coouncialFees);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.specification);
            this.Controls.Add(this.DocExp);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.docDegree);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docDegree;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocExp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox specification;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox coouncialFees;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblfees;
        private System.Windows.Forms.Label lblspeci;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblExp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox docId;
    }
}