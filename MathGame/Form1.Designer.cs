
namespace MathGame
{
    partial class mathGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mathGame));
            this.timeLeftTextBox = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.equalSign = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusSign = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.equalSignTwo = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.multiplySign = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.equalSignThree = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.dividedSign = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.equalSignFour = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLeftTextBox
            // 
            this.timeLeftTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.timeLeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTextBox.Location = new System.Drawing.Point(606, 9);
            this.timeLeftTextBox.Name = "timeLeftTextBox";
            this.timeLeftTextBox.Size = new System.Drawing.Size(135, 30);
            this.timeLeftTextBox.TabIndex = 1;
            this.timeLeftTextBox.Text = "Time Left";
            this.timeLeftTextBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.BackColor = System.Drawing.SystemColors.Window;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(28, 72);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(68, 45);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plusSign
            // 
            this.plusSign.BackColor = System.Drawing.SystemColors.Window;
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(127, 72);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(68, 45);
            this.plusSign.TabIndex = 3;
            this.plusSign.Text = "+";
            this.plusSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.BackColor = System.Drawing.SystemColors.Window;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(237, 72);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(68, 45);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // equalSign
            // 
            this.equalSign.BackColor = System.Drawing.SystemColors.Window;
            this.equalSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign.Location = new System.Drawing.Point(337, 72);
            this.equalSign.Name = "equalSign";
            this.equalSign.Size = new System.Drawing.Size(68, 45);
            this.equalSign.TabIndex = 5;
            this.equalSign.Text = "=";
            this.equalSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.Info;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(443, 72);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 45);
            this.sum.TabIndex = 2;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.BackColor = System.Drawing.SystemColors.Window;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(28, 157);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(68, 45);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minusSign
            // 
            this.minusSign.BackColor = System.Drawing.SystemColors.Window;
            this.minusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusSign.Location = new System.Drawing.Point(127, 157);
            this.minusSign.Name = "minusSign";
            this.minusSign.Size = new System.Drawing.Size(68, 45);
            this.minusSign.TabIndex = 8;
            this.minusSign.Text = "-";
            this.minusSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.BackColor = System.Drawing.SystemColors.Window;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(237, 157);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(68, 45);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // equalSignTwo
            // 
            this.equalSignTwo.BackColor = System.Drawing.SystemColors.Window;
            this.equalSignTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignTwo.Location = new System.Drawing.Point(337, 157);
            this.equalSignTwo.Name = "equalSignTwo";
            this.equalSignTwo.Size = new System.Drawing.Size(68, 45);
            this.equalSignTwo.TabIndex = 10;
            this.equalSignTwo.Text = "=";
            this.equalSignTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // difference
            // 
            this.difference.BackColor = System.Drawing.SystemColors.Info;
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(443, 157);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(75, 45);
            this.difference.TabIndex = 3;
            this.difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.difference.Enter += new System.EventHandler(this.Answer_Enter2);
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.BackColor = System.Drawing.SystemColors.Window;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(28, 233);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(68, 45);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // multiplySign
            // 
            this.multiplySign.BackColor = System.Drawing.SystemColors.Window;
            this.multiplySign.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplySign.Location = new System.Drawing.Point(127, 233);
            this.multiplySign.Name = "multiplySign";
            this.multiplySign.Size = new System.Drawing.Size(68, 45);
            this.multiplySign.TabIndex = 13;
            this.multiplySign.Text = "x";
            this.multiplySign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.BackColor = System.Drawing.SystemColors.Window;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(237, 233);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(68, 45);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // equalSignThree
            // 
            this.equalSignThree.BackColor = System.Drawing.SystemColors.Window;
            this.equalSignThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignThree.Location = new System.Drawing.Point(337, 233);
            this.equalSignThree.Name = "equalSignThree";
            this.equalSignThree.Size = new System.Drawing.Size(68, 45);
            this.equalSignThree.TabIndex = 15;
            this.equalSignThree.Text = "=";
            this.equalSignThree.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // product
            // 
            this.product.BackColor = System.Drawing.SystemColors.Info;
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(443, 233);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(75, 45);
            this.product.TabIndex = 4;
            this.product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product.Enter += new System.EventHandler(this.Answer_Enter3);
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.BackColor = System.Drawing.SystemColors.Window;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(28, 312);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(68, 45);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dividedSign
            // 
            this.dividedSign.BackColor = System.Drawing.SystemColors.Window;
            this.dividedSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedSign.Location = new System.Drawing.Point(127, 312);
            this.dividedSign.Name = "dividedSign";
            this.dividedSign.Size = new System.Drawing.Size(68, 45);
            this.dividedSign.TabIndex = 18;
            this.dividedSign.Text = "÷";
            this.dividedSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.BackColor = System.Drawing.SystemColors.Window;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(237, 310);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(68, 45);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // equalSignFour
            // 
            this.equalSignFour.BackColor = System.Drawing.SystemColors.Window;
            this.equalSignFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignFour.Location = new System.Drawing.Point(337, 310);
            this.equalSignFour.Name = "equalSignFour";
            this.equalSignFour.Size = new System.Drawing.Size(68, 45);
            this.equalSignFour.TabIndex = 20;
            this.equalSignFour.Text = "=";
            this.equalSignFour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quotient
            // 
            this.quotient.BackColor = System.Drawing.SystemColors.Info;
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(443, 308);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(75, 45);
            this.quotient.TabIndex = 5;
            this.quotient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quotient.Enter += new System.EventHandler(this.Answer_Enter4);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 386);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(240, 52);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(747, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(169, 30);
            this.timeLabel.TabIndex = 21;
            // 
            // endButton
            // 
            this.endButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.Location = new System.Drawing.Point(278, 386);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(240, 52);
            this.endButton.TabIndex = 22;
            this.endButton.Text = "Finish Game";
            this.endButton.UseVisualStyleBackColor = false;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // mathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.equalSignFour);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedSign);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.equalSignThree);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.multiplySign);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.equalSignTwo);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusSign);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.equalSign);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mathGame";
            this.Text = "MathGame by Jalal";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label timeLeftTextBox;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label equalSign;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusSign;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label equalSignTwo;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label multiplySign;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label equalSignThree;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label dividedSign;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label equalSignFour;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button endButton;
    }
}

