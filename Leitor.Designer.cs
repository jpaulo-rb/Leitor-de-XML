namespace Leitor_de_XML
{
    partial class Leitor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leitor));
            bodyPnl = new Panel();
            docGrid = new DataGridView();
            footerPnl = new Panel();
            buscarXmlBtn = new Button();
            borderFooter = new Panel();
            bodyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docGrid).BeginInit();
            footerPnl.SuspendLayout();
            SuspendLayout();
            // 
            // bodyPnl
            // 
            bodyPnl.Controls.Add(docGrid);
            bodyPnl.Dock = DockStyle.Fill;
            bodyPnl.Location = new Point(0, 0);
            bodyPnl.Margin = new Padding(0);
            bodyPnl.Name = "bodyPnl";
            bodyPnl.Size = new Size(484, 398);
            bodyPnl.TabIndex = 0;
            // 
            // docGrid
            // 
            docGrid.AllowUserToAddRows = false;
            docGrid.AllowUserToDeleteRows = false;
            docGrid.AllowUserToOrderColumns = true;
            docGrid.AllowUserToResizeRows = false;
            docGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            docGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            docGrid.BackgroundColor = Color.WhiteSmoke;
            docGrid.BorderStyle = BorderStyle.None;
            docGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle1.ForeColor = Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            docGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            docGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = Color.DimGray;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            docGrid.DefaultCellStyle = dataGridViewCellStyle2;
            docGrid.Dock = DockStyle.Fill;
            docGrid.EnableHeadersVisualStyles = false;
            docGrid.GridColor = Color.Gainsboro;
            docGrid.Location = new Point(0, 0);
            docGrid.Margin = new Padding(0);
            docGrid.Name = "docGrid";
            docGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            docGrid.RowHeadersWidth = 24;
            docGrid.Size = new Size(484, 398);
            docGrid.TabIndex = 0;
            // 
            // footerPnl
            // 
            footerPnl.BackColor = Color.WhiteSmoke;
            footerPnl.Controls.Add(buscarXmlBtn);
            footerPnl.Dock = DockStyle.Bottom;
            footerPnl.Location = new Point(0, 401);
            footerPnl.Margin = new Padding(0);
            footerPnl.Name = "footerPnl";
            footerPnl.Size = new Size(484, 60);
            footerPnl.TabIndex = 1;
            // 
            // buscarXmlBtn
            // 
            buscarXmlBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buscarXmlBtn.AutoSize = true;
            buscarXmlBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buscarXmlBtn.BackColor = Color.Gainsboro;
            buscarXmlBtn.Cursor = Cursors.Hand;
            buscarXmlBtn.FlatAppearance.BorderColor = Color.Gray;
            buscarXmlBtn.FlatStyle = FlatStyle.Flat;
            buscarXmlBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buscarXmlBtn.ForeColor = Color.DimGray;
            buscarXmlBtn.Location = new Point(357, 15);
            buscarXmlBtn.Margin = new Padding(0, 0, 20, 0);
            buscarXmlBtn.Name = "buscarXmlBtn";
            buscarXmlBtn.Size = new Size(98, 31);
            buscarXmlBtn.TabIndex = 0;
            buscarXmlBtn.Text = "Buscar XML";
            buscarXmlBtn.UseVisualStyleBackColor = false;
            buscarXmlBtn.Click += buscarXmlBtn_Click;
            // 
            // borderFooter
            // 
            borderFooter.BackColor = Color.Silver;
            borderFooter.Dock = DockStyle.Bottom;
            borderFooter.Location = new Point(0, 398);
            borderFooter.Margin = new Padding(0);
            borderFooter.Name = "borderFooter";
            borderFooter.Size = new Size(484, 3);
            borderFooter.TabIndex = 1;
            // 
            // Leitor
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(484, 461);
            Controls.Add(bodyPnl);
            Controls.Add(borderFooter);
            Controls.Add(footerPnl);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            ForeColor = Color.DimGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Leitor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leitor";
            bodyPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)docGrid).EndInit();
            footerPnl.ResumeLayout(false);
            footerPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bodyPnl;
        private Panel footerPnl;
        private DataGridView docGrid;
        private Button buscarXmlBtn;
        private Panel borderFooter;
    }
}
