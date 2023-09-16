namespace pizza
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rb_large = new System.Windows.Forms.RadioButton();
            this.Rb_medium = new System.Windows.Forms.RadioButton();
            this.Rb_small = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Beef = new System.Windows.Forms.CheckBox();
            this.Tomatoes = new System.Windows.Forms.CheckBox();
            this.Shrimps = new System.Windows.Forms.CheckBox();
            this.Chicken = new System.Windows.Forms.CheckBox();
            this.Spanich = new System.Windows.Forms.CheckBox();
            this.Pineapple = new System.Windows.Forms.CheckBox();
            this.Jalapeno = new System.Windows.Forms.CheckBox();
            this.Bacon = new System.Windows.Forms.CheckBox();
            this.Ham = new System.Windows.Forms.CheckBox();
            this.Mushroom = new System.Windows.Forms.CheckBox();
            this.Extra_Cheese = new System.Windows.Forms.CheckBox();
            this.Papperoni = new System.Windows.Forms.CheckBox();
            this.lista = new System.Windows.Forms.Label();
            this.myButton_confirmO = new System.Windows.Forms.Button();
            this.myButton_pay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rb_large);
            this.groupBox1.Controls.Add(this.Rb_medium);
            this.groupBox1.Controls.Add(this.Rb_small);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox1.Location = new System.Drawing.Point(21, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza Size";
            // 
            // Rb_large
            // 
            this.Rb_large.AutoSize = true;
            this.Rb_large.Location = new System.Drawing.Point(27, 162);
            this.Rb_large.Name = "Rb_large";
            this.Rb_large.Size = new System.Drawing.Size(171, 30);
            this.Rb_large.TabIndex = 2;
            this.Rb_large.Text = "Large ($13.00)";
            this.Rb_large.UseVisualStyleBackColor = true;
            // 
            // Rb_medium
            // 
            this.Rb_medium.AutoSize = true;
            this.Rb_medium.Location = new System.Drawing.Point(27, 102);
            this.Rb_medium.Name = "Rb_medium";
            this.Rb_medium.Size = new System.Drawing.Size(182, 30);
            this.Rb_medium.TabIndex = 1;
            this.Rb_medium.Text = "Medium ($7.00)";
            this.Rb_medium.UseVisualStyleBackColor = true;
            // 
            // Rb_small
            // 
            this.Rb_small.AutoSize = true;
            this.Rb_small.Checked = true;
            this.Rb_small.Location = new System.Drawing.Point(27, 43);
            this.Rb_small.Name = "Rb_small";
            this.Rb_small.Size = new System.Drawing.Size(160, 30);
            this.Rb_small.TabIndex = 0;
            this.Rb_small.TabStop = true;
            this.Rb_small.Text = "Small ($4.00)";
            this.Rb_small.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox2.Location = new System.Drawing.Point(262, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(18, 162);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(116, 30);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "Sausage";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(18, 102);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 30);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.Text = "Cheesy";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 30);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Normal";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Beef);
            this.groupBox3.Controls.Add(this.Tomatoes);
            this.groupBox3.Controls.Add(this.Shrimps);
            this.groupBox3.Controls.Add(this.Chicken);
            this.groupBox3.Controls.Add(this.Spanich);
            this.groupBox3.Controls.Add(this.Pineapple);
            this.groupBox3.Controls.Add(this.Jalapeno);
            this.groupBox3.Controls.Add(this.Bacon);
            this.groupBox3.Controls.Add(this.Ham);
            this.groupBox3.Controls.Add(this.Mushroom);
            this.groupBox3.Controls.Add(this.Extra_Cheese);
            this.groupBox3.Controls.Add(this.Papperoni);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBox3.Location = new System.Drawing.Point(496, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 213);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Topping ($2 each)";
            // 
            // Beef
            // 
            this.Beef.AutoSize = true;
            this.Beef.Location = new System.Drawing.Point(514, 155);
            this.Beef.Name = "Beef";
            this.Beef.Size = new System.Drawing.Size(76, 30);
            this.Beef.TabIndex = 11;
            this.Beef.Text = "Beef";
            this.Beef.UseVisualStyleBackColor = true;
            // 
            // Tomatoes
            // 
            this.Tomatoes.AutoSize = true;
            this.Tomatoes.Location = new System.Drawing.Point(514, 98);
            this.Tomatoes.Name = "Tomatoes";
            this.Tomatoes.Size = new System.Drawing.Size(127, 30);
            this.Tomatoes.TabIndex = 10;
            this.Tomatoes.Text = "Tomatoes";
            this.Tomatoes.UseVisualStyleBackColor = true;
            // 
            // Shrimps
            // 
            this.Shrimps.AutoSize = true;
            this.Shrimps.Location = new System.Drawing.Point(514, 45);
            this.Shrimps.Name = "Shrimps";
            this.Shrimps.Size = new System.Drawing.Size(112, 30);
            this.Shrimps.TabIndex = 9;
            this.Shrimps.Text = "Shrimps";
            this.Shrimps.UseVisualStyleBackColor = true;
            // 
            // Chicken
            // 
            this.Chicken.AutoSize = true;
            this.Chicken.Location = new System.Drawing.Point(356, 155);
            this.Chicken.Name = "Chicken";
            this.Chicken.Size = new System.Drawing.Size(110, 30);
            this.Chicken.TabIndex = 8;
            this.Chicken.Text = "Chicken";
            this.Chicken.UseVisualStyleBackColor = true;
            // 
            // Spanich
            // 
            this.Spanich.AutoSize = true;
            this.Spanich.Location = new System.Drawing.Point(356, 98);
            this.Spanich.Name = "Spanich";
            this.Spanich.Size = new System.Drawing.Size(110, 30);
            this.Spanich.TabIndex = 7;
            this.Spanich.Text = "Spanich";
            this.Spanich.UseVisualStyleBackColor = true;
            // 
            // Pineapple
            // 
            this.Pineapple.AutoSize = true;
            this.Pineapple.Location = new System.Drawing.Point(356, 45);
            this.Pineapple.Name = "Pineapple";
            this.Pineapple.Size = new System.Drawing.Size(128, 30);
            this.Pineapple.TabIndex = 6;
            this.Pineapple.Text = "Pineapple";
            this.Pineapple.UseVisualStyleBackColor = true;
            // 
            // Jalapeno
            // 
            this.Jalapeno.AutoSize = true;
            this.Jalapeno.Location = new System.Drawing.Point(198, 155);
            this.Jalapeno.Name = "Jalapeno";
            this.Jalapeno.Size = new System.Drawing.Size(119, 30);
            this.Jalapeno.TabIndex = 5;
            this.Jalapeno.Text = "Jalapeno";
            this.Jalapeno.UseVisualStyleBackColor = true;
            // 
            // Bacon
            // 
            this.Bacon.AutoSize = true;
            this.Bacon.Location = new System.Drawing.Point(198, 98);
            this.Bacon.Name = "Bacon";
            this.Bacon.Size = new System.Drawing.Size(93, 30);
            this.Bacon.TabIndex = 4;
            this.Bacon.Text = "Bacon";
            this.Bacon.UseVisualStyleBackColor = true;
            // 
            // Ham
            // 
            this.Ham.AutoSize = true;
            this.Ham.Location = new System.Drawing.Point(198, 45);
            this.Ham.Name = "Ham";
            this.Ham.Size = new System.Drawing.Size(78, 30);
            this.Ham.TabIndex = 3;
            this.Ham.Text = "Ham";
            this.Ham.UseVisualStyleBackColor = true;
            // 
            // Mushroom
            // 
            this.Mushroom.AutoSize = true;
            this.Mushroom.Location = new System.Drawing.Point(27, 155);
            this.Mushroom.Name = "Mushroom";
            this.Mushroom.Size = new System.Drawing.Size(134, 30);
            this.Mushroom.TabIndex = 2;
            this.Mushroom.Text = "Mushroom";
            this.Mushroom.UseVisualStyleBackColor = true;
            // 
            // Extra_Cheese
            // 
            this.Extra_Cheese.AutoSize = true;
            this.Extra_Cheese.Location = new System.Drawing.Point(27, 98);
            this.Extra_Cheese.Name = "Extra_Cheese";
            this.Extra_Cheese.Size = new System.Drawing.Size(163, 30);
            this.Extra_Cheese.TabIndex = 1;
            this.Extra_Cheese.Text = "Extra Cheese";
            this.Extra_Cheese.UseVisualStyleBackColor = true;
            // 
            // Papperoni
            // 
            this.Papperoni.AutoSize = true;
            this.Papperoni.Location = new System.Drawing.Point(27, 45);
            this.Papperoni.Name = "Papperoni";
            this.Papperoni.Size = new System.Drawing.Size(130, 30);
            this.Papperoni.TabIndex = 0;
            this.Papperoni.Text = "Papperoni";
            this.Papperoni.UseVisualStyleBackColor = true;
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.Color.White;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lista.Location = new System.Drawing.Point(262, 260);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(618, 284);
            this.lista.TabIndex = 6;
            this.lista.Text = "(Your order it will appear here)";
            // 
            // myButton_confirmO
            // 
            this.myButton_confirmO.BackColor = System.Drawing.Color.White;
            this.myButton_confirmO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.myButton_confirmO.Location = new System.Drawing.Point(924, 291);
            this.myButton_confirmO.Name = "myButton_confirmO";
            this.myButton_confirmO.Size = new System.Drawing.Size(213, 61);
            this.myButton_confirmO.TabIndex = 7;
            this.myButton_confirmO.Text = "Confirm Order";
            this.myButton_confirmO.UseVisualStyleBackColor = false;
            this.myButton_confirmO.Click += new System.EventHandler(this.myButton_confirmO_Click);
            // 
            // myButton_pay
            // 
            this.myButton_pay.BackColor = System.Drawing.Color.White;
            this.myButton_pay.Enabled = false;
            this.myButton_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.myButton_pay.Location = new System.Drawing.Point(928, 395);
            this.myButton_pay.Name = "myButton_pay";
            this.myButton_pay.Size = new System.Drawing.Size(213, 61);
            this.myButton_pay.TabIndex = 8;
            this.myButton_pay.Text = "Pay";
            this.myButton_pay.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1201, 553);
            this.Controls.Add(this.myButton_pay);
            this.Controls.Add(this.myButton_confirmO);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza Express";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_large;
        private System.Windows.Forms.RadioButton Rb_medium;
        private System.Windows.Forms.RadioButton Rb_small;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Beef;
        private System.Windows.Forms.CheckBox Tomatoes;
        private System.Windows.Forms.CheckBox Shrimps;
        private System.Windows.Forms.CheckBox Chicken;
        private System.Windows.Forms.CheckBox Spanich;
        private System.Windows.Forms.CheckBox Pineapple;
        private System.Windows.Forms.CheckBox Jalapeno;
        private System.Windows.Forms.CheckBox Bacon;
        private System.Windows.Forms.CheckBox Ham;
        private System.Windows.Forms.CheckBox Mushroom;
        private System.Windows.Forms.CheckBox Extra_Cheese;
        private System.Windows.Forms.CheckBox Papperoni;
        private System.Windows.Forms.Label lista;
        private System.Windows.Forms.Button myButton_confirmO;
        private System.Windows.Forms.Button myButton_pay;
    }
}

