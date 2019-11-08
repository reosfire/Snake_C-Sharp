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
            this.hideBtt = new System.Windows.Forms.Button();
            this.rePainted1 = new Drowing.RePainted();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(752, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 36);
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Text = "X";
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
            this.settingsBtt.TabStop = false;
            this.settingsBtt.Text = "settings";
            this.settingsBtt.UseVisualStyleBackColor = true;
            this.settingsBtt.Click += new System.EventHandler(this.settingsBtt_Click);
            // 
            // StartGameBtt
            // 
            this.StartGameBtt.BackColor = System.Drawing.Color.Black;
            this.StartGameBtt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StartGameBtt.FlatAppearance.BorderSize = 2;
            this.StartGameBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameBtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.StartGameBtt.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StartGameBtt.Location = new System.Drawing.Point(12, 356);
            this.StartGameBtt.Name = "StartGameBtt";
            this.StartGameBtt.Size = new System.Drawing.Size(130, 39);
            this.StartGameBtt.TabIndex = 3;
            this.StartGameBtt.TabStop = false;
            this.StartGameBtt.Text = "START";
            this.StartGameBtt.UseVisualStyleBackColor = false;
            this.StartGameBtt.Click += new System.EventHandler(this.StartGameBtt_Click);
            // 
            // scoreBox
            // 
            this.scoreBox.BackColor = System.Drawing.Color.Black;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreBox.Location = new System.Drawing.Point(12, 54);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.ReadOnly = true;
            this.scoreBox.ShortcutsEnabled = false;
            this.scoreBox.Size = new System.Drawing.Size(130, 35);
            this.scoreBox.TabIndex = 4;
            this.scoreBox.TabStop = false;
            this.scoreBox.Text = "0";
            this.scoreBox.WordWrap = false;
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
            // hideBtt
            // 
            this.hideBtt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideBtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hideBtt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hideBtt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.hideBtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtt.Font = new System.Drawing.Font("Miriam CLM", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hideBtt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideBtt.Location = new System.Drawing.Point(710, 12);
            this.hideBtt.Name = "hideBtt";
            this.hideBtt.Size = new System.Drawing.Size(36, 36);
            this.hideBtt.TabIndex = 8;
            this.hideBtt.TabStop = false;
            this.hideBtt.Text = "_";
            this.hideBtt.UseVisualStyleBackColor = true;
            this.hideBtt.Click += new System.EventHandler(this.hideBtt_Click);
            // 
            // rePainted1
            // 
            this.rePainted1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rePainted1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rePainted1.BackgroundImage")));
            this.rePainted1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rePainted1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rePainted1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.Controls.Add(this.hideBtt);
            this.Controls.Add(this.rePainted1);
            this.Controls.Add(this.ScoreTxt);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.StartGameBtt);
            this.Controls.Add(this.settingsBtt);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 706);
            this.Name = "mainWind";
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
        private System.Windows.Forms.Button hideBtt;
    }
}

