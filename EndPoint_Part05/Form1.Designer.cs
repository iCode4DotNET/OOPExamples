namespace EndPoint_Part05
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnDisplayOrders = new System.Windows.Forms.Button();
            this.successButton1 = new EndPoint_Part05.CustomControl.SuccessButton();
            this.BtnPersonDTO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(10, 135);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(1339, 483);
            this.Grid.TabIndex = 0;
            // 
            // BtnShow
            // 
            this.BtnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShow.Location = new System.Drawing.Point(1120, 23);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(230, 94);
            this.BtnShow.TabIndex = 1;
            this.BtnShow.Text = "نمایش اطلاعات اشخاص";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnDisplayOrders
            // 
            this.BtnDisplayOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisplayOrders.Location = new System.Drawing.Point(852, 23);
            this.BtnDisplayOrders.Name = "BtnDisplayOrders";
            this.BtnDisplayOrders.Size = new System.Drawing.Size(230, 94);
            this.BtnDisplayOrders.TabIndex = 2;
            this.BtnDisplayOrders.Text = "نمایش اطلاعات سفارشات";
            this.BtnDisplayOrders.UseVisualStyleBackColor = true;
            this.BtnDisplayOrders.Click += new System.EventHandler(this.BtnDisplayOrders_Click);
            // 
            // successButton1
            // 
            this.successButton1.BackColor = System.Drawing.Color.Green;
            this.successButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successButton1.Location = new System.Drawing.Point(60, 23);
            this.successButton1.Name = "successButton1";
            this.successButton1.Size = new System.Drawing.Size(285, 78);
            this.successButton1.TabIndex = 3;
            this.successButton1.Text = "successButton1";
            this.successButton1.UseVisualStyleBackColor = false;
            this.successButton1.Click += new System.EventHandler(this.SuccessButton1_Click);
            // 
            // BtnPersonDTO
            // 
            this.BtnPersonDTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPersonDTO.Location = new System.Drawing.Point(595, 23);
            this.BtnPersonDTO.Name = "BtnPersonDTO";
            this.BtnPersonDTO.Size = new System.Drawing.Size(230, 94);
            this.BtnPersonDTO.TabIndex = 4;
            this.BtnPersonDTO.Text = "نمایش اطلاعات خاص اشخاص";
            this.BtnPersonDTO.UseVisualStyleBackColor = true;
            this.BtnPersonDTO.Click += new System.EventHandler(this.BtnPersonDTO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 630);
            this.Controls.Add(this.BtnPersonDTO);
            this.Controls.Add(this.successButton1);
            this.Controls.Add(this.BtnDisplayOrders);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnDisplayOrders;
        private CustomControl.SuccessButton successButton1;
        private System.Windows.Forms.Button BtnPersonDTO;
    }
}

