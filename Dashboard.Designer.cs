namespace CafeSystem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.update1 = new CafeSystem.UserControls.Update();
            this.remove1 = new CafeSystem.UserControls.Remove();
            this.order1 = new CafeSystem.UserControls.Order();
            this.add1 = new CafeSystem.UserControls.Add();
            this.exitButton = new System.Windows.Forms.Button();
            this.helper = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helper);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.RemoveItemButton);
            this.panel1.Controls.Add(this.UpdateItemButton);
            this.panel1.Controls.Add(this.addItemButton);
            this.panel1.Controls.Add(this.orderButton);
            this.panel1.Location = new System.Drawing.Point(26, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 462);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.logoutButton.ForeColor = System.Drawing.Color.Black;
            this.logoutButton.Location = new System.Drawing.Point(27, 421);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 28);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.RemoveItemButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveItemButton.Location = new System.Drawing.Point(27, 216);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(91, 28);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove item";
            this.RemoveItemButton.UseVisualStyleBackColor = false;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.UpdateItemButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateItemButton.Location = new System.Drawing.Point(27, 156);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(91, 28);
            this.UpdateItemButton.TabIndex = 2;
            this.UpdateItemButton.Text = "Update item";
            this.UpdateItemButton.UseVisualStyleBackColor = false;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.addItemButton.ForeColor = System.Drawing.Color.Black;
            this.addItemButton.Location = new System.Drawing.Point(27, 98);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(91, 28);
            this.addItemButton.TabIndex = 1;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.orderButton.ForeColor = System.Drawing.Color.Black;
            this.orderButton.Location = new System.Drawing.Point(27, 40);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(91, 28);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.update1);
            this.panel2.Controls.Add(this.remove1);
            this.panel2.Controls.Add(this.order1);
            this.panel2.Controls.Add(this.add1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(169, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 462);
            this.panel2.TabIndex = 1;
            // 
            // update1
            // 
            this.update1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.update1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.update1.Location = new System.Drawing.Point(0, 0);
            this.update1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(712, 462);
            this.update1.TabIndex = 3;
            this.update1.Load += new System.EventHandler(this.update1_Load);
            // 
            // remove1
            // 
            this.remove1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remove1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.remove1.Location = new System.Drawing.Point(0, 0);
            this.remove1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove1.Name = "remove1";
            this.remove1.Size = new System.Drawing.Size(710, 460);
            this.remove1.TabIndex = 2;
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.order1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.order1.Location = new System.Drawing.Point(0, 0);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(710, 460);
            this.order1.TabIndex = 1;
            // 
            // add1
            // 
            this.add1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add1.Location = new System.Drawing.Point(0, 0);
            this.add1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(710, 460);
            this.add1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(808, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helper
            // 
            this.helper.AutoSize = true;
            this.helper.Location = new System.Drawing.Point(49, 281);
            this.helper.Name = "helper";
            this.helper.Size = new System.Drawing.Size(51, 20);
            this.helper.TabIndex = 5;
            this.helper.Text = "label1";
            this.helper.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(912, 538);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button exitButton;
        private UserControls.Remove remove1;
        private UserControls.Order order1;
        private UserControls.Add add1;
        private UserControls.Update update1;
        private System.Windows.Forms.Label helper;
    }
}