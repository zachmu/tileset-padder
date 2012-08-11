namespace TilesetPadder {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && (components != null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.loadTileset = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.export = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.inputFile = new System.Windows.Forms.TextBox();
            this.outputFile = new System.Windows.Forms.TextBox();
            this.chooseOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // loadTileset
            // 
            this.loadTileset.Location = new System.Drawing.Point(205, 11);
            this.loadTileset.Name = "loadTileset";
            this.loadTileset.Size = new System.Drawing.Size(104, 23);
            this.loadTileset.TabIndex = 0;
            this.loadTileset.Text = "Load Tileset";
            this.loadTileset.UseVisualStyleBackColor = true;
            this.loadTileset.Click += new System.EventHandler(this.loadTileset_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(234, 114);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 1;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(89, 91);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(100, 20);
            this.width.TabIndex = 2;
            this.width.Text = "64";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(89, 117);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 20);
            this.height.TabIndex = 3;
            this.height.Text = "64";
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(24, 14);
            this.inputFile.Name = "inputFile";
            this.inputFile.Size = new System.Drawing.Size(175, 20);
            this.inputFile.TabIndex = 4;
            // 
            // outputFile
            // 
            this.outputFile.Location = new System.Drawing.Point(24, 41);
            this.outputFile.Name = "outputFile";
            this.outputFile.Size = new System.Drawing.Size(175, 20);
            this.outputFile.TabIndex = 5;
            // 
            // chooseOutput
            // 
            this.chooseOutput.Location = new System.Drawing.Point(206, 41);
            this.chooseOutput.Name = "chooseOutput";
            this.chooseOutput.Size = new System.Drawing.Size(103, 23);
            this.chooseOutput.TabIndex = 6;
            this.chooseOutput.Text = "Choose output file";
            this.chooseOutput.UseVisualStyleBackColor = true;
            this.chooseOutput.Click += new System.EventHandler(this.chooseOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tile height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tile width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseOutput);
            this.Controls.Add(this.outputFile);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.export);
            this.Controls.Add(this.loadTileset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadTileset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox inputFile;
        private System.Windows.Forms.TextBox outputFile;
        private System.Windows.Forms.Button chooseOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

