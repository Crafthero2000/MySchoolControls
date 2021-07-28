namespace MySchoolControls
{
    partial class CommonInfo
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.dayOfTheWeekLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dayAndMonthLabel = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Century Schoolbook", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hoursLabel.Location = new System.Drawing.Point(3, 0);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(62, 44);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "12";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutesLabel.Location = new System.Drawing.Point(53, 0);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(27, 20);
            this.minutesLabel.TabIndex = 1;
            this.minutesLabel.Text = "00";
            // 
            // dayOfTheWeekLabel
            // 
            this.dayOfTheWeekLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayOfTheWeekLabel.AutoSize = true;
            this.dayOfTheWeekLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayOfTheWeekLabel.Location = new System.Drawing.Point(104, 0);
            this.dayOfTheWeekLabel.Name = "dayOfTheWeekLabel";
            this.dayOfTheWeekLabel.Size = new System.Drawing.Size(100, 20);
            this.dayOfTheWeekLabel.TabIndex = 2;
            this.dayOfTheWeekLabel.Text = "воскресенье";
            // 
            // yearLabel
            // 
            this.yearLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(104, 42);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(73, 20);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "2021 год";
            // 
            // dayAndMonthLabel
            // 
            this.dayAndMonthLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayAndMonthLabel.AutoSize = true;
            this.dayAndMonthLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayAndMonthLabel.Location = new System.Drawing.Point(104, 20);
            this.dayAndMonthLabel.Name = "dayAndMonthLabel";
            this.dayAndMonthLabel.Size = new System.Drawing.Size(90, 20);
            this.dayAndMonthLabel.TabIndex = 4;
            this.dayAndMonthLabel.Text = "1 сентября";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.balanceLabel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.balanceLabel.Location = new System.Drawing.Point(248, 0);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.balanceLabel.Size = new System.Drawing.Size(73, 19);
            this.balanceLabel.TabIndex = 6;
            this.balanceLabel.Text = "50 000 ₽";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.Location = new System.Drawing.Point(255, 21);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(63, 18);
            this.ratingLabel.TabIndex = 7;
            this.ratingLabel.Text = "☆☆☆☆☆";
            // 
            // CommonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.dayAndMonthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayOfTheWeekLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CommonInfo";
            this.Size = new System.Drawing.Size(321, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label dayOfTheWeekLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label dayAndMonthLabel;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label ratingLabel;
    }
}
