
namespace Calculater
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.screenLabel = new System.Windows.Forms.Label();
            this.number1Button = new System.Windows.Forms.Button();
            this.number2Button = new System.Windows.Forms.Button();
            this.number3Button = new System.Windows.Forms.Button();
            this.number4Button = new System.Windows.Forms.Button();
            this.number5Button = new System.Windows.Forms.Button();
            this.number6Button = new System.Windows.Forms.Button();
            this.number7Button = new System.Windows.Forms.Button();
            this.number8Button = new System.Windows.Forms.Button();
            this.number9Button = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.number0Button = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.devide = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.extraction = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // screenLabel
            // 
            this.screenLabel.BackColor = System.Drawing.Color.White;
            this.screenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.screenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.screenLabel.Location = new System.Drawing.Point(12, 24);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(318, 59);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "0";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.screenLabel.Click += new System.EventHandler(this.la_Click);
            // 
            // number1Button
            // 
            this.number1Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number1Button.Location = new System.Drawing.Point(12, 95);
            this.number1Button.Name = "number1Button";
            this.number1Button.Size = new System.Drawing.Size(75, 75);
            this.number1Button.TabIndex = 1;
            this.number1Button.Text = "1";
            this.number1Button.UseVisualStyleBackColor = false;
            this.number1Button.Click += new System.EventHandler(this.number1Button_Click);
            // 
            // number2Button
            // 
            this.number2Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number2Button.Location = new System.Drawing.Point(93, 95);
            this.number2Button.Name = "number2Button";
            this.number2Button.Size = new System.Drawing.Size(75, 75);
            this.number2Button.TabIndex = 2;
            this.number2Button.Text = "2";
            this.number2Button.UseVisualStyleBackColor = false;
            this.number2Button.Click += new System.EventHandler(this.number2Button_Click);
            // 
            // number3Button
            // 
            this.number3Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number3Button.Location = new System.Drawing.Point(174, 95);
            this.number3Button.Name = "number3Button";
            this.number3Button.Size = new System.Drawing.Size(75, 75);
            this.number3Button.TabIndex = 3;
            this.number3Button.Text = "3";
            this.number3Button.UseVisualStyleBackColor = false;
            this.number3Button.Click += new System.EventHandler(this.number3Button_Click);
            // 
            // number4Button
            // 
            this.number4Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number4Button.Location = new System.Drawing.Point(12, 176);
            this.number4Button.Name = "number4Button";
            this.number4Button.Size = new System.Drawing.Size(75, 75);
            this.number4Button.TabIndex = 4;
            this.number4Button.Text = "4";
            this.number4Button.UseVisualStyleBackColor = false;
            this.number4Button.Click += new System.EventHandler(this.number4Button_Click);
            // 
            // number5Button
            // 
            this.number5Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number5Button.Location = new System.Drawing.Point(93, 176);
            this.number5Button.Name = "number5Button";
            this.number5Button.Size = new System.Drawing.Size(75, 75);
            this.number5Button.TabIndex = 5;
            this.number5Button.Text = "5";
            this.number5Button.UseVisualStyleBackColor = false;
            this.number5Button.Click += new System.EventHandler(this.number5Button_Click);
            // 
            // number6Button
            // 
            this.number6Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number6Button.Location = new System.Drawing.Point(174, 176);
            this.number6Button.Name = "number6Button";
            this.number6Button.Size = new System.Drawing.Size(75, 75);
            this.number6Button.TabIndex = 6;
            this.number6Button.Text = "6";
            this.number6Button.UseVisualStyleBackColor = false;
            this.number6Button.Click += new System.EventHandler(this.number6Button_Click);
            // 
            // number7Button
            // 
            this.number7Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number7Button.Location = new System.Drawing.Point(12, 257);
            this.number7Button.Name = "number7Button";
            this.number7Button.Size = new System.Drawing.Size(75, 75);
            this.number7Button.TabIndex = 7;
            this.number7Button.Text = "7";
            this.number7Button.UseVisualStyleBackColor = false;
            this.number7Button.Click += new System.EventHandler(this.number7Button_Click);
            // 
            // number8Button
            // 
            this.number8Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number8Button.Location = new System.Drawing.Point(93, 257);
            this.number8Button.Name = "number8Button";
            this.number8Button.Size = new System.Drawing.Size(75, 75);
            this.number8Button.TabIndex = 8;
            this.number8Button.Text = "8";
            this.number8Button.UseVisualStyleBackColor = false;
            this.number8Button.Click += new System.EventHandler(this.number8Button_Click);
            // 
            // number9Button
            // 
            this.number9Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number9Button.Location = new System.Drawing.Point(174, 257);
            this.number9Button.Name = "number9Button";
            this.number9Button.Size = new System.Drawing.Size(75, 75);
            this.number9Button.TabIndex = 9;
            this.number9Button.Text = "9";
            this.number9Button.UseVisualStyleBackColor = false;
            this.number9Button.Click += new System.EventHandler(this.number9Button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SlateGray;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button10.Location = new System.Drawing.Point(12, 338);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 10;
            this.button10.Text = "C";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // number0Button
            // 
            this.number0Button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.number0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.number0Button.Location = new System.Drawing.Point(93, 338);
            this.number0Button.Name = "number0Button";
            this.number0Button.Size = new System.Drawing.Size(75, 75);
            this.number0Button.TabIndex = 11;
            this.number0Button.Text = "0";
            this.number0Button.UseVisualStyleBackColor = false;
            this.number0Button.Click += new System.EventHandler(this.number0Button_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Crimson;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.equal.Location = new System.Drawing.Point(174, 338);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 75);
            this.equal.TabIndex = 12;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // devide
            // 
            this.devide.BackColor = System.Drawing.Color.Yellow;
            this.devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.devide.Location = new System.Drawing.Point(255, 338);
            this.devide.Name = "devide";
            this.devide.Size = new System.Drawing.Size(75, 75);
            this.devide.TabIndex = 16;
            this.devide.Text = "/";
            this.devide.UseVisualStyleBackColor = false;
            this.devide.Click += new System.EventHandler(this.devide_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.Color.Yellow;
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.multiple.Location = new System.Drawing.Point(255, 257);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(75, 75);
            this.multiple.TabIndex = 15;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // extraction
            // 
            this.extraction.BackColor = System.Drawing.Color.Yellow;
            this.extraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.extraction.Location = new System.Drawing.Point(255, 176);
            this.extraction.Name = "extraction";
            this.extraction.Size = new System.Drawing.Size(75, 75);
            this.extraction.TabIndex = 14;
            this.extraction.Text = "-";
            this.extraction.UseVisualStyleBackColor = false;
            this.extraction.Click += new System.EventHandler(this.extraction_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Yellow;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.plus.Location = new System.Drawing.Point(255, 95);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 75);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 423);
            this.Controls.Add(this.devide);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.extraction);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.number0Button);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.number9Button);
            this.Controls.Add(this.number8Button);
            this.Controls.Add(this.number7Button);
            this.Controls.Add(this.number6Button);
            this.Controls.Add(this.number5Button);
            this.Controls.Add(this.number4Button);
            this.Controls.Add(this.number3Button);
            this.Controls.Add(this.number2Button);
            this.Controls.Add(this.number1Button);
            this.Controls.Add(this.screenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.Button number1Button;
        private System.Windows.Forms.Button number2Button;
        private System.Windows.Forms.Button number3Button;
        private System.Windows.Forms.Button number4Button;
        private System.Windows.Forms.Button number5Button;
        private System.Windows.Forms.Button number6Button;
        private System.Windows.Forms.Button number7Button;
        private System.Windows.Forms.Button number8Button;
        private System.Windows.Forms.Button number9Button;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button number0Button;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button devide;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button extraction;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

