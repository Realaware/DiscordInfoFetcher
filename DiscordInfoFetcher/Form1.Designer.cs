
namespace DiscordInfoFetcher
{
    partial class Discord
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
            this.id = new System.Windows.Forms.TextBox();
            this.whatever = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rid = new System.Windows.Forms.Label();
            this.rname = new System.Windows.Forms.Label();
            this.ravatar = new System.Windows.Forms.Label();
            this.rdisname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(36, 67);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(257, 21);
            this.id.TabIndex = 0;
            // 
            // whatever
            // 
            this.whatever.AutoSize = true;
            this.whatever.Location = new System.Drawing.Point(34, 36);
            this.whatever.Name = "whatever";
            this.whatever.Size = new System.Drawing.Size(150, 12);
            this.whatever.TabIndex = 1;
            this.whatever.Text = "whatever. just write the id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Get ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdisname);
            this.panel1.Controls.Add(this.ravatar);
            this.panel1.Controls.Add(this.rname);
            this.panel1.Controls.Add(this.rid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 166);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "result";
            // 
            // rid
            // 
            this.rid.AutoSize = true;
            this.rid.Location = new System.Drawing.Point(3, 35);
            this.rid.Name = "rid";
            this.rid.Size = new System.Drawing.Size(15, 12);
            this.rid.TabIndex = 5;
            this.rid.Text = "id";
            this.rid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rname
            // 
            this.rname.AutoSize = true;
            this.rname.Location = new System.Drawing.Point(3, 59);
            this.rname.Name = "rname";
            this.rname.Size = new System.Drawing.Size(37, 12);
            this.rname.TabIndex = 6;
            this.rname.Text = "name";
            this.rname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ravatar
            // 
            this.ravatar.AutoSize = true;
            this.ravatar.Location = new System.Drawing.Point(3, 82);
            this.ravatar.Name = "ravatar";
            this.ravatar.Size = new System.Drawing.Size(39, 12);
            this.ravatar.TabIndex = 7;
            this.ravatar.Text = "avatar";
            this.ravatar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdisname
            // 
            this.rdisname.AutoSize = true;
            this.rdisname.Location = new System.Drawing.Point(3, 107);
            this.rdisname.Name = "rdisname";
            this.rdisname.Size = new System.Drawing.Size(85, 12);
            this.rdisname.TabIndex = 8;
            this.rdisname.Text = "name with dis";
            this.rdisname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Discord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.whatever);
            this.Controls.Add(this.id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Discord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label whatever;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label rdisname;
        private System.Windows.Forms.Label ravatar;
        private System.Windows.Forms.Label rname;
        private System.Windows.Forms.Label rid;
        private System.Windows.Forms.Label label1;
    }
}

