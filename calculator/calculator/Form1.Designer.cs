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
            this.BtnTg = new System.Windows.Forms.Button();
            this.BtnCtg = new System.Windows.Forms.Button();
            this.BtnPowSquare = new System.Windows.Forms.Button();
            this.BtnRootSquare = new System.Windows.Forms.Button();
            this.BtnPow = new System.Windows.Forms.Button();
            this.BtnRoot = new System.Windows.Forms.Button();
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
            this.TBArg2.Location = new System.Drawing.Point(12, 80);
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
            this.LblArg2.Location = new System.Drawing.Point(12, 61);
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
            this.BtnSub.Location = new System.Drawing.Point(250, 30);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(23, 23);
            this.BtnSub.TabIndex = 5;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(221, 80);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(23, 23);
            this.BtnMul.TabIndex = 6;
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(250, 80);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(23, 23);
            this.BtnDiv.TabIndex = 7;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.Button_Click);
            // 
            // TBRes
            // 
            this.TBRes.Location = new System.Drawing.Point(169, 146);
            this.TBRes.Name = "TBRes";
            this.TBRes.Size = new System.Drawing.Size(183, 20);
            this.TBRes.TabIndex = 8;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(226, 130);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(59, 13);
            this.LblRes.TabIndex = 9;
            this.LblRes.Text = "Результат";
            // 
            // BtnCos
            // 
            this.BtnCos.Location = new System.Drawing.Point(420, 80);
            this.BtnCos.Name = "BtnCos";
            this.BtnCos.Size = new System.Drawing.Size(38, 23);
            this.BtnCos.TabIndex = 10;
            this.BtnCos.Text = "Cos";
            this.BtnCos.UseVisualStyleBackColor = true;
            this.BtnCos.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnSin
            // 
            this.BtnSin.Location = new System.Drawing.Point(420, 30);
            this.BtnSin.Name = "BtnSin";
            this.BtnSin.Size = new System.Drawing.Size(38, 23);
            this.BtnSin.TabIndex = 11;
            this.BtnSin.Text = "Sin";
            this.BtnSin.UseVisualStyleBackColor = true;
            this.BtnSin.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnTg
            // 
            this.BtnTg.Location = new System.Drawing.Point(464, 30);
            this.BtnTg.Name = "BtnTg";
            this.BtnTg.Size = new System.Drawing.Size(38, 23);
            this.BtnTg.TabIndex = 13;
            this.BtnTg.Text = "Tg";
            this.BtnTg.UseVisualStyleBackColor = true;
            this.BtnTg.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnCtg
            // 
            this.BtnCtg.Location = new System.Drawing.Point(464, 80);
            this.BtnCtg.Name = "BtnCtg";
            this.BtnCtg.Size = new System.Drawing.Size(38, 23);
            this.BtnCtg.TabIndex = 12;
            this.BtnCtg.Text = "Ctg";
            this.BtnCtg.UseVisualStyleBackColor = true;
            this.BtnCtg.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnPowSquare
            // 
            this.BtnPowSquare.Location = new System.Drawing.Point(293, 30);
            this.BtnPowSquare.Name = "BtnPowSquare";
            this.BtnPowSquare.Size = new System.Drawing.Size(50, 23);
            this.BtnPowSquare.TabIndex = 15;
            this.BtnPowSquare.Text = "x^2";
            this.BtnPowSquare.UseVisualStyleBackColor = true;
            this.BtnPowSquare.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnRootSquare
            // 
            this.BtnRootSquare.Location = new System.Drawing.Point(293, 80);
            this.BtnRootSquare.Name = "BtnRootSquare";
            this.BtnRootSquare.Size = new System.Drawing.Size(50, 23);
            this.BtnRootSquare.TabIndex = 14;
            this.BtnRootSquare.Text = "x^(1/2)";
            this.BtnRootSquare.UseVisualStyleBackColor = true;
            this.BtnRootSquare.Click += new System.EventHandler(this.Button_Click2);
            // 
            // BtnPow
            // 
            this.BtnPow.Location = new System.Drawing.Point(349, 30);
            this.BtnPow.Name = "BtnPow";
            this.BtnPow.Size = new System.Drawing.Size(50, 23);
            this.BtnPow.TabIndex = 17;
            this.BtnPow.Text = "x^y";
            this.BtnPow.UseVisualStyleBackColor = true;
            this.BtnPow.Click += new System.EventHandler(this.Button_Click);
            // 
            // BtnRoot
            // 
            this.BtnRoot.Location = new System.Drawing.Point(349, 80);
            this.BtnRoot.Name = "BtnRoot";
            this.BtnRoot.Size = new System.Drawing.Size(50, 23);
            this.BtnRoot.TabIndex = 16;
            this.BtnRoot.Text = "x^(1/y)";
            this.BtnRoot.UseVisualStyleBackColor = true;
            this.BtnRoot.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 178);
            this.Controls.Add(this.BtnPow);
            this.Controls.Add(this.BtnRoot);
            this.Controls.Add(this.BtnPowSquare);
            this.Controls.Add(this.BtnRootSquare);
            this.Controls.Add(this.BtnTg);
            this.Controls.Add(this.BtnCtg);
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
        private System.Windows.Forms.Button BtnTg;
        private System.Windows.Forms.Button BtnCtg;
        private System.Windows.Forms.Button BtnPowSquare;
        private System.Windows.Forms.Button BtnRootSquare;
        private System.Windows.Forms.Button BtnPow;
        private System.Windows.Forms.Button BtnRoot;
    }
}

