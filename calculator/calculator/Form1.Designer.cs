namespace calculator
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
            this.TBArg1 = new System.Windows.Forms.TextBox();
            this.TBArg2 = new System.Windows.Forms.TextBox();
            this.LblArg1 = new System.Windows.Forms.Label();
            this.LblArg2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.TBRes = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnCos = new System.Windows.Forms.Button();
            this.BtnSin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBArg1
            // 
            this.TBArg1.Location = new System.Drawing.Point(12, 32);
            this.TBArg1.Name = "TBArg1";
            this.TBArg1.Size = new System.Drawing.Size(183, 20);
            this.TBArg1.TabIndex = 0;
            // 
            // TBArg2
            // 
            this.TBArg2.Location = new System.Drawing.Point(12, 86);
            this.TBArg2.Name = "TBArg2";
            this.TBArg2.Size = new System.Drawing.Size(183, 20);
            this.TBArg2.TabIndex = 1;
            // 
            // LblArg1
            // 
            this.LblArg1.AutoSize = true;
            this.LblArg1.Location = new System.Drawing.Point(12, 13);
            this.LblArg1.Name = "LblArg1";
            this.LblArg1.Size = new System.Drawing.Size(64, 13);
            this.LblArg1.TabIndex = 2;
            this.LblArg1.Text = "Аргумент 1";
            // 
            // LblArg2
            // 
            this.LblArg2.AutoSize = true;
            this.LblArg2.Location = new System.Drawing.Point(12, 67);
            this.LblArg2.Name = "LblArg2";
            this.LblArg2.Size = new System.Drawing.Size(64, 13);
            this.LblArg2.TabIndex = 3;
            this.LblArg2.Text = "Аргумент 2";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(221, 30);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(23, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(276, 30);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(23, 23);
            this.BtnSub.TabIndex = 5;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(221, 86);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(23, 23);
            this.BtnMul.TabIndex = 6;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(276, 86);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(23, 23);
            this.BtnDiv.TabIndex = 7;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.Button_Click);
            // 
            // TBRes
            // 
            this.TBRes.Location = new System.Drawing.Point(15, 159);
            this.TBRes.Name = "TBRes";
            this.TBRes.Size = new System.Drawing.Size(183, 20);
            this.TBRes.TabIndex = 8;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(17, 138);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(59, 13);
            this.LblRes.TabIndex = 9;
            this.LblRes.Text = "Результат";
            // 
            // BtnCos
            // 
            this.BtnCos.Location = new System.Drawing.Point(327, 86);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(38, 23);
            this.BtnCos.TabIndex = 10;
            this.BtnCos.Text = "Cos";
            this.BtnCos.UseVisualStyleBackColor = true;
            this.BtnCos.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnSin
            // 
            this.BtnSin.Location = new System.Drawing.Point(327, 30);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(38, 23);
            this.BtnSin.TabIndex = 11;
            this.BtnSin.Text = "Sin";
            this.BtnSin.UseVisualStyleBackColor = true;
            this.BtnSin.Click += new System.EventHandler(this.Button_Click2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 193);
            this.Controls.Add(this.BtnSin);
            this.Controls.Add(this.BtnCos);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.TBRes);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMul);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblArg2);
            this.Controls.Add(this.LblArg1);
            this.Controls.Add(this.TBArg2);
            this.Controls.Add(this.TBArg1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBArg1;
        private System.Windows.Forms.TextBox TBArg2;
        private System.Windows.Forms.Label LblArg1;
        private System.Windows.Forms.Label LblArg2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.TextBox TBRes;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCos;
        private System.Windows.Forms.Button BtnSin;
    }
}

