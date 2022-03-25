using System;
using System.Windows.Forms;

namespace ExamenII_EmanuelFerrera
{
    partial class FrmMenu
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
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.ProductosToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.ListaProductoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripTabItem2 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.toolStripEx2 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.PedidosToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.ProductosToolStripEx.SuspendLayout();
            this.toolStripTabItem2.Panel.SuspendLayout();
            this.toolStripEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ribbonControlAdv1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControlAdv1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.ribbonControlAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2);
            this.ribbonControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlAdv1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControlAdv1.MenuButtonFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ribbonControlAdv1.MenuButtonText = "";
            this.ribbonControlAdv1.MenuButtonWidth = 56;
            this.ribbonControlAdv1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            this.ribbonControlAdv1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.ribbonControlAdv1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013;
            this.ribbonControlAdv1.SelectedTab = this.toolStripTabItem1;
            this.ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            this.ribbonControlAdv1.Size = new System.Drawing.Size(740, 105);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            this.ribbonControlAdv1.ThemeName = "Office2013";
            this.ribbonControlAdv1.ThemeStyle.MoreCommandsStyle.PropertyGridViewBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.ProductosToolStripEx);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Productos";
            this.toolStripTabItem1.Position = 0;
            this.toolStripTabItem1.Size = new System.Drawing.Size(90, 25);
            this.toolStripTabItem1.Tag = "1";
            this.toolStripTabItem1.Text = "Productos";
            this.toolStripTabItem1.Click += new System.EventHandler(this.ProductosToolStripTabItem_Click);
            // 
            // ProductosToolStripEx
            // 
            this.ProductosToolStripEx.AutoSize = false;
            this.ProductosToolStripEx.Dock = System.Windows.Forms.DockStyle.None;
            this.ProductosToolStripEx.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ProductosToolStripEx.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProductosToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ProductosToolStripEx.Image = global::ExamenII_EmanuelFerrera.Properties.Resources.Producto;
            this.ProductosToolStripEx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaProductoToolStripButton});
            this.ProductosToolStripEx.Location = new System.Drawing.Point(0, 1);
            this.ProductosToolStripEx.Name = "ProductosToolStripEx";
            this.ProductosToolStripEx.Office12Mode = false;
            this.ProductosToolStripEx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductosToolStripEx.Size = new System.Drawing.Size(158, 49);
            this.ProductosToolStripEx.TabIndex = 0;
            this.ProductosToolStripEx.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ProductoToolStripEx_ItemClicked);
            // 
            // ListaProductoToolStripButton
            // 
            this.ListaProductoToolStripButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ListaProductoToolStripButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProductoToolStripButton.ForeColor = System.Drawing.Color.Black;
            this.ListaProductoToolStripButton.Image = global::ExamenII_EmanuelFerrera.Properties.Resources.Producto;
            this.ListaProductoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListaProductoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListaProductoToolStripButton.Name = "ListaProductoToolStripButton";
            this.ListaProductoToolStripButton.Size = new System.Drawing.Size(125, 32);
            this.ListaProductoToolStripButton.Text = "Lista de Productos";
            this.ListaProductoToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ListaProductoToolStripButton.Click += new System.EventHandler(this.ListaProductoToolStripButton_Click);
            // 
            // toolStripTabItem2
            // 
            this.toolStripTabItem2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTabItem2.Name = "toolStripTabItem2";
            // 
            // ribbonControlAdv1.ribbonPanel2
            // 
            this.toolStripTabItem2.Panel.Controls.Add(this.toolStripEx2);
            this.toolStripTabItem2.Panel.Name = "ribbonPanel2";
            this.toolStripTabItem2.Panel.ScrollPosition = 0;
            this.toolStripTabItem2.Panel.TabIndex = 3;
            this.toolStripTabItem2.Panel.Text = "Pedidos";
            this.toolStripTabItem2.Position = 1;
            this.toolStripTabItem2.Size = new System.Drawing.Size(78, 25);
            this.toolStripTabItem2.Tag = "2";
            this.toolStripTabItem2.Text = "Pedidos";
            // 
            // toolStripEx2
            // 
            this.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx2.Image = null;
            this.toolStripEx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PedidosToolStripButton});
            this.toolStripEx2.Location = new System.Drawing.Point(0, 1);
            this.toolStripEx2.Name = "toolStripEx2";
            this.toolStripEx2.Office12Mode = false;
            this.toolStripEx2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripEx2.Size = new System.Drawing.Size(140, 49);
            this.toolStripEx2.TabIndex = 0;
            // 
            // PedidosToolStripButton
            // 
            this.PedidosToolStripButton.AutoSize = false;
            this.PedidosToolStripButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedidosToolStripButton.ForeColor = System.Drawing.Color.Black;
            this.PedidosToolStripButton.Image = global::ExamenII_EmanuelFerrera.Properties.Resources.Pedido;
            this.PedidosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PedidosToolStripButton.Name = "PedidosToolStripButton";
            this.PedidosToolStripButton.Size = new System.Drawing.Size(133, 32);
            this.PedidosToolStripButton.Text = "Pedidos de Clientes";
            this.PedidosToolStripButton.Click += new System.EventHandler(this.PedidosToolStripButton_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamenII_EmanuelFerrera.Properties.Resources.FrmMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CaptionForeColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(740, 380);
            this.Controls.Add(this.ribbonControlAdv1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.ProductosToolStripEx.ResumeLayout(false);
            this.ProductosToolStripEx.PerformLayout();
            this.toolStripTabItem2.Panel.ResumeLayout(false);
            this.toolStripTabItem2.Panel.PerformLayout();
            this.toolStripEx2.ResumeLayout(false);
            this.toolStripEx2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PedidosToolStripButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProductoToolStripEx_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ProductosToolStripTabItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem2;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx ProductosToolStripEx;
        private System.Windows.Forms.ToolStripButton ListaProductoToolStripButton;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx2;
        private ToolStripButton PedidosToolStripButton;
    }
}