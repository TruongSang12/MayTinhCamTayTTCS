namespace WindowsApplication1
{
    partial class loglncs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loglncs));
            this.btnln = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnlog = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txtln = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnln
            // 
            resources.ApplyResources(this.btnln, "btnln");
            this.btnln.Name = "btnln";
            this.btnln.UseVisualStyleBackColor = true;
            this.btnln.Click += new System.EventHandler(this.btnln_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtnlog
            // 
            resources.ApplyResources(this.txtnlog, "txtnlog");
            this.txtnlog.Name = "txtnlog";
            this.txtnlog.TextChanged += new System.EventHandler(this.txtnlog_TextChanged);
            // 
            // btnxoa
            // 
            resources.ApplyResources(this.btnxoa, "btnxoa");
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btndong
            // 
            resources.ApplyResources(this.btndong, "btndong");
            this.btndong.Name = "btndong";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnlog
            // 
            resources.ApplyResources(this.btnlog, "btnlog");
            this.btnlog.Name = "btnlog";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtlog
            // 
            resources.ApplyResources(this.txtlog, "txtlog");
            this.txtlog.Name = "txtlog";
            this.txtlog.TextChanged += new System.EventHandler(this.txtlog_TextChanged);
            // 
            // txtln
            // 
            resources.ApplyResources(this.txtln, "txtln");
            this.txtln.Name = "txtln";
            // 
            // loglncs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.txtnlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnln);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "loglncs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnln;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnlog;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox txtln;
    }
}