namespace LabTab
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            btnSomar = new Button();
            txtResultadoSoma = new TextBox();
            txtNum2TabSomar = new TextBox();
            txtNum1TabSomar = new TextBox();
            btnResultado = new Label();
            btnSegundoNumero = new Label();
            btnPrimeiroNumero = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            btnSubtrair = new Button();
            txtResultadoSubtracao = new TextBox();
            txtNum2SubTab2 = new TextBox();
            txtNum1SubTab2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            label6 = new Label();
            btnMultiplicar = new Button();
            txtResultadoMultiplicacao = new TextBox();
            txtNum2MultTab3 = new TextBox();
            txtNum1MultTab3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            label10 = new Label();
            btnDividir = new Button();
            txtResultadoDivisao = new TextBox();
            txtNum2DivTab4 = new TextBox();
            txtNum1DivTab4 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(115, 71);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(491, 302);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btnSomar);
            tabPage1.Controls.Add(txtResultadoSoma);
            tabPage1.Controls.Add(txtNum2TabSomar);
            tabPage1.Controls.Add(txtNum1TabSomar);
            tabPage1.Controls.Add(btnResultado);
            tabPage1.Controls.Add(btnSegundoNumero);
            tabPage1.Controls.Add(btnPrimeiroNumero);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(483, 274);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Somar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 76);
            label4.Name = "label4";
            label4.Size = new Size(21, 24);
            label4.TabIndex = 7;
            label4.Text = "+";
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(337, 127);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 6;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // txtResultadoSoma
            // 
            txtResultadoSoma.Location = new Point(35, 227);
            txtResultadoSoma.Name = "txtResultadoSoma";
            txtResultadoSoma.ReadOnly = true;
            txtResultadoSoma.Size = new Size(193, 23);
            txtResultadoSoma.TabIndex = 5;
            // 
            // txtNum2TabSomar
            // 
            txtNum2TabSomar.Location = new Point(32, 127);
            txtNum2TabSomar.Name = "txtNum2TabSomar";
            txtNum2TabSomar.Size = new Size(196, 23);
            txtNum2TabSomar.TabIndex = 4;
            // 
            // txtNum1TabSomar
            // 
            txtNum1TabSomar.Location = new Point(35, 39);
            txtNum1TabSomar.Name = "txtNum1TabSomar";
            txtNum1TabSomar.Size = new Size(196, 23);
            txtNum1TabSomar.TabIndex = 3;
            // 
            // btnResultado
            // 
            btnResultado.AutoSize = true;
            btnResultado.Location = new Point(35, 209);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(59, 15);
            btnResultado.TabIndex = 2;
            btnResultado.Text = "Resultado";
            // 
            // btnSegundoNumero
            // 
            btnSegundoNumero.AutoSize = true;
            btnSegundoNumero.Location = new Point(32, 109);
            btnSegundoNumero.Name = "btnSegundoNumero";
            btnSegundoNumero.Size = new Size(99, 15);
            btnSegundoNumero.TabIndex = 1;
            btnSegundoNumero.Text = "Segundo número";
            // 
            // btnPrimeiroNumero
            // 
            btnPrimeiroNumero.AutoSize = true;
            btnPrimeiroNumero.Location = new Point(35, 21);
            btnPrimeiroNumero.Name = "btnPrimeiroNumero";
            btnPrimeiroNumero.Size = new Size(97, 15);
            btnPrimeiroNumero.TabIndex = 0;
            btnPrimeiroNumero.Text = "Primeiro número";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(btnSubtrair);
            tabPage2.Controls.Add(txtResultadoSubtracao);
            tabPage2.Controls.Add(txtNum2SubTab2);
            tabPage2.Controls.Add(txtNum1SubTab2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(483, 274);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Subtrair";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 78);
            label1.Name = "label1";
            label1.Size = new Size(16, 24);
            label1.TabIndex = 15;
            label1.Text = "-";
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(356, 129);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 14;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // txtResultadoSubtracao
            // 
            txtResultadoSubtracao.Location = new Point(54, 229);
            txtResultadoSubtracao.Name = "txtResultadoSubtracao";
            txtResultadoSubtracao.ReadOnly = true;
            txtResultadoSubtracao.Size = new Size(193, 23);
            txtResultadoSubtracao.TabIndex = 13;
            // 
            // txtNum2SubTab2
            // 
            txtNum2SubTab2.Location = new Point(51, 129);
            txtNum2SubTab2.Name = "txtNum2SubTab2";
            txtNum2SubTab2.Size = new Size(196, 23);
            txtNum2SubTab2.TabIndex = 12;
            // 
            // txtNum1SubTab2
            // 
            txtNum1SubTab2.Location = new Point(54, 41);
            txtNum1SubTab2.Name = "txtNum1SubTab2";
            txtNum1SubTab2.Size = new Size(196, 23);
            txtNum1SubTab2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 211);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 111);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 9;
            label3.Text = "Segundo número";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 23);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 8;
            label5.Text = "Primeiro número";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(btnMultiplicar);
            tabPage3.Controls.Add(txtResultadoMultiplicacao);
            tabPage3.Controls.Add(txtNum2MultTab3);
            tabPage3.Controls.Add(txtNum1MultTab3);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(483, 274);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Multiplicar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 78);
            label6.Name = "label6";
            label6.Size = new Size(24, 24);
            label6.TabIndex = 15;
            label6.Text = "X";
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(356, 129);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // txtResultadoMultiplicacao
            // 
            txtResultadoMultiplicacao.Location = new Point(54, 229);
            txtResultadoMultiplicacao.Name = "txtResultadoMultiplicacao";
            txtResultadoMultiplicacao.ReadOnly = true;
            txtResultadoMultiplicacao.Size = new Size(193, 23);
            txtResultadoMultiplicacao.TabIndex = 13;
            // 
            // txtNum2MultTab3
            // 
            txtNum2MultTab3.Location = new Point(51, 129);
            txtNum2MultTab3.Name = "txtNum2MultTab3";
            txtNum2MultTab3.Size = new Size(196, 23);
            txtNum2MultTab3.TabIndex = 12;
            // 
            // txtNum1MultTab3
            // 
            txtNum1MultTab3.Location = new Point(54, 41);
            txtNum1MultTab3.Name = "txtNum1MultTab3";
            txtNum1MultTab3.Size = new Size(196, 23);
            txtNum1MultTab3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 211);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 10;
            label7.Text = "Resultado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 111);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 9;
            label8.Text = "Segundo número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 23);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 8;
            label9.Text = "Primeiro número";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(btnDividir);
            tabPage4.Controls.Add(txtResultadoDivisao);
            tabPage4.Controls.Add(txtNum2DivTab4);
            tabPage4.Controls.Add(txtNum1DivTab4);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label13);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(483, 274);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Dividir";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(114, 78);
            label10.Name = "label10";
            label10.Size = new Size(15, 24);
            label10.TabIndex = 15;
            label10.Text = "/";
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(356, 129);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 14;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // txtResultadoDivisao
            // 
            txtResultadoDivisao.Location = new Point(54, 229);
            txtResultadoDivisao.Name = "txtResultadoDivisao";
            txtResultadoDivisao.ReadOnly = true;
            txtResultadoDivisao.Size = new Size(193, 23);
            txtResultadoDivisao.TabIndex = 13;
            // 
            // txtNum2DivTab4
            // 
            txtNum2DivTab4.Location = new Point(51, 129);
            txtNum2DivTab4.Name = "txtNum2DivTab4";
            txtNum2DivTab4.Size = new Size(196, 23);
            txtNum2DivTab4.TabIndex = 12;
            // 
            // txtNum1DivTab4
            // 
            txtNum1DivTab4.Location = new Point(54, 41);
            txtNum1DivTab4.Name = "txtNum1DivTab4";
            txtNum1DivTab4.Size = new Size(196, 23);
            txtNum1DivTab4.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(54, 211);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 10;
            label11.Text = "Resultado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 111);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 9;
            label12.Text = "Segundo número";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(54, 23);
            label13.Name = "label13";
            label13.Size = new Size(97, 15);
            label13.TabIndex = 8;
            label13.Text = "Primeiro número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnSomar;
        private TextBox txtResultadoSoma;
        private TextBox txtNum2TabSomar;
        private TextBox txtNum1TabSomar;
        private Label btnResultado;
        private Label btnSegundoNumero;
        private Label btnPrimeiroNumero;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label4;
        private Label label1;
        private Button btnSubtrair;
        private TextBox txtResultadoSubtracao;
        private TextBox txtNum2SubTab2;
        private TextBox txtNum1SubTab2;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button btnMultiplicar;
        private TextBox txtResultadoMultiplicacao;
        private TextBox txtNum2MultTab3;
        private TextBox txtNum1MultTab3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnDividir;
        private TextBox txtResultadoDivisao;
        private TextBox txtNum2DivTab4;
        private TextBox txtNum1DivTab4;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
