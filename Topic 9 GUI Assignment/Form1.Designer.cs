namespace Topic_9_GUI_Assignment
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.imgCharacter1 = new System.Windows.Forms.PictureBox();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(12, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(177, 110);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Good";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.BackColor = System.Drawing.Color.Red;
            this.btnSubmit1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit1.Location = new System.Drawing.Point(12, 328);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(177, 110);
            this.btnSubmit1.TabIndex = 1;
            this.btnSubmit1.Text = "Bad";
            this.btnSubmit1.UseVisualStyleBackColor = false;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // imgCharacter1
            // 
            this.imgCharacter1.Image = global::Topic_9_GUI_Assignment.Properties.Resources.unnamed__1_;
            this.imgCharacter1.Location = new System.Drawing.Point(406, 134);
            this.imgCharacter1.Name = "imgCharacter1";
            this.imgCharacter1.Size = new System.Drawing.Size(382, 281);
            this.imgCharacter1.TabIndex = 3;
            this.imgCharacter1.TabStop = false;
            this.imgCharacter1.Visible = false;
            // 
            // imgCharacter
            // 
            this.imgCharacter.Image = global::Topic_9_GUI_Assignment.Properties.Resources.free_nature_images;
            this.imgCharacter.Location = new System.Drawing.Point(195, 12);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(593, 426);
            this.imgCharacter.TabIndex = 2;
            this.imgCharacter.TabStop = false;
            this.imgCharacter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgCharacter1);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnSubmit1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "assignment 1";
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.PictureBox imgCharacter1;
    }
}

