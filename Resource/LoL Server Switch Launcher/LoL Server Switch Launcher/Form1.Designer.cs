namespace LoL_Server_Switch_Launcher
{
    partial class lancherForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lancherForm));
            this.Button_selectFilePath = new System.Windows.Forms.Button();
            this.RadioButton_defaultHost = new System.Windows.Forms.RadioButton();
            this.RadioButton_matchHost = new System.Windows.Forms.RadioButton();
            this.RadioButton_testHost = new System.Windows.Forms.RadioButton();
            this.Label_filePath = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Button_startGame = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Button_selectFilePath
            // 
            this.Button_selectFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_selectFilePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_selectFilePath.Location = new System.Drawing.Point(14, 13);
            this.Button_selectFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_selectFilePath.Name = "Button_selectFilePath";
            this.Button_selectFilePath.Size = new System.Drawing.Size(122, 36);
            this.Button_selectFilePath.TabIndex = 0;
            this.Button_selectFilePath.Text = "选择配置文件路径";
            this.Button_selectFilePath.UseVisualStyleBackColor = true;
            this.Button_selectFilePath.Click += new System.EventHandler(this.Button_selectFilePath_Click);
            // 
            // RadioButton_defaultHost
            // 
            this.RadioButton_defaultHost.AutoSize = true;
            this.RadioButton_defaultHost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton_defaultHost.Location = new System.Drawing.Point(15, 87);
            this.RadioButton_defaultHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton_defaultHost.Name = "RadioButton_defaultHost";
            this.RadioButton_defaultHost.Size = new System.Drawing.Size(62, 21);
            this.RadioButton_defaultHost.TabIndex = 1;
            this.RadioButton_defaultHost.TabStop = true;
            this.RadioButton_defaultHost.Tag = "default";
            this.RadioButton_defaultHost.Text = "正式服";
            this.RadioButton_defaultHost.UseVisualStyleBackColor = true;
            this.RadioButton_defaultHost.Click += new System.EventHandler(this.RadioButton_defaultHost_Click);
            // 
            // RadioButton_matchHost
            // 
            this.RadioButton_matchHost.AutoSize = true;
            this.RadioButton_matchHost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton_matchHost.Location = new System.Drawing.Point(83, 87);
            this.RadioButton_matchHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton_matchHost.Name = "RadioButton_matchHost";
            this.RadioButton_matchHost.Size = new System.Drawing.Size(62, 21);
            this.RadioButton_matchHost.TabIndex = 2;
            this.RadioButton_matchHost.TabStop = true;
            this.RadioButton_matchHost.Tag = "match";
            this.RadioButton_matchHost.Text = "比赛服";
            this.RadioButton_matchHost.UseVisualStyleBackColor = true;
            this.RadioButton_matchHost.Click += new System.EventHandler(this.RadioButton_matchHost_Click);
            // 
            // RadioButton_testHost
            // 
            this.RadioButton_testHost.AutoSize = true;
            this.RadioButton_testHost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RadioButton_testHost.Location = new System.Drawing.Point(151, 87);
            this.RadioButton_testHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RadioButton_testHost.Name = "RadioButton_testHost";
            this.RadioButton_testHost.Size = new System.Drawing.Size(62, 21);
            this.RadioButton_testHost.TabIndex = 3;
            this.RadioButton_testHost.TabStop = true;
            this.RadioButton_testHost.Tag = "test";
            this.RadioButton_testHost.Text = "测试服";
            this.RadioButton_testHost.UseVisualStyleBackColor = true;
            this.RadioButton_testHost.Click += new System.EventHandler(this.RadioButton_testHost_Click);
            // 
            // Label_filePath
            // 
            this.Label_filePath.AutoSize = true;
            this.Label_filePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_filePath.Location = new System.Drawing.Point(12, 56);
            this.Label_filePath.Name = "Label_filePath";
            this.Label_filePath.Size = new System.Drawing.Size(36, 17);
            this.Label_filePath.TabIndex = 4;
            this.Label_filePath.Text = "label";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "abc";
            this.notifyIcon.BalloonTipTitle = "123";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LoL Server Switch Lancher";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // Button_startGame
            // 
            this.Button_startGame.BackgroundImage = global::LoL_Server_Switch_Launcher.Properties.Resources._40;
            this.Button_startGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_startGame.Location = new System.Drawing.Point(274, 79);
            this.Button_startGame.Name = "Button_startGame";
            this.Button_startGame.Size = new System.Drawing.Size(36, 36);
            this.Button_startGame.TabIndex = 5;
            this.Button_startGame.UseVisualStyleBackColor = true;
            this.Button_startGame.Click += new System.EventHandler(this.Button_startGame_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(235, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Let\'s Gank";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lancherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(319, 125);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Button_startGame);
            this.Controls.Add(this.Label_filePath);
            this.Controls.Add(this.RadioButton_testHost);
            this.Controls.Add(this.RadioButton_matchHost);
            this.Controls.Add(this.RadioButton_defaultHost);
            this.Controls.Add(this.Button_selectFilePath);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "lancherForm";
            this.Text = "LoL 服务器便捷切换启动器";
            this.SizeChanged += new System.EventHandler(this.lancherForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_selectFilePath;
        private System.Windows.Forms.RadioButton RadioButton_defaultHost;
        private System.Windows.Forms.RadioButton RadioButton_matchHost;
        private System.Windows.Forms.RadioButton RadioButton_testHost;
        private System.Windows.Forms.Label Label_filePath;
        private System.Windows.Forms.Button Button_startGame;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

