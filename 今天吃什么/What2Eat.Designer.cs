namespace 今天吃什么
{
    partial class What2Eat
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
            this.slogan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slogan.Location = new System.Drawing.Point(25, 55);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(250, 21);
            this.slogan.TabIndex = 0;
            this.slogan.Text = "不知道吃什么？试试我的推荐吧！";
            this.slogan.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(110, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "吃什么";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // What2Eat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.CloseBoxSize = new System.Drawing.Size(15, 15);
            this.CloseDownBack = global::今天吃什么.Properties.Resources.winfo_icon_关闭;
            this.CloseMouseBack = global::今天吃什么.Properties.Resources.Close_Red;
            this.CloseNormlBack = global::今天吃什么.Properties.Resources.winfo_icon_关闭;
            this.ControlBoxOffset = new System.Drawing.Point(12, 12);
            this.ControlBoxSpace = 10;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.slogan);
            this.MaxDownBack = global::今天吃什么.Properties.Resources.winfo_icon_最大化;
            this.MaxMouseBack = global::今天吃什么.Properties.Resources.winfo_icon_最大化;
            this.MaxNormlBack = global::今天吃什么.Properties.Resources.winfo_icon_最大化;
            this.MaxSize = new System.Drawing.Size(15, 15);
            this.MiniDownBack = global::今天吃什么.Properties.Resources.winfo_icon_最小化;
            this.MiniMouseBack = global::今天吃什么.Properties.Resources.winfo_icon_最小化;
            this.MiniNormlBack = global::今天吃什么.Properties.Resources.winfo_icon_最小化;
            this.MiniSize = new System.Drawing.Size(15, 15);
            this.Name = "What2Eat";
            this.RestoreDownBack = global::今天吃什么.Properties.Resources.winfo_icon_最大化;
            this.RestoreMouseBack = global::今天吃什么.Properties.Resources.winfo_icon_最大化;
            this.RestoreNormlBack = global::今天吃什么.Properties.Resources.winfo_icon_最大化;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.Shadow = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.Text = "吃什么";
            this.TitleOffset = new System.Drawing.Point(8, 8);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Button button1;
    }
}

