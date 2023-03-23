namespace RS232
{
    partial class Nadajnik
    {

        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private string nowa;
        private string[] data= new string[500];
        private string[] data_reversed = new string[500];
        private string[] message = new string[500];
        private string message2;
        private string binary;
        private int i;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.OutputText = new System.Windows.Forms.RichTextBox();
            this.Convertt = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MessageScreen = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(19, 49);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(204, 267);
            this.InputText.TabIndex = 1;
            this.InputText.Text = "";
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // OutputText
            // 
            this.OutputText.Enabled = false;
            this.OutputText.Location = new System.Drawing.Point(20, 49);
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(204, 267);
            this.OutputText.TabIndex = 2;
            this.OutputText.Text = "";
            this.OutputText.TextChanged += new System.EventHandler(this.OutputText_TextChanged);
            // 
            // Convertt
            // 
            this.Convertt.Enabled = false;
            this.Convertt.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Convertt.Location = new System.Drawing.Point(82, 322);
            this.Convertt.Name = "Convertt";
            this.Convertt.Size = new System.Drawing.Size(75, 31);
            this.Convertt.TabIndex = 3;
            this.Convertt.Text = "Zamień";
            this.Convertt.UseVisualStyleBackColor = true;
            this.Convertt.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Send
            // 
            this.Send.Enabled = false;
            this.Send.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Send.Location = new System.Drawing.Point(85, 322);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 31);
            this.Send.TabIndex = 4;
            this.Send.Text = "Wyślij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InputText);
            this.groupBox1.Controls.Add(this.Convertt);
            this.groupBox1.Location = new System.Drawing.Point(5, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 392);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wpisz tekst do zamiany:";
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c2.Location = new System.Drawing.Point(77, 324);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(72, 29);
            this.c2.TabIndex = 5;
            this.c2.Text = "Wyczyść";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.OutputText);
            this.groupBox2.Controls.Add(this.Send);
            this.groupBox2.Location = new System.Drawing.Point(250, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 392);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Twój tekst binarnie to:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.c2);
            this.groupBox3.Controls.Add(this.MessageScreen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(495, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 392);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // MessageScreen
            // 
            this.MessageScreen.Enabled = false;
            this.MessageScreen.Location = new System.Drawing.Point(19, 49);
            this.MessageScreen.Name = "MessageScreen";
            this.MessageScreen.Size = new System.Drawing.Size(204, 267);
            this.MessageScreen.TabIndex = 1;
            this.MessageScreen.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(73, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Odebrany tekst:";
            // 
            // Nadajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(742, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(758, 537);
            this.MinimumSize = new System.Drawing.Size(758, 537);
            this.Name = "Nadajnik";
            this.Text = "RS232";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.RichTextBox OutputText;
        private System.Windows.Forms.Button Convertt;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox MessageScreen;
        private System.Windows.Forms.Label label3;
    }
}

