namespace Drowing
{
    partial class mainWind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWind));
            this.exit = new System.Windows.Forms.Button();
            this.settingsBtt = new System.Windows.Forms.Button();
            this.StartGameBtt = new System.Windows.Forms.Button();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.ScoreTxt = new System.Windows.Forms.Label();
            this.rePainted1 = new Drowing.RePainted();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackgroundImage = global::Drowing.Properties.Resources.exit_btt;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(752, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 36);
            this.exit.TabIndex = 1;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // settingsBtt
            // 
            this.settingsBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtt.Location = new System.Drawing.Point(12, 661);
            this.settingsBtt.Name = "settingsBtt";
            this.settingsBtt.Size = new System.Drawing.Size(130, 33);
            this.settingsBtt.TabIndex = 2;
            this.settingsBtt.Text = "settings";
            this.settingsBtt.UseVisualStyleBackColor = true;
            this.settingsBtt.Click += new System.EventHandler(this.settingsBtt_Click);
            // 
            // StartGameBtt
            // 
            this.StartGameBtt.BackColor = System.Drawing.Color.Black;
            this.StartGameBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.StartGameBtt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StartGameBtt.Location = new System.Drawing.Point(12, 356);
            this.StartGameBtt.Name = "StartGameBtt";
            this.StartGameBtt.Size = new System.Drawing.Size(130, 39);
            this.StartGameBtt.TabIndex = 3;
            this.StartGameBtt.Text = "START";
            this.StartGameBtt.UseVisualStyleBackColor = false;
            this.StartGameBtt.Click += new System.EventHandler(this.StartGameBtt_Click);
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.Color.Black;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.scoreBox.Location = new System.Drawing.Point(12, 54);
            this.scoreBox.Multiline = true;
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.Size = new System.Drawing.Size(130, 33);
            this.scoreBox.TabIndex = 4;
            this.scoreBox.Text = "0";
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.AutoSize = true;
            this.ScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScoreTxt.Location = new System.Drawing.Point(8, 27);
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(76, 24);
            this.ScoreTxt.TabIndex = 6;
            this.ScoreTxt.Text = "SCORE";
            // 
            // rePainted1
            // 
            this.rePainted1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rePainted1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rePainted1.BackgroundImage")));
            this.rePainted1.Location = new System.Drawing.Point(148, 54);
            this.rePainted1.Name = "rePainted1";
            this.rePainted1.Size = new System.Drawing.Size(640, 640);
            this.rePainted1.TabIndex = 7;
            // 
            // mainWind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.exit;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.rePainted1);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.StartGameBtt);
            this.Controls.Add(this.settingsBtt);
            this.Controls.Add(this.exit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 706);
            this.Name = "mainWind";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainWind_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button settingsBtt;
        private System.Windows.Forms.Button StartGameBtt;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label ScoreTxt;
        private RePainted rePainted1;
    }
}

