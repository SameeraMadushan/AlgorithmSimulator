namespace SymulatorApp
{
    partial class Symulator
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
            this.outlineOfNumbers = new System.Windows.Forms.GroupBox();
            this.textboxPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selection = new System.Windows.Forms.Button();
            this.insertion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.outlineOfStructure = new System.Windows.Forms.GroupBox();
            this.quicksortPanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.insertionPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.outlineOfNumbers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.outlineOfStructure.SuspendLayout();
            this.quicksortPanel.SuspendLayout();
            this.insertionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outlineOfNumbers
            // 
            this.outlineOfNumbers.BackColor = System.Drawing.Color.White;
            this.outlineOfNumbers.Controls.Add(this.textboxPanel);
            this.outlineOfNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outlineOfNumbers.ForeColor = System.Drawing.SystemColors.Highlight;
            this.outlineOfNumbers.Location = new System.Drawing.Point(8, 32);
            this.outlineOfNumbers.Name = "outlineOfNumbers";
            this.outlineOfNumbers.Size = new System.Drawing.Size(682, 83);
            this.outlineOfNumbers.TabIndex = 1;
            this.outlineOfNumbers.TabStop = false;
            this.outlineOfNumbers.Text = "Enter Your Values Here";
            // 
            // textboxPanel
            // 
            this.textboxPanel.Location = new System.Drawing.Point(38, 33);
            this.textboxPanel.Name = "textboxPanel";
            this.textboxPanel.Size = new System.Drawing.Size(608, 25);
            this.textboxPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selection);
            this.groupBox1.Controls.Add(this.insertion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(696, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Algorithm";
            // 
            // selection
            // 
            this.selection.BackColor = System.Drawing.Color.DodgerBlue;
            this.selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selection.ForeColor = System.Drawing.SystemColors.Window;
            this.selection.Location = new System.Drawing.Point(126, 27);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(118, 52);
            this.selection.TabIndex = 0;
            this.selection.Text = "SELECTION \r\nSORT";
            this.selection.UseVisualStyleBackColor = false;
            this.selection.Click += new System.EventHandler(this.selection_Click);
            // 
            // insertion
            // 
            this.insertion.BackColor = System.Drawing.Color.DodgerBlue;
            this.insertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertion.ForeColor = System.Drawing.SystemColors.Window;
            this.insertion.Location = new System.Drawing.Point(7, 27);
            this.insertion.Name = "insertion";
            this.insertion.Size = new System.Drawing.Size(113, 52);
            this.insertion.TabIndex = 0;
            this.insertion.Text = "INSERTION\r\nSORT";
            this.insertion.UseVisualStyleBackColor = false;
            this.insertion.Click += new System.EventHandler(this.insertion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(696, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainPanel);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(8, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 420);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Let\'s See How It Works";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(6, 34);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(670, 380);
            this.mainPanel.TabIndex = 0;
            // 
            // outlineOfStructure
            // 
            this.outlineOfStructure.Controls.Add(this.quicksortPanel);
            this.outlineOfStructure.Controls.Add(this.insertionPanel);
            this.outlineOfStructure.ForeColor = System.Drawing.SystemColors.Highlight;
            this.outlineOfStructure.Location = new System.Drawing.Point(696, 32);
            this.outlineOfStructure.Name = "outlineOfStructure";
            this.outlineOfStructure.Size = new System.Drawing.Size(250, 368);
            this.outlineOfStructure.TabIndex = 4;
            this.outlineOfStructure.TabStop = false;
            this.outlineOfStructure.Text = "Algorithm Structure";
            // 
            // quicksortPanel
            // 
            this.quicksortPanel.Controls.Add(this.label13);
            this.quicksortPanel.Controls.Add(this.label14);
            this.quicksortPanel.Controls.Add(this.label15);
            this.quicksortPanel.Controls.Add(this.label16);
            this.quicksortPanel.Controls.Add(this.label17);
            this.quicksortPanel.Controls.Add(this.label18);
            this.quicksortPanel.Controls.Add(this.panel1);
            this.quicksortPanel.Location = new System.Drawing.Point(8, 26);
            this.quicksortPanel.Name = "quicksortPanel";
            this.quicksortPanel.Size = new System.Drawing.Size(236, 326);
            this.quicksortPanel.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Khaki;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label13.Location = new System.Drawing.Point(16, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "4.   QUICKSORT ( A , q + 1 , r )";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Khaki;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label14.Location = new System.Drawing.Point(16, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "3.   QUICKSORT ( A , p , q )";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Khaki;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label15.Location = new System.Drawing.Point(16, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "2.   then q <-- PARTITION ( A , p , r)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Khaki;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label16.Location = new System.Drawing.Point(16, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "1.   if  p  <  r";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Khaki;
            this.label17.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label17.Location = new System.Drawing.Point(16, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "QS(A , p , r)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label18.Location = new System.Drawing.Point(9, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Selection Sort";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(7, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 271);
            this.panel1.TabIndex = 4;
            // 
            // insertionPanel
            // 
            this.insertionPanel.Controls.Add(this.label9);
            this.insertionPanel.Controls.Add(this.label8);
            this.insertionPanel.Controls.Add(this.label7);
            this.insertionPanel.Controls.Add(this.label6);
            this.insertionPanel.Controls.Add(this.label5);
            this.insertionPanel.Controls.Add(this.label4);
            this.insertionPanel.Controls.Add(this.label3);
            this.insertionPanel.Controls.Add(this.label2);
            this.insertionPanel.Controls.Add(this.label1);
            this.insertionPanel.Controls.Add(this.panel3);
            this.insertionPanel.Location = new System.Drawing.Point(7, 26);
            this.insertionPanel.Name = "insertionPanel";
            this.insertionPanel.Size = new System.Drawing.Size(236, 326);
            this.insertionPanel.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Khaki;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(17, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "7.   A[ i + 1 ] <-- key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(17, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "6.               i <-- i - 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(17, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "5.               do A[ i + 1 ] <-- A[ i ] ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Khaki;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(17, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "4.   while  i > 0  and  A[ i ] > key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(17, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "3.   i  <--  j - 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(17, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "2.   do key <-- A[ j ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "1.   for j <-- to length [A]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "IS(A)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertion Sort";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Location = new System.Drawing.Point(8, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 271);
            this.panel3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Symulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outlineOfStructure);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.outlineOfNumbers);
            this.MaximizeBox = false;
            this.Name = "Symulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Algorithm Symulator";
            this.Load += new System.EventHandler(this.Symulator_Load);
            this.outlineOfNumbers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.outlineOfStructure.ResumeLayout(false);
            this.quicksortPanel.ResumeLayout(false);
            this.quicksortPanel.PerformLayout();
            this.insertionPanel.ResumeLayout(false);
            this.insertionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox outlineOfNumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selection;
        private System.Windows.Forms.Button insertion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox outlineOfStructure;
        private System.Windows.Forms.Panel insertionPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel quicksortPanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel textboxPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;

    }
}

