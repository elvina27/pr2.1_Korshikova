namespace Практическая__2__1_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.lblX0 = new System.Windows.Forms.Label();
            this.lblXk = new System.Windows.Forms.Label();
            this.lblDx = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtXk = new System.Windows.Forms.TextBox();
            this.txtDx = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.Location = new System.Drawing.Point(184, 667);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(133, 29);
            this.btn.TabIndex = 0;
            this.btn.Text = "Вычислить";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX0.Location = new System.Drawing.Point(28, 27);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(44, 20);
            this.lblX0.TabIndex = 1;
            this.lblX0.Text = "X0 =";
            // 
            // lblXk
            // 
            this.lblXk.AutoSize = true;
            this.lblXk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblXk.Location = new System.Drawing.Point(28, 68);
            this.lblXk.Name = "lblXk";
            this.lblXk.Size = new System.Drawing.Size(43, 20);
            this.lblXk.TabIndex = 2;
            this.lblXk.Text = "Xk =";
            // 
            // lblDx
            // 
            this.lblDx.AutoSize = true;
            this.lblDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDx.Location = new System.Drawing.Point(28, 111);
            this.lblDx.Name = "lblDx";
            this.lblDx.Size = new System.Drawing.Size(45, 20);
            this.lblDx.TabIndex = 3;
            this.lblDx.Text = "Dx =";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.Location = new System.Drawing.Point(28, 153);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(35, 20);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "A =";
            // 
            // txtX0
            // 
            this.txtX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtX0.Location = new System.Drawing.Point(79, 24);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(155, 27);
            this.txtX0.TabIndex = 5;
            // 
            // txtXk
            // 
            this.txtXk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXk.Location = new System.Drawing.Point(79, 65);
            this.txtXk.Name = "txtXk";
            this.txtXk.Size = new System.Drawing.Size(155, 27);
            this.txtXk.TabIndex = 6;
            // 
            // txtDx
            // 
            this.txtDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDx.Location = new System.Drawing.Point(79, 104);
            this.txtDx.Name = "txtDx";
            this.txtDx.Size = new System.Drawing.Size(155, 27);
            this.txtDx.TabIndex = 7;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtA.Location = new System.Drawing.Point(79, 146);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(155, 27);
            this.txtA.TabIndex = 8;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt.Location = new System.Drawing.Point(31, 196);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(432, 447);
            this.txt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 708);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtDx);
            this.Controls.Add(this.txtXk);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDx);
            this.Controls.Add(this.lblXk);
            this.Controls.Add(this.lblX0);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.Label lblXk;
        private System.Windows.Forms.Label lblDx;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtXk;
        private System.Windows.Forms.TextBox txtDx;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txt;
    }
}

