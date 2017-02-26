namespace Appcache
{
    partial class AppCacheMain
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
            this.lb_link = new System.Windows.Forms.Label();
            this.tb_lnk = new System.Windows.Forms.TextBox();
            this.bt_open = new System.Windows.Forms.Button();
            this.treeview_open = new System.Windows.Forms.TreeView();
            this.bt_crt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(13, 9);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(27, 13);
            this.lb_link.TabIndex = 0;
            this.lb_link.Text = "Link";
            // 
            // tb_lnk
            // 
            this.tb_lnk.Location = new System.Drawing.Point(55, 5);
            this.tb_lnk.Name = "tb_lnk";
            this.tb_lnk.Size = new System.Drawing.Size(443, 20);
            this.tb_lnk.TabIndex = 1;
            // 
            // bt_open
            // 
            this.bt_open.Location = new System.Drawing.Point(504, 4);
            this.bt_open.Name = "bt_open";
            this.bt_open.Size = new System.Drawing.Size(75, 23);
            this.bt_open.TabIndex = 2;
            this.bt_open.Text = "Open Index";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // treeview_open
            // 
            this.treeview_open.Location = new System.Drawing.Point(12, 32);
            this.treeview_open.Name = "treeview_open";
            this.treeview_open.Size = new System.Drawing.Size(648, 280);
            this.treeview_open.TabIndex = 3;
            // 
            // bt_crt
            // 
            this.bt_crt.Location = new System.Drawing.Point(585, 4);
            this.bt_crt.Name = "bt_crt";
            this.bt_crt.Size = new System.Drawing.Size(75, 23);
            this.bt_crt.TabIndex = 4;
            this.bt_crt.Text = "Create File";
            this.bt_crt.UseVisualStyleBackColor = true;
            this.bt_crt.Click += new System.EventHandler(this.bt_crt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 324);
            this.Controls.Add(this.bt_crt);
            this.Controls.Add(this.treeview_open);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.tb_lnk);
            this.Controls.Add(this.lb_link);
            this.Name = "Form1";
            this.Text = "Create the Appcache manifest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.TextBox tb_lnk;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.TreeView treeview_open;
        private System.Windows.Forms.Button bt_crt;
    }
}

