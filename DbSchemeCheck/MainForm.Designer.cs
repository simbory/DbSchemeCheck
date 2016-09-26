namespace DbSchemeCheck
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jsonFilePathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectFileDlalog = new System.Windows.Forms.OpenFileDialog();
            this.compairButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.targetGroupBox = new System.Windows.Forms.GroupBox();
            this.targetConnStringBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srcConnStringBox = new System.Windows.Forms.ComboBox();
            this.saveJsonFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.compareWorker = new System.ComponentModel.BackgroundWorker();
            this.exportWorker = new System.ComponentModel.BackgroundWorker();
            this.targetGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(692, 48);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 1;
            this.exportButton.Text = "导出表信息";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接字符串";
            // 
            // jsonFilePathBox
            // 
            this.jsonFilePathBox.Location = new System.Drawing.Point(77, 23);
            this.jsonFilePathBox.Name = "jsonFilePathBox";
            this.jsonFilePathBox.Size = new System.Drawing.Size(646, 21);
            this.jsonFilePathBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "表信息文件";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(729, 22);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(38, 23);
            this.selectFileButton.TabIndex = 3;
            this.selectFileButton.Text = "...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectFileDlalog
            // 
            this.selectFileDlalog.Filter = "Json文件|*.json";
            this.selectFileDlalog.Title = "选择架构文件(.json)";
            // 
            // compairButton
            // 
            this.compairButton.Location = new System.Drawing.Point(692, 100);
            this.compairButton.Name = "compairButton";
            this.compairButton.Size = new System.Drawing.Size(75, 23);
            this.compairButton.TabIndex = 5;
            this.compairButton.Text = "开始比较";
            this.compairButton.UseVisualStyleBackColor = true;
            this.compairButton.Click += new System.EventHandler(this.compairButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "连接字符串";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "或者";
            // 
            // targetGroupBox
            // 
            this.targetGroupBox.Controls.Add(this.targetConnStringBox);
            this.targetGroupBox.Controls.Add(this.label1);
            this.targetGroupBox.Controls.Add(this.exportButton);
            this.targetGroupBox.Location = new System.Drawing.Point(15, 13);
            this.targetGroupBox.Name = "targetGroupBox";
            this.targetGroupBox.Size = new System.Drawing.Size(773, 81);
            this.targetGroupBox.TabIndex = 14;
            this.targetGroupBox.TabStop = false;
            this.targetGroupBox.Text = "目标数据库";
            // 
            // targetConnStringBox
            // 
            this.targetConnStringBox.FormattingEnabled = true;
            this.targetConnStringBox.Location = new System.Drawing.Point(83, 20);
            this.targetConnStringBox.Name = "targetConnStringBox";
            this.targetConnStringBox.Size = new System.Drawing.Size(684, 20);
            this.targetConnStringBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srcConnStringBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.jsonFilePathBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.selectFileButton);
            this.groupBox1.Controls.Add(this.compairButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原数据库";
            // 
            // srcConnStringBox
            // 
            this.srcConnStringBox.FormattingEnabled = true;
            this.srcConnStringBox.Location = new System.Drawing.Point(77, 73);
            this.srcConnStringBox.Name = "srcConnStringBox";
            this.srcConnStringBox.Size = new System.Drawing.Size(690, 20);
            this.srcConnStringBox.TabIndex = 4;
            // 
            // saveJsonFileDialog
            // 
            this.saveJsonFileDialog.DefaultExt = "json";
            this.saveJsonFileDialog.Filter = "Json文件|*.json";
            this.saveJsonFileDialog.Title = "保存表信息";
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputBox);
            this.outputGroupBox.Location = new System.Drawing.Point(15, 244);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(773, 198);
            this.outputGroupBox.TabIndex = 16;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "输出";
            // 
            // outputBox
            // 
            this.outputBox.ForeColor = System.Drawing.Color.Black;
            this.outputBox.Location = new System.Drawing.Point(8, 20);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(759, 172);
            this.outputBox.TabIndex = 6;
            this.outputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.outputBox_KeyDown);
            // 
            // compareWorker
            // 
            this.compareWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.compareWorker_DoWork);
            this.compareWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.compareWorker_RunWorkerCompleted);
            // 
            // exportWorker
            // 
            this.exportWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.exportWorker_DoWork);
            this.exportWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.compareWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.targetGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 493);
            this.MinimumSize = new System.Drawing.Size(816, 493);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库架构比较工具";
            this.targetGroupBox.ResumeLayout(false);
            this.targetGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jsonFilePathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog selectFileDlalog;
        private System.Windows.Forms.Button compairButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox targetGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveJsonFileDialog;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.ComponentModel.BackgroundWorker compareWorker;
        private System.ComponentModel.BackgroundWorker exportWorker;
        private System.Windows.Forms.ComboBox targetConnStringBox;
        private System.Windows.Forms.ComboBox srcConnStringBox;
    }
}

