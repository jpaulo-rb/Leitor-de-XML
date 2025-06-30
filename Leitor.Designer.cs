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
            bodyPnl = new Panel();
            docGrid = new DataGridView();
            footerPnl = new Panel();
            buscarXmlBtn = new Button();
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
            bodyPnl.Size = new Size(367, 309);
            bodyPnl.TabIndex = 0;
            // 
            // docGrid
            // 
            docGrid.AllowUserToAddRows = false;
            docGrid.AllowUserToDeleteRows = false;
            docGrid.AllowUserToResizeRows = false;
            docGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            docGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            docGrid.BackgroundColor = Color.WhiteSmoke;
            docGrid.BorderStyle = BorderStyle.None;
            docGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            docGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            docGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            docGrid.DefaultCellStyle = dataGridViewCellStyle2;
            docGrid.Dock = DockStyle.Fill;
            docGrid.EnableHeadersVisualStyles = false;
            docGrid.GridColor = Color.DarkGray;
            docGrid.Location = new Point(0, 0);
            docGrid.Margin = new Padding(0);
            docGrid.Name = "docGrid";
            docGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            docGrid.RowHeadersWidth = 24;
            docGrid.Size = new Size(367, 309);
            docGrid.TabIndex = 0;
            // 
            // footerPnl
            // 
            footerPnl.BackColor = Color.WhiteSmoke;
            footerPnl.Controls.Add(buscarXmlBtn);
            footerPnl.Dock = DockStyle.Bottom;
            footerPnl.Location = new Point(0, 309);
            footerPnl.Margin = new Padding(0);
            footerPnl.Name = "footerPnl";
            footerPnl.Size = new Size(367, 96);
            footerPnl.TabIndex = 1;
            // 
            // buscarXmlBtn
            // 
            buscarXmlBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buscarXmlBtn.BackColor = Color.Cyan;
            buscarXmlBtn.Cursor = Cursors.Hand;
            buscarXmlBtn.FlatAppearance.BorderColor = Color.DarkTurquoise;
            buscarXmlBtn.FlatStyle = FlatStyle.Flat;
            buscarXmlBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            buscarXmlBtn.Location = new Point(223, 24);
            buscarXmlBtn.Margin = new Padding(0);
            buscarXmlBtn.Name = "buscarXmlBtn";
            buscarXmlBtn.Size = new Size(120, 48);
            buscarXmlBtn.TabIndex = 0;
            buscarXmlBtn.Text = "Buscar XML";
            buscarXmlBtn.UseVisualStyleBackColor = false;
            buscarXmlBtn.Click += buscarXmlBtn_Click;
            // 
            // Leitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(367, 405);
            Controls.Add(bodyPnl);
            Controls.Add(footerPnl);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            Name = "Leitor";
            Text = "Form1";
            bodyPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)docGrid).EndInit();
            footerPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel bodyPnl;
        private Panel footerPnl;
        private DataGridView docGrid;
        private Button buscarXmlBtn;
    }
}
