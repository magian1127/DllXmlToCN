namespace DllXmlToCN
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox目标 = new System.Windows.Forms.TextBox();
            this.textBox源 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(599, 294);
            this.textBox1.TabIndex = 42;
            // 
            // textBox目标
            // 
            this.textBox目标.Location = new System.Drawing.Point(72, 41);
            this.textBox目标.Name = "textBox目标";
            this.textBox目标.Size = new System.Drawing.Size(459, 21);
            this.textBox目标.TabIndex = 41;
            // 
            // textBox源
            // 
            this.textBox源.Location = new System.Drawing.Point(72, 12);
            this.textBox源.Name = "textBox源";
            this.textBox源.Size = new System.Drawing.Size(459, 21);
            this.textBox源.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 39;
            this.label2.Text = "目标";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "源";
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(13, 368);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(288, 16);
            this.checkBoxE.TabIndex = 37;
            this.checkBoxE.Text = "合并未用的原目标中的元素(填写合并后的文件名)";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(14, 390);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 36;
            this.buttonDiv.Text = "读取目录";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 419);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 10);
            this.progressBar1.TabIndex = 35;
            this.progressBar1.Visible = false;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(537, 12);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 21);
            this.buttonS.TabIndex = 34;
            this.buttonS.Text = "选择源";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(537, 41);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(75, 21);
            this.buttonT.TabIndex = 33;
            this.buttonT.Text = "选择目标";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(95, 390);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 32;
            this.buttonStart.Text = "执行覆盖";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(307, 368);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(305, 21);
            this.textBoxFile.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox目标);
            this.Controls.Add(this.textBox源);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxE);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "DLL注释XML替换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox目标;
        private System.Windows.Forms.TextBox textBox源;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxFile;
    }
}

