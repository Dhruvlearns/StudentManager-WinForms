namespace forms_data
{
    partial class frmstudentregistration
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblname = new Label();
            lblcourse = new Label();
            label4 = new Label();
            lblmobile = new Label();
            lblgender = new Label();
            txbname = new TextBox();
            txbaddress = new TextBox();
            txbmobile = new TextBox();
            txbgender = new TextBox();
            btnsubmit = new Button();
            lblid = new Label();
            txbid = new TextBox();
            comboBoxCourses = new ComboBox();
            studentinformationBindingSource = new BindingSource(components);
            studentinformationBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentinformationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentinformationBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 128);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.usericon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(88, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 73);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(260, 37);
            label1.Name = "label1";
            label1.Size = new Size(437, 40);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            label1.Click += label1_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.Location = new Point(88, 131);
            lblname.Name = "lblname";
            lblname.Size = new Size(185, 37);
            lblname.TabIndex = 2;
            lblname.Text = "StudentName";
            // 
            // lblcourse
            // 
            lblcourse.AutoSize = true;
            lblcourse.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcourse.Location = new Point(111, 328);
            lblcourse.Name = "lblcourse";
            lblcourse.Size = new Size(104, 37);
            lblcourse.TabIndex = 3;
            lblcourse.Text = "Course";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 279);
            label4.Name = "label4";
            label4.Size = new Size(121, 37);
            label4.TabIndex = 4;
            label4.Text = "Address";
            // 
            // lblmobile
            // 
            lblmobile.AutoSize = true;
            lblmobile.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmobile.Location = new Point(107, 232);
            lblmobile.Name = "lblmobile";
            lblmobile.Size = new Size(102, 37);
            lblmobile.TabIndex = 5;
            lblmobile.Text = "Mobile";
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgender.Location = new Point(108, 183);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(107, 37);
            lblgender.TabIndex = 6;
            lblgender.Text = "Gender";
            // 
            // txbname
            // 
            txbname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbname.Location = new Point(374, 131);
            txbname.Name = "txbname";
            txbname.Size = new Size(150, 39);
            txbname.TabIndex = 7;
            txbname.TextChanged += txbname_TextChanged;
            // 
            // txbaddress
            // 
            txbaddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbaddress.Location = new Point(374, 279);
            txbaddress.Name = "txbaddress";
            txbaddress.Size = new Size(150, 39);
            txbaddress.TabIndex = 9;
            txbaddress.MultilineChanged += txbaddress_MultilineChanged;
            txbaddress.TextChanged += txbaddress_TextChanged;
            // 
            // txbmobile
            // 
            txbmobile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbmobile.Location = new Point(374, 232);
            txbmobile.MaxLength = 10;
            txbmobile.Name = "txbmobile";
            txbmobile.Size = new Size(150, 39);
            txbmobile.TabIndex = 10;
            txbmobile.TextChanged += txbmobile_TextChanged;
            txbmobile.KeyPress += txbmobile_KeyPress;
            // 
            // txbgender
            // 
            txbgender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbgender.Location = new Point(374, 183);
            txbgender.Name = "txbgender";
            txbgender.Size = new Size(150, 39);
            txbgender.TabIndex = 11;
            txbgender.TextChanged += txbgender_TextChanged;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.MediumSeaGreen;
            btnsubmit.DialogResult = DialogResult.OK;
            btnsubmit.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsubmit.Location = new Point(342, 431);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(206, 55);
            btnsubmit.TabIndex = 13;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += lblsubmit_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Palatino Linotype", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblid.Location = new Point(128, 386);
            lblid.Name = "lblid";
            lblid.Size = new Size(42, 37);
            lblid.TabIndex = 14;
            lblid.Text = "id";
            // 
            // txbid
            // 
            txbid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbid.Location = new Point(374, 386);
            txbid.Name = "txbid";
            txbid.Size = new Size(150, 39);
            txbid.TabIndex = 15;
            txbid.TextChanged += txbid_TextChanged;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(366, 328);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.Size = new Size(182, 33);
            comboBoxCourses.TabIndex = 16;
            comboBoxCourses.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // studentinformationBindingSource
            // 
            studentinformationBindingSource.DataSource = typeof(DBContext.Student_information);
            // 
            // studentinformationBindingSource1
            // 
            studentinformationBindingSource1.DataSource = typeof(DBContext.Student_information);
            // 
            // frmstudentregistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 577);
            Controls.Add(comboBoxCourses);
            Controls.Add(txbid);
            Controls.Add(lblid);
            Controls.Add(btnsubmit);
            Controls.Add(txbgender);
            Controls.Add(txbmobile);
            Controls.Add(txbaddress);
            Controls.Add(txbname);
            Controls.Add(lblgender);
            Controls.Add(lblmobile);
            Controls.Add(label4);
            Controls.Add(lblcourse);
            Controls.Add(lblname);
            Controls.Add(panel1);
            Name = "frmstudentregistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += frmstudentregistration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentinformationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentinformationBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblname;
        private Label lblcourse;
        private Label label4;
        private Label lblmobile;
        private Label lblgender;
        private TextBox txbname;
        private TextBox txbaddress;
        private TextBox txbmobile;
        private TextBox txbgender;
        private Button btnsubmit;
        private Label lblid;
        private TextBox txbid;
        private ComboBox comboBoxCourses;
        private BindingSource studentinformationBindingSource1;
        private BindingSource studentinformationBindingSource;
    }
}