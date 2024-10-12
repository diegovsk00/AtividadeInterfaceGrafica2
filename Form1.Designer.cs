namespace ExercicioMultiplasJanelas
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
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.ForestGreen;
            buttonAdicionar.ForeColor = Color.FloralWhite;
            buttonAdicionar.Location = new Point(12, 63);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(221, 23);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.BackColor = Color.DarkRed;
            buttonRemover.ForeColor = Color.FloralWhite;
            buttonRemover.Location = new Point(557, 63);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(212, 23);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = false;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(757, 264);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
    }
}
