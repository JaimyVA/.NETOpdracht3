namespace Opdracht3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStringToevoegen = new System.Windows.Forms.Button();
            this.btnStringVerwijderen = new System.Windows.Forms.Button();
            this.btnStringAanwezig = new System.Windows.Forms.Button();
            this.btnStringCopy = new System.Windows.Forms.Button();
            this.btnIntToevoegen = new System.Windows.Forms.Button();
            this.btnIntVerwijderen = new System.Windows.Forms.Button();
            this.btnIntAanwezig = new System.Windows.Forms.Button();
            this.btnIntCopy = new System.Windows.Forms.Button();
            this.btnStringLeegmaken = new System.Windows.Forms.Button();
            this.btnIntLeegmaken = new System.Windows.Forms.Button();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.tbString = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBoxString = new System.Windows.Forms.ListBox();
            this.listBoxInt = new System.Windows.Forms.ListBox();
            this.btnToString = new System.Windows.Forms.Button();
            this.lbString = new System.Windows.Forms.Label();
            this.lbInt = new System.Windows.Forms.Label();
            this.listBoxCopy = new System.Windows.Forms.ListBox();
            this.listBoxToString = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStringToevoegen
            // 
            this.btnStringToevoegen.Location = new System.Drawing.Point(12, 12);
            this.btnStringToevoegen.Name = "btnStringToevoegen";
            this.btnStringToevoegen.Size = new System.Drawing.Size(95, 29);
            this.btnStringToevoegen.TabIndex = 0;
            this.btnStringToevoegen.Text = "Toevoegen";
            this.btnStringToevoegen.UseVisualStyleBackColor = true;
            this.btnStringToevoegen.Click += new System.EventHandler(this.btnStringToevoegen_Click);
            // 
            // btnStringVerwijderen
            // 
            this.btnStringVerwijderen.Location = new System.Drawing.Point(12, 47);
            this.btnStringVerwijderen.Name = "btnStringVerwijderen";
            this.btnStringVerwijderen.Size = new System.Drawing.Size(95, 29);
            this.btnStringVerwijderen.TabIndex = 1;
            this.btnStringVerwijderen.Text = "Verwijderen";
            this.btnStringVerwijderen.UseVisualStyleBackColor = true;
            this.btnStringVerwijderen.Click += new System.EventHandler(this.btnStringVerwijderen_Click);
            // 
            // btnStringAanwezig
            // 
            this.btnStringAanwezig.Location = new System.Drawing.Point(12, 82);
            this.btnStringAanwezig.Name = "btnStringAanwezig";
            this.btnStringAanwezig.Size = new System.Drawing.Size(95, 29);
            this.btnStringAanwezig.TabIndex = 2;
            this.btnStringAanwezig.Text = "Zoek op";
            this.btnStringAanwezig.UseVisualStyleBackColor = true;
            this.btnStringAanwezig.Click += new System.EventHandler(this.btnStringAanwezig_Click);
            // 
            // btnStringCopy
            // 
            this.btnStringCopy.Location = new System.Drawing.Point(12, 117);
            this.btnStringCopy.Name = "btnStringCopy";
            this.btnStringCopy.Size = new System.Drawing.Size(95, 29);
            this.btnStringCopy.TabIndex = 3;
            this.btnStringCopy.Text = "Kopieer";
            this.btnStringCopy.UseVisualStyleBackColor = true;
            this.btnStringCopy.Click += new System.EventHandler(this.btnStringCopy_Click);
            // 
            // btnIntToevoegen
            // 
            this.btnIntToevoegen.Location = new System.Drawing.Point(693, 12);
            this.btnIntToevoegen.Name = "btnIntToevoegen";
            this.btnIntToevoegen.Size = new System.Drawing.Size(95, 29);
            this.btnIntToevoegen.TabIndex = 4;
            this.btnIntToevoegen.Text = "Toevoegen";
            this.btnIntToevoegen.UseVisualStyleBackColor = true;
            this.btnIntToevoegen.Click += new System.EventHandler(this.btnIntToevoegen_Click);
            // 
            // btnIntVerwijderen
            // 
            this.btnIntVerwijderen.Location = new System.Drawing.Point(693, 47);
            this.btnIntVerwijderen.Name = "btnIntVerwijderen";
            this.btnIntVerwijderen.Size = new System.Drawing.Size(95, 29);
            this.btnIntVerwijderen.TabIndex = 5;
            this.btnIntVerwijderen.Text = "Verwijderen";
            this.btnIntVerwijderen.UseVisualStyleBackColor = true;
            this.btnIntVerwijderen.Click += new System.EventHandler(this.btnIntVerwijderen_Click);
            // 
            // btnIntAanwezig
            // 
            this.btnIntAanwezig.Location = new System.Drawing.Point(693, 82);
            this.btnIntAanwezig.Name = "btnIntAanwezig";
            this.btnIntAanwezig.Size = new System.Drawing.Size(95, 29);
            this.btnIntAanwezig.TabIndex = 6;
            this.btnIntAanwezig.Text = "Zoek op";
            this.btnIntAanwezig.UseVisualStyleBackColor = true;
            this.btnIntAanwezig.Click += new System.EventHandler(this.btnIntAanwezig_Click);
            // 
            // btnIntCopy
            // 
            this.btnIntCopy.Location = new System.Drawing.Point(693, 117);
            this.btnIntCopy.Name = "btnIntCopy";
            this.btnIntCopy.Size = new System.Drawing.Size(95, 29);
            this.btnIntCopy.TabIndex = 7;
            this.btnIntCopy.Text = "Kopieer";
            this.btnIntCopy.UseVisualStyleBackColor = true;
            this.btnIntCopy.Click += new System.EventHandler(this.btnIntCopy_Click);
            // 
            // btnStringLeegmaken
            // 
            this.btnStringLeegmaken.Location = new System.Drawing.Point(158, 416);
            this.btnStringLeegmaken.Name = "btnStringLeegmaken";
            this.btnStringLeegmaken.Size = new System.Drawing.Size(95, 29);
            this.btnStringLeegmaken.TabIndex = 8;
            this.btnStringLeegmaken.Text = "Maak Leeg";
            this.btnStringLeegmaken.UseVisualStyleBackColor = true;
            this.btnStringLeegmaken.Click += new System.EventHandler(this.btnStringLeegmaken_Click);
            // 
            // btnIntLeegmaken
            // 
            this.btnIntLeegmaken.Location = new System.Drawing.Point(550, 416);
            this.btnIntLeegmaken.Name = "btnIntLeegmaken";
            this.btnIntLeegmaken.Size = new System.Drawing.Size(95, 29);
            this.btnIntLeegmaken.TabIndex = 9;
            this.btnIntLeegmaken.Text = "Maak Leeg";
            this.btnIntLeegmaken.UseVisualStyleBackColor = true;
            this.btnIntLeegmaken.Click += new System.EventHandler(this.btnIntLeegmaken_Click);
            // 
            // tbInt
            // 
            this.tbInt.Location = new System.Drawing.Point(503, 68);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(184, 27);
            this.tbInt.TabIndex = 10;
            // 
            // tbString
            // 
            this.tbString.Location = new System.Drawing.Point(113, 68);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(184, 27);
            this.tbString.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listBoxString
            // 
            this.listBoxString.FormattingEnabled = true;
            this.listBoxString.ItemHeight = 20;
            this.listBoxString.Location = new System.Drawing.Point(113, 146);
            this.listBoxString.Name = "listBoxString";
            this.listBoxString.Size = new System.Drawing.Size(184, 264);
            this.listBoxString.TabIndex = 15;
            // 
            // listBoxInt
            // 
            this.listBoxInt.FormattingEnabled = true;
            this.listBoxInt.ItemHeight = 20;
            this.listBoxInt.Location = new System.Drawing.Point(503, 146);
            this.listBoxInt.Name = "listBoxInt";
            this.listBoxInt.Size = new System.Drawing.Size(184, 264);
            this.listBoxInt.TabIndex = 16;
            // 
            // btnToString
            // 
            this.btnToString.Location = new System.Drawing.Point(345, 416);
            this.btnToString.Name = "btnToString";
            this.btnToString.Size = new System.Drawing.Size(95, 29);
            this.btnToString.TabIndex = 18;
            this.btnToString.Text = "ToString";
            this.btnToString.UseVisualStyleBackColor = true;
            this.btnToString.Click += new System.EventHandler(this.btnToString_Click);
            // 
            // lbString
            // 
            this.lbString.AutoSize = true;
            this.lbString.Location = new System.Drawing.Point(172, 16);
            this.lbString.Name = "lbString";
            this.lbString.Size = new System.Drawing.Size(48, 20);
            this.lbString.TabIndex = 19;
            this.lbString.Text = "String";
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(582, 16);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(26, 20);
            this.lbInt.TabIndex = 20;
            this.lbInt.Text = "Int";
            // 
            // listBoxCopy
            // 
            this.listBoxCopy.FormattingEnabled = true;
            this.listBoxCopy.ItemHeight = 20;
            this.listBoxCopy.Location = new System.Drawing.Point(325, 196);
            this.listBoxCopy.Name = "listBoxCopy";
            this.listBoxCopy.Size = new System.Drawing.Size(150, 164);
            this.listBoxCopy.TabIndex = 21;
            // 
            // listBoxToString
            // 
            this.listBoxToString.FormattingEnabled = true;
            this.listBoxToString.ItemHeight = 20;
            this.listBoxToString.Location = new System.Drawing.Point(113, 451);
            this.listBoxToString.Name = "listBoxToString";
            this.listBoxToString.Size = new System.Drawing.Size(574, 144);
            this.listBoxToString.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.listBoxToString);
            this.Controls.Add(this.listBoxCopy);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.lbString);
            this.Controls.Add(this.btnToString);
            this.Controls.Add(this.listBoxInt);
            this.Controls.Add(this.listBoxString);
            this.Controls.Add(this.tbString);
            this.Controls.Add(this.tbInt);
            this.Controls.Add(this.btnIntLeegmaken);
            this.Controls.Add(this.btnStringLeegmaken);
            this.Controls.Add(this.btnIntCopy);
            this.Controls.Add(this.btnIntAanwezig);
            this.Controls.Add(this.btnIntVerwijderen);
            this.Controls.Add(this.btnIntToevoegen);
            this.Controls.Add(this.btnStringCopy);
            this.Controls.Add(this.btnStringAanwezig);
            this.Controls.Add(this.btnStringVerwijderen);
            this.Controls.Add(this.btnStringToevoegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStringToevoegen;
        private System.Windows.Forms.Button btnStringVerwijderen;
        private System.Windows.Forms.Button btnStringAanwezig;
        private System.Windows.Forms.Button btnStringCopy;
        private System.Windows.Forms.Button btnIntToevoegen;
        private System.Windows.Forms.Button btnIntVerwijderen;
        private System.Windows.Forms.Button btnIntAanwezig;
        private System.Windows.Forms.Button btnIntCopy;
        private System.Windows.Forms.Button btnStringLeegmaken;
        private System.Windows.Forms.Button btnIntLeegmaken;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.TextBox tbString;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBoxString;
        private System.Windows.Forms.ListBox listBoxInt;
        private System.Windows.Forms.Button btnToString;
        private System.Windows.Forms.Label lbString;
        private System.Windows.Forms.Label lbInt;
        private System.Windows.Forms.ListBox listBoxCopy;
        private System.Windows.Forms.ListBox listBoxToString;
    }
}

