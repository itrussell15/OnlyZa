
namespace OnlyZa
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.order_tab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.Carryout_time = new System.Windows.Forms.Label();
            this.Order_button = new System.Windows.Forms.Button();
            this.Store_Status_label = new System.Windows.Forms.Label();
            this.Store_Status = new System.Windows.Forms.TextBox();
            this.Carryout_label = new System.Windows.Forms.Label();
            this.Delivery_time = new System.Windows.Forms.Label();
            this.setting_tab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Store_info = new System.Windows.Forms.Label();
            this.Stores_Box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Zip_text = new System.Windows.Forms.TextBox();
            this.State_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.City_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Address_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LName_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FName_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MethodBox = new System.Windows.Forms.ComboBox();
            this.Tabs.SuspendLayout();
            this.order_tab.SuspendLayout();
            this.setting_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.order_tab);
            this.Tabs.Controls.Add(this.setting_tab);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(629, 187);
            this.Tabs.TabIndex = 0;
            // 
            // order_tab
            // 
            this.order_tab.Controls.Add(this.label11);
            this.order_tab.Controls.Add(this.Carryout_time);
            this.order_tab.Controls.Add(this.Order_button);
            this.order_tab.Controls.Add(this.Store_Status_label);
            this.order_tab.Controls.Add(this.Store_Status);
            this.order_tab.Controls.Add(this.Carryout_label);
            this.order_tab.Controls.Add(this.Delivery_time);
            this.order_tab.Location = new System.Drawing.Point(4, 22);
            this.order_tab.Name = "order_tab";
            this.order_tab.Padding = new System.Windows.Forms.Padding(3);
            this.order_tab.Size = new System.Drawing.Size(621, 161);
            this.order_tab.TabIndex = 0;
            this.order_tab.Text = "Order";
            this.order_tab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Estimated Delivery Time:";
            // 
            // Carryout_time
            // 
            this.Carryout_time.AutoSize = true;
            this.Carryout_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carryout_time.Location = new System.Drawing.Point(14, 128);
            this.Carryout_time.Name = "Carryout_time";
            this.Carryout_time.Size = new System.Drawing.Size(79, 22);
            this.Carryout_time.TabIndex = 5;
            this.Carryout_time.Text = "Carryout";
            // 
            // Order_button
            // 
            this.Order_button.Font = new System.Drawing.Font("Calibri", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_button.Location = new System.Drawing.Point(226, 6);
            this.Order_button.Name = "Order_button";
            this.Order_button.Size = new System.Drawing.Size(389, 149);
            this.Order_button.TabIndex = 4;
            this.Order_button.Text = "ORDER";
            this.Order_button.UseVisualStyleBackColor = true;
            this.Order_button.Click += new System.EventHandler(this.Order_button_Click);
            // 
            // Store_Status_label
            // 
            this.Store_Status_label.AutoSize = true;
            this.Store_Status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Store_Status_label.Location = new System.Drawing.Point(48, 24);
            this.Store_Status_label.Name = "Store_Status_label";
            this.Store_Status_label.Size = new System.Drawing.Size(111, 29);
            this.Store_Status_label.TabIndex = 3;
            this.Store_Status_label.Text = "Available";
            // 
            // Store_Status
            // 
            this.Store_Status.Enabled = false;
            this.Store_Status.Location = new System.Drawing.Point(16, 28);
            this.Store_Status.Name = "Store_Status";
            this.Store_Status.Size = new System.Drawing.Size(20, 20);
            this.Store_Status.TabIndex = 2;
            // 
            // Carryout_label
            // 
            this.Carryout_label.AutoSize = true;
            this.Carryout_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carryout_label.Location = new System.Drawing.Point(13, 109);
            this.Carryout_label.Name = "Carryout_label";
            this.Carryout_label.Size = new System.Drawing.Size(176, 18);
            this.Carryout_label.TabIndex = 1;
            this.Carryout_label.Text = "Estimated Carryout Time:";
            // 
            // Delivery_time
            // 
            this.Delivery_time.AutoSize = true;
            this.Delivery_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivery_time.Location = new System.Drawing.Point(14, 80);
            this.Delivery_time.Name = "Delivery_time";
            this.Delivery_time.Size = new System.Drawing.Size(75, 22);
            this.Delivery_time.TabIndex = 0;
            this.Delivery_time.Text = "Delivery";
            // 
            // setting_tab
            // 
            this.setting_tab.Controls.Add(this.label10);
            this.setting_tab.Controls.Add(this.MethodBox);
            this.setting_tab.Controls.Add(this.label9);
            this.setting_tab.Controls.Add(this.label8);
            this.setting_tab.Controls.Add(this.Store_info);
            this.setting_tab.Controls.Add(this.Stores_Box);
            this.setting_tab.Controls.Add(this.label7);
            this.setting_tab.Controls.Add(this.Zip_text);
            this.setting_tab.Controls.Add(this.State_text);
            this.setting_tab.Controls.Add(this.label6);
            this.setting_tab.Controls.Add(this.City_text);
            this.setting_tab.Controls.Add(this.label5);
            this.setting_tab.Controls.Add(this.Address_text);
            this.setting_tab.Controls.Add(this.label4);
            this.setting_tab.Controls.Add(this.Phone_text);
            this.setting_tab.Controls.Add(this.label3);
            this.setting_tab.Controls.Add(this.LName_text);
            this.setting_tab.Controls.Add(this.label2);
            this.setting_tab.Controls.Add(this.FName_text);
            this.setting_tab.Controls.Add(this.label1);
            this.setting_tab.Location = new System.Drawing.Point(4, 22);
            this.setting_tab.Name = "setting_tab";
            this.setting_tab.Padding = new System.Windows.Forms.Padding(3);
            this.setting_tab.Size = new System.Drawing.Size(621, 161);
            this.setting_tab.TabIndex = 1;
            this.setting_tab.Text = "Settings";
            this.setting_tab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Store ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Current Store";
            // 
            // Store_info
            // 
            this.Store_info.AutoSize = true;
            this.Store_info.Location = new System.Drawing.Point(291, 94);
            this.Store_info.Name = "Store_info";
            this.Store_info.Size = new System.Drawing.Size(50, 13);
            this.Store_info.TabIndex = 16;
            this.Store_info.Text = "StoreInfo";
            // 
            // Stores_Box
            // 
            this.Stores_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Stores_Box.FormattingEnabled = true;
            this.Stores_Box.Location = new System.Drawing.Point(373, 32);
            this.Stores_Box.Name = "Stores_Box";
            this.Stores_Box.Size = new System.Drawing.Size(90, 21);
            this.Stores_Box.TabIndex = 15;
            this.Stores_Box.SelectedValueChanged += new System.EventHandler(this.Stores_Box_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Zip";
            // 
            // Zip_text
            // 
            this.Zip_text.Location = new System.Drawing.Point(267, 33);
            this.Zip_text.Name = "Zip_text";
            this.Zip_text.Size = new System.Drawing.Size(74, 20);
            this.Zip_text.TabIndex = 13;
            // 
            // State_text
            // 
            this.State_text.Location = new System.Drawing.Point(131, 124);
            this.State_text.Name = "State_text";
            this.State_text.Size = new System.Drawing.Size(115, 20);
            this.State_text.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "State";
            // 
            // City_text
            // 
            this.City_text.Location = new System.Drawing.Point(131, 79);
            this.City_text.Name = "City_text";
            this.City_text.Size = new System.Drawing.Size(115, 20);
            this.City_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            // 
            // Address_text
            // 
            this.Address_text.Location = new System.Drawing.Point(131, 33);
            this.Address_text.Name = "Address_text";
            this.Address_text.Size = new System.Drawing.Size(115, 20);
            this.Address_text.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(11, 124);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(100, 20);
            this.Phone_text.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // LName_text
            // 
            this.LName_text.Location = new System.Drawing.Point(11, 79);
            this.LName_text.Name = "LName_text";
            this.LName_text.Size = new System.Drawing.Size(100, 20);
            this.LName_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // FName_text
            // 
            this.FName_text.Location = new System.Drawing.Point(11, 33);
            this.FName_text.Name = "FName_text";
            this.FName_text.Size = new System.Drawing.Size(100, 20);
            this.FName_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(495, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Method";
            // 
            // MethodBox
            // 
            this.MethodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodBox.FormattingEnabled = true;
            this.MethodBox.Location = new System.Drawing.Point(491, 32);
            this.MethodBox.Name = "MethodBox";
            this.MethodBox.Size = new System.Drawing.Size(101, 21);
            this.MethodBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 186);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "EasyZa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabs.ResumeLayout(false);
            this.order_tab.ResumeLayout(false);
            this.order_tab.PerformLayout();
            this.setting_tab.ResumeLayout(false);
            this.setting_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage order_tab;
        private System.Windows.Forms.TabPage setting_tab;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LName_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FName_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox State_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox City_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Zip_text;
        private System.Windows.Forms.ComboBox Stores_Box;
        private System.Windows.Forms.Label Store_info;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Order_button;
        private System.Windows.Forms.Label Store_Status_label;
        private System.Windows.Forms.TextBox Store_Status;
        private System.Windows.Forms.Label Carryout_label;
        private System.Windows.Forms.Label Delivery_time;
        private System.Windows.Forms.Label Carryout_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MethodBox;
    }
}

