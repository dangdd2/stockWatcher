namespace StockWatcher
{
    partial class StockWatcher
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Symbol = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriceToBuy = new System.Windows.Forms.TextBox();
            this.txtPriceToSell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.chkSendNotification = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogging = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Symbol
            // 
            this.Symbol.AutoSize = true;
            this.Symbol.Location = new System.Drawing.Point(23, 41);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(54, 17);
            this.Symbol.TabIndex = 1;
            this.Symbol.Text = "Symbol";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(150, 36);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(377, 22);
            this.txtSymbol.TabIndex = 2;
            this.txtSymbol.Text = "SZC";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(608, 801);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(114, 27);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(728, 801);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 27);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price to Buy";
            // 
            // txtPriceToBuy
            // 
            this.txtPriceToBuy.Location = new System.Drawing.Point(150, 73);
            this.txtPriceToBuy.Name = "txtPriceToBuy";
            this.txtPriceToBuy.Size = new System.Drawing.Size(377, 22);
            this.txtPriceToBuy.TabIndex = 2;
            this.txtPriceToBuy.Text = "28700";
            // 
            // txtPriceToSell
            // 
            this.txtPriceToSell.Location = new System.Drawing.Point(150, 114);
            this.txtPriceToSell.Name = "txtPriceToSell";
            this.txtPriceToSell.Size = new System.Drawing.Size(377, 22);
            this.txtPriceToSell.TabIndex = 2;
            this.txtPriceToSell.Text = "30000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(147, 207);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(694, 22);
            this.txtEmail1.TabIndex = 2;
            this.txtEmail1.Text = "dang.dang@episerver.com";
            // 
            // chkSendNotification
            // 
            this.chkSendNotification.AutoSize = true;
            this.chkSendNotification.Checked = true;
            this.chkSendNotification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendNotification.Location = new System.Drawing.Point(23, 169);
            this.chkSendNotification.Name = "chkSendNotification";
            this.chkSendNotification.Size = new System.Drawing.Size(135, 21);
            this.chkSendNotification.TabIndex = 4;
            this.chkSendNotification.Text = "Send notification";
            this.chkSendNotification.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price to Sell";
            // 
            // txtLogging
            // 
            this.txtLogging.Location = new System.Drawing.Point(23, 634);
            this.txtLogging.Multiline = true;
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogging.Size = new System.Drawing.Size(821, 145);
            this.txtLogging.TabIndex = 0;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(147, 245);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(694, 22);
            this.txtEmail2.TabIndex = 2;
            this.txtEmail2.Text = "dangdd2@yahoo.com.vn";
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(147, 284);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(694, 22);
            this.txtEmail3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 279);
            this.dataGridView1.TabIndex = 5;
            // 
            // StockWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 852);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkSendNotification);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPriceToSell);
            this.Controls.Add(this.txtEmail3);
            this.Controls.Add(this.txtEmail2);
            this.Controls.Add(this.txtEmail1);
            this.Controls.Add(this.txtPriceToBuy);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Symbol);
            this.Controls.Add(this.txtLogging);
            this.Name = "StockWatcher";
            this.Text = "Stock Watcher";
            this.Load += new System.EventHandler(this.StockWatcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Symbol;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceToBuy;
        private System.Windows.Forms.TextBox txtPriceToSell;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.CheckBox chkSendNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogging;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

