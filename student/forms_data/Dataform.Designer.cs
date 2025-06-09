
namespace forms_data
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnadd = new Button();
            btndelete = new Button();
            btnedit = new Button();
            studentEntitiesnewBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            studentinformationBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)studentEntitiesnewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentinformationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.MintCream;
            btnadd.Font = new Font("SimSun", 12F);
            btnadd.Location = new Point(108, 27);
            btnadd.Margin = new Padding(4, 3, 4, 3);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(205, 70);
            btnadd.TabIndex = 4;
            btnadd.Text = "ADD USER";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += button1_Click;
            // 
            // btndelete
            // 
            btndelete.Font = new Font("SimSun", 12F);
            btndelete.Location = new Point(737, 27);
            btndelete.Margin = new Padding(4, 3, 4, 3);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(216, 70);
            btndelete.TabIndex = 5;
            btndelete.Text = "DELETE USER";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnedit
            // 
            btnedit.Font = new Font("SimSun", 12F);
            btnedit.Location = new Point(395, 27);
            btnedit.Margin = new Padding(4, 3, 4, 3);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(216, 70);
            btnedit.TabIndex = 6;
            btnedit.Text = "EDIT USER";
            btnedit.UseVisualStyleBackColor = true;
            btnedit.Click += btnedit_Click;
            // 
            // studentEntitiesnewBindingSource
            // 
            studentEntitiesnewBindingSource.DataSource = typeof(DBContext.StudentEntities_new);
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(108, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(867, 254);
            dataGridView1.TabIndex = 7;
            // 
            // studentinformationBindingSource
            // 
            studentinformationBindingSource.DataSource = typeof(DBContext.Student_information);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1074, 425);
            Controls.Add(dataGridView1);
            Controls.Add(btnedit);
            Controls.Add(btndelete);
            Controls.Add(btnadd);
            Font = new Font("SimSun", 12F);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)studentEntitiesnewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentinformationBindingSource).EndInit();
            ResumeLayout(false);
        }



        #endregion
        private Button btnadd;
        private Button btndelete;
        private Button btnedit;
        private BindingSource studentEntitiesnewBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private BindingSource studentinformationBindingSource;
        private DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
    }
}
