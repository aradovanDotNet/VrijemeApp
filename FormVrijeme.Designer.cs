namespace VrijemeApp {
  partial class FormVrijeme {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.cbGrad = new System.Windows.Forms.ComboBox();
      this.lblGrad = new System.Windows.Forms.Label();
      this.lblTemperatura = new System.Windows.Forms.Label();
      this.lblVlaga = new System.Windows.Forms.Label();
      this.lblTlak = new System.Windows.Forms.Label();
      this.scKontejner = new System.Windows.Forms.SplitContainer();
      this.lbNajtopliji = new System.Windows.Forms.ListBox();
      this.lblNajtopliji = new System.Windows.Forms.Label();
      this.lbNajhladniji = new System.Windows.Forms.ListBox();
      this.lblNajhladniji = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.scKontejner)).BeginInit();
      this.scKontejner.Panel1.SuspendLayout();
      this.scKontejner.Panel2.SuspendLayout();
      this.scKontejner.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbGrad
      // 
      this.cbGrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbGrad.FormattingEnabled = true;
      this.cbGrad.Location = new System.Drawing.Point(12, 12);
      this.cbGrad.Name = "cbGrad";
      this.cbGrad.Size = new System.Drawing.Size(497, 23);
      this.cbGrad.TabIndex = 0;
      this.cbGrad.Text = "Odaberite grad";
      this.cbGrad.SelectedIndexChanged += new System.EventHandler(this.cbGrad_SelectedIndexChanged);
      // 
      // lblGrad
      // 
      this.lblGrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblGrad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblGrad.Location = new System.Drawing.Point(12, 64);
      this.lblGrad.Name = "lblGrad";
      this.lblGrad.Size = new System.Drawing.Size(497, 44);
      this.lblGrad.TabIndex = 1;
      this.lblGrad.Text = "(grad nije odabran)";
      this.lblGrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTemperatura
      // 
      this.lblTemperatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTemperatura.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTemperatura.Location = new System.Drawing.Point(12, 108);
      this.lblTemperatura.Name = "lblTemperatura";
      this.lblTemperatura.Size = new System.Drawing.Size(497, 44);
      this.lblTemperatura.TabIndex = 2;
      this.lblTemperatura.Text = "? °C";
      this.lblTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblVlaga
      // 
      this.lblVlaga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblVlaga.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblVlaga.Location = new System.Drawing.Point(12, 152);
      this.lblVlaga.Name = "lblVlaga";
      this.lblVlaga.Size = new System.Drawing.Size(497, 44);
      this.lblVlaga.TabIndex = 3;
      this.lblVlaga.Text = "? %";
      this.lblVlaga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTlak
      // 
      this.lblTlak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTlak.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lblTlak.Location = new System.Drawing.Point(12, 196);
      this.lblTlak.Name = "lblTlak";
      this.lblTlak.Size = new System.Drawing.Size(497, 44);
      this.lblTlak.TabIndex = 4;
      this.lblTlak.Text = "? hPa";
      this.lblTlak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // scKontejner
      // 
      this.scKontejner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scKontejner.Location = new System.Drawing.Point(12, 260);
      this.scKontejner.Name = "scKontejner";
      // 
      // scKontejner.Panel1
      // 
      this.scKontejner.Panel1.Controls.Add(this.lbNajtopliji);
      this.scKontejner.Panel1.Controls.Add(this.lblNajtopliji);
      // 
      // scKontejner.Panel2
      // 
      this.scKontejner.Panel2.Controls.Add(this.lbNajhladniji);
      this.scKontejner.Panel2.Controls.Add(this.lblNajhladniji);
      this.scKontejner.Size = new System.Drawing.Size(497, 292);
      this.scKontejner.SplitterDistance = 247;
      this.scKontejner.TabIndex = 5;
      // 
      // lbNajtopliji
      // 
      this.lbNajtopliji.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbNajtopliji.FormattingEnabled = true;
      this.lbNajtopliji.ItemHeight = 15;
      this.lbNajtopliji.Location = new System.Drawing.Point(0, 23);
      this.lbNajtopliji.Name = "lbNajtopliji";
      this.lbNajtopliji.Size = new System.Drawing.Size(247, 269);
      this.lbNajtopliji.TabIndex = 1;
      // 
      // lblNajtopliji
      // 
      this.lblNajtopliji.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblNajtopliji.Location = new System.Drawing.Point(0, 0);
      this.lblNajtopliji.Name = "lblNajtopliji";
      this.lblNajtopliji.Size = new System.Drawing.Size(247, 23);
      this.lblNajtopliji.TabIndex = 0;
      this.lblNajtopliji.Text = "Najtopliji gradovi";
      this.lblNajtopliji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbNajhladniji
      // 
      this.lbNajhladniji.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lbNajhladniji.FormattingEnabled = true;
      this.lbNajhladniji.ItemHeight = 15;
      this.lbNajhladniji.Location = new System.Drawing.Point(0, 23);
      this.lbNajhladniji.Name = "lbNajhladniji";
      this.lbNajhladniji.Size = new System.Drawing.Size(246, 269);
      this.lbNajhladniji.TabIndex = 1;
      // 
      // lblNajhladniji
      // 
      this.lblNajhladniji.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblNajhladniji.Location = new System.Drawing.Point(0, 0);
      this.lblNajhladniji.Name = "lblNajhladniji";
      this.lblNajhladniji.Size = new System.Drawing.Size(246, 23);
      this.lblNajhladniji.TabIndex = 0;
      this.lblNajhladniji.Text = "Najhladniji gradovi";
      this.lblNajhladniji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FormVrijeme
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(521, 564);
      this.Controls.Add(this.scKontejner);
      this.Controls.Add(this.lblTlak);
      this.Controls.Add(this.lblVlaga);
      this.Controls.Add(this.lblTemperatura);
      this.Controls.Add(this.lblGrad);
      this.Controls.Add(this.cbGrad);
      this.Name = "FormVrijeme";
      this.Text = "VrijemeApp";
      this.scKontejner.Panel1.ResumeLayout(false);
      this.scKontejner.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.scKontejner)).EndInit();
      this.scKontejner.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private ComboBox cbGrad;
    private Label lblGrad;
    private Label lblTemperatura;
    private Label lblVlaga;
    private Label lblTlak;
    private SplitContainer scKontejner;
    private Label lblNajtopliji;
    private Label lblNajhladniji;
    private ListBox lbNajtopliji;
    private ListBox lbNajhladniji;
  }
}