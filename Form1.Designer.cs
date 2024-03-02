namespace LR1_CD
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            titleBox = new TextBox();
            authorBox = new TextBox();
            yearBox = new TextBox();
            genreBox = new TextBox();
            clientBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(674, 337);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 595);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(215, 72);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(453, 586);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(233, 72);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(102, 365);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(125, 27);
            titleBox.TabIndex = 3;
            // 
            // authorBox
            // 
            authorBox.Location = new Point(102, 415);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(125, 27);
            authorBox.TabIndex = 4;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(102, 466);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(125, 27);
            yearBox.TabIndex = 5;
            // 
            // genreBox
            // 
            genreBox.Location = new Point(102, 513);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(125, 27);
            genreBox.TabIndex = 6;
            // 
            // clientBox
            // 
            clientBox.Location = new Point(102, 553);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(125, 27);
            clientBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 365);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 8;
            label1.Text = "Название";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 415);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 9;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 466);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 10;
            label3.Text = "Год";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 513);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 11;
            label4.Text = "Жанр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 553);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "Клиент";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 670);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clientBox);
            Controls.Add(genreBox);
            Controls.Add(yearBox);
            Controls.Add(authorBox);
            Controls.Add(titleBox);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox titleBox;
        private TextBox authorBox;
        private TextBox yearBox;
        private TextBox genreBox;
        private TextBox clientBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}