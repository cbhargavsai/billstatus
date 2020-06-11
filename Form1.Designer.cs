namespace Bill_Form
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SAVE = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TOTAL = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnitems = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtparticular = new System.Windows.Forms.TextBox();
            this.AMOUNT = new System.Windows.Forms.Label();
            this.PARTICULAR = new System.Windows.Forms.Label();
            this.txtflat = new System.Windows.Forms.TextBox();
            this.FLATNO = new System.Windows.Forms.Label();
            this.cbwing = new System.Windows.Forms.ComboBox();
            this.WING = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.STATUS = new System.Windows.Forms.Label();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.TYPE = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.DATE = new System.Windows.Forms.Label();
            this.txtbill = new System.Windows.Forms.TextBox();
            this.BILL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.SAVE);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TOTAL);
            this.panel1.Controls.Add(this.btncalculate);
            this.panel1.Controls.Add(this.btnitems);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.txtparticular);
            this.panel1.Controls.Add(this.AMOUNT);
            this.panel1.Controls.Add(this.PARTICULAR);
            this.panel1.Controls.Add(this.txtflat);
            this.panel1.Controls.Add(this.FLATNO);
            this.panel1.Controls.Add(this.cbwing);
            this.panel1.Controls.Add(this.WING);
            this.panel1.Controls.Add(this.cbstatus);
            this.panel1.Controls.Add(this.STATUS);
            this.panel1.Controls.Add(this.cbtype);
            this.panel1.Controls.Add(this.TYPE);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.NAME);
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.DATE);
            this.panel1.Controls.Add(this.txtbill);
            this.panel1.Controls.Add(this.BILL);
            this.panel1.Location = new System.Drawing.Point(377, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 627);
            this.panel1.TabIndex = 0;
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.Transparent;
            this.SAVE.BackgroundImage = global::Bill_Form.Properties.Resources.button__28_;
            this.SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SAVE.Location = new System.Drawing.Point(102, 557);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(96, 46);
            this.SAVE.TabIndex = 99;
            this.SAVE.UseVisualStyleBackColor = false;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(653, 563);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 26);
            this.txttotal.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 97;
            this.label2.Text = "RS ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "TOTAL :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATA,
            this.ADD});
            this.dataGridView1.Location = new System.Drawing.Point(102, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, -18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "BILL GENERATE";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSize = true;
            this.TOTAL.Location = new System.Drawing.Point(649, 534);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(0, 20);
            this.TOTAL.TabIndex = 91;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncalculate.BackgroundImage = global::Bill_Form.Properties.Resources.button__29_;
            this.btncalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncalculate.Location = new System.Drawing.Point(607, 512);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(168, 42);
            this.btncalculate.TabIndex = 90;
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click_1);
            // 
            // btnitems
            // 
            this.btnitems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnitems.BackgroundImage = global::Bill_Form.Properties.Resources.button__31_;
            this.btnitems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnitems.Location = new System.Drawing.Point(616, 261);
            this.btnitems.Name = "btnitems";
            this.btnitems.Size = new System.Drawing.Size(100, 38);
            this.btnitems.TabIndex = 89;
            this.btnitems.UseVisualStyleBackColor = false;
            this.btnitems.Click += new System.EventHandler(this.btnitems_Click_2);
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(402, 273);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(178, 26);
            this.txtamount.TabIndex = 88;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // txtparticular
            // 
            this.txtparticular.Location = new System.Drawing.Point(131, 273);
            this.txtparticular.Name = "txtparticular";
            this.txtparticular.Size = new System.Drawing.Size(177, 26);
            this.txtparticular.TabIndex = 87;
            this.txtparticular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtparticular_KeyPress);
            // 
            // AMOUNT
            // 
            this.AMOUNT.AutoSize = true;
            this.AMOUNT.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMOUNT.Location = new System.Drawing.Point(446, 240);
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(95, 23);
            this.AMOUNT.TabIndex = 86;
            this.AMOUNT.Text = "AMOUNT";
            // 
            // PARTICULAR
            // 
            this.PARTICULAR.AutoSize = true;
            this.PARTICULAR.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PARTICULAR.Location = new System.Drawing.Point(141, 240);
            this.PARTICULAR.Name = "PARTICULAR";
            this.PARTICULAR.Size = new System.Drawing.Size(127, 23);
            this.PARTICULAR.TabIndex = 85;
            this.PARTICULAR.Text = "PARTICULAR";
            // 
            // txtflat
            // 
            this.txtflat.Location = new System.Drawing.Point(616, 159);
            this.txtflat.Name = "txtflat";
            this.txtflat.Size = new System.Drawing.Size(100, 26);
            this.txtflat.TabIndex = 84;
            // 
            // FLATNO
            // 
            this.FLATNO.AutoSize = true;
            this.FLATNO.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLATNO.Location = new System.Drawing.Point(421, 159);
            this.FLATNO.Name = "FLATNO";
            this.FLATNO.Size = new System.Drawing.Size(190, 23);
            this.FLATNO.TabIndex = 83;
            this.FLATNO.Text = "FLAT NO/SHOP NO :";
            // 
            // cbwing
            // 
            this.cbwing.FormattingEnabled = true;
            this.cbwing.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbwing.Location = new System.Drawing.Point(157, 196);
            this.cbwing.Name = "cbwing";
            this.cbwing.Size = new System.Drawing.Size(121, 28);
            this.cbwing.TabIndex = 82;
            // 
            // WING
            // 
            this.WING.AutoSize = true;
            this.WING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WING.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WING.Location = new System.Drawing.Point(36, 201);
            this.WING.Name = "WING";
            this.WING.Size = new System.Drawing.Size(73, 23);
            this.WING.TabIndex = 81;
            this.WING.Text = "WING :";
            // 
            // cbstatus
            // 
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "PAID",
            "UNPAID"});
            this.cbstatus.Location = new System.Drawing.Point(616, 108);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(121, 28);
            this.cbstatus.TabIndex = 80;
            // 
            // STATUS
            // 
            this.STATUS.AutoSize = true;
            this.STATUS.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS.Location = new System.Drawing.Point(421, 113);
            this.STATUS.Name = "STATUS";
            this.STATUS.Size = new System.Drawing.Size(89, 23);
            this.STATUS.TabIndex = 79;
            this.STATUS.Text = "STATUS :";
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Items.AddRange(new object[] {
            "FLAT",
            "SHOP"});
            this.cbtype.Location = new System.Drawing.Point(157, 151);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(121, 28);
            this.cbtype.TabIndex = 78;
            // 
            // TYPE
            // 
            this.TYPE.AutoSize = true;
            this.TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TYPE.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TYPE.Location = new System.Drawing.Point(36, 156);
            this.TYPE.Name = "TYPE";
            this.TYPE.Size = new System.Drawing.Size(69, 23);
            this.TYPE.TabIndex = 77;
            this.TYPE.Text = "TYPE :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(157, 108);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 26);
            this.txtname.TabIndex = 76;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAME.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.Location = new System.Drawing.Point(36, 111);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(76, 23);
            this.NAME.TabIndex = 75;
            this.NAME.Text = "NAME :";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(616, 57);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 26);
            this.txtdate.TabIndex = 74;
            // 
            // DATE
            // 
            this.DATE.AutoSize = true;
            this.DATE.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE.Location = new System.Drawing.Point(421, 59);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(69, 23);
            this.DATE.TabIndex = 73;
            this.DATE.Text = "DATE :";
            // 
            // txtbill
            // 
            this.txtbill.BackColor = System.Drawing.Color.White;
            this.txtbill.Location = new System.Drawing.Point(157, 56);
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(100, 26);
            this.txtbill.TabIndex = 72;
            this.txtbill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbill_KeyPress);
            // 
            // BILL
            // 
            this.BILL.AutoSize = true;
            this.BILL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BILL.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BILL.Location = new System.Drawing.Point(36, 64);
            this.BILL.Name = "BILL";
            this.BILL.Size = new System.Drawing.Size(94, 23);
            this.BILL.TabIndex = 71;
            this.BILL.Text = "BILL NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(668, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 57);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bill Generate";
            // 
            // DATA
            // 
            this.DATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATA.HeaderText = "PARTICULAR";
            this.DATA.MinimumWidth = 100;
            this.DATA.Name = "DATA";
            this.DATA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ADD
            // 
            this.ADD.HeaderText = "AMOUNT";
            this.ADD.Name = "ADD";
            this.ADD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bill_Form.Properties.Resources.building;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1515, 777);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TOTAL;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnitems;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtparticular;
        private System.Windows.Forms.Label AMOUNT;
        private System.Windows.Forms.Label PARTICULAR;
        private System.Windows.Forms.TextBox txtflat;
        private System.Windows.Forms.Label FLATNO;
        private System.Windows.Forms.ComboBox cbwing;
        private System.Windows.Forms.Label WING;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.Label STATUS;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label TYPE;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label DATE;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.Label BILL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD;


    }
}

