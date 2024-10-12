namespace ExercicioMultiplasJanelas
{
    partial class FormCriarProduto
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
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            InputPrecoVenda = new NumericUpDown();
            InputPrecoCompra = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonOk = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoCompra).BeginInit();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(201, 74);
            textBoxNome.Multiline = true;
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(201, 103);
            textBoxFabricante.Multiline = true;
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(100, 23);
            textBoxFabricante.TabIndex = 1;
            // 
            // InputPrecoVenda
            // 
            InputPrecoVenda.DecimalPlaces = 2;
            InputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            InputPrecoVenda.Location = new Point(201, 166);
            InputPrecoVenda.Name = "InputPrecoVenda";
            InputPrecoVenda.Size = new Size(120, 23);
            InputPrecoVenda.TabIndex = 2;
            InputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // InputPrecoCompra
            // 
            InputPrecoCompra.DecimalPlaces = 2;
            InputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            InputPrecoCompra.Location = new Point(201, 135);
            InputPrecoCompra.Name = "InputPrecoCompra";
            InputPrecoCompra.Size = new Size(120, 23);
            InputPrecoCompra.TabIndex = 3;
            InputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 77);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 111);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "Fabricante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 143);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 6;
            label3.Text = "Preço de Compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 174);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 7;
            label4.Text = "Preço de Venda:";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(89, 201);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(246, 201);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCriarProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(574, 440);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputPrecoCompra);
            Controls.Add(InputPrecoVenda);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Name = "FormCriarProduto";
            Text = "FormCriarProduto";
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private NumericUpDown InputPrecoVenda;
        private NumericUpDown InputPrecoCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOk;
        private Button buttonCancelar;
    }
}