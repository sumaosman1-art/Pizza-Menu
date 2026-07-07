namespace WindowsFormsApp4
{
    partial class FrmPizzaOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSmallSize = new System.Windows.Forms.RadioButton();
            this.rbMediumSize = new System.Windows.Forms.RadioButton();
            this.rbLargeSize = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbTomato = new System.Windows.Forms.CheckBox();
            this.chbPeppers = new System.Windows.Forms.CheckBox();
            this.chbOnions = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbMushroom = new System.Windows.Forms.CheckBox();
            this.chbExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbDineIn = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btOrderPizza = new System.Windows.Forms.Button();
            this.btResetForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbCrust = new System.Windows.Forms.TextBox();
            this.tbToppings = new System.Windows.Forms.TextBox();
            this.tbWhereToEat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbSmallSize);
            this.gbSize.Controls.Add(this.rbMediumSize);
            this.gbSize.Controls.Add(this.rbLargeSize);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Maroon;
            this.gbSize.Location = new System.Drawing.Point(31, 261);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(200, 226);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbSmallSize
            // 
            this.rbSmallSize.AutoSize = true;
            this.rbSmallSize.Location = new System.Drawing.Point(16, 172);
            this.rbSmallSize.Name = "rbSmallSize";
            this.rbSmallSize.Size = new System.Drawing.Size(116, 36);
            this.rbSmallSize.TabIndex = 2;
            this.rbSmallSize.Tag = "20.0";
            this.rbSmallSize.Text = "Small";
            this.rbSmallSize.UseVisualStyleBackColor = true;
            this.rbSmallSize.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbSmallSize.Click += new System.EventHandler(this.rbSmallSize_CheckedChanged);
            // 
            // rbMediumSize
            // 
            this.rbMediumSize.AutoSize = true;
            this.rbMediumSize.Location = new System.Drawing.Point(16, 108);
            this.rbMediumSize.Name = "rbMediumSize";
            this.rbMediumSize.Size = new System.Drawing.Size(146, 36);
            this.rbMediumSize.TabIndex = 1;
            this.rbMediumSize.Tag = "25.0";
            this.rbMediumSize.Text = "Medium";
            this.rbMediumSize.UseVisualStyleBackColor = true;
            this.rbMediumSize.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbMediumSize.Click += new System.EventHandler(this.rbMediumSize_CheckedChanged);
            // 
            // rbLargeSize
            // 
            this.rbLargeSize.AutoSize = true;
            this.rbLargeSize.Location = new System.Drawing.Point(16, 41);
            this.rbLargeSize.Name = "rbLargeSize";
            this.rbLargeSize.Size = new System.Drawing.Size(117, 36);
            this.rbLargeSize.TabIndex = 0;
            this.rbLargeSize.Tag = "30.0";
            this.rbLargeSize.Text = "Large";
            this.rbLargeSize.UseVisualStyleBackColor = true;
            this.rbLargeSize.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbLargeSize.Click += new System.EventHandler(this.rbLargeSize_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThinCrust);
            this.gbCrust.Controls.Add(this.rbThickCrust);
            this.gbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.Maroon;
            this.gbCrust.Location = new System.Drawing.Point(31, 547);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(200, 166);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(16, 111);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(99, 36);
            this.rbThinCrust.TabIndex = 1;
            this.rbThinCrust.Tag = "1.0";
            this.rbThinCrust.Text = "Thin";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbThinCrust.Click += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(16, 41);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(112, 36);
            this.rbThickCrust.TabIndex = 0;
            this.rbThickCrust.Tag = "3.0";
            this.rbThickCrust.Text = "Thick";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbThickCrust.Click += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.chbTomato);
            this.gbToppings.Controls.Add(this.chbPeppers);
            this.gbToppings.Controls.Add(this.chbOnions);
            this.gbToppings.Controls.Add(this.chbOlives);
            this.gbToppings.Controls.Add(this.chbMushroom);
            this.gbToppings.Controls.Add(this.chbExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.Maroon;
            this.gbToppings.Location = new System.Drawing.Point(237, 262);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(472, 225);
            this.gbToppings.TabIndex = 4;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbTomato
            // 
            this.chbTomato.AutoSize = true;
            this.chbTomato.Location = new System.Drawing.Point(289, 154);
            this.chbTomato.Name = "chbTomato";
            this.chbTomato.Size = new System.Drawing.Size(164, 43);
            this.chbTomato.TabIndex = 5;
            this.chbTomato.Tag = "1.0";
            this.chbTomato.Text = "Tomato";
            this.chbTomato.UseVisualStyleBackColor = true;
            this.chbTomato.CheckedChanged += new System.EventHandler(this.chbTomato_CheckedChanged);
            this.chbTomato.Click += new System.EventHandler(this.chbTomato_CheckedChanged);
            // 
            // chbPeppers
            // 
            this.chbPeppers.AutoSize = true;
            this.chbPeppers.Location = new System.Drawing.Point(289, 92);
            this.chbPeppers.Name = "chbPeppers";
            this.chbPeppers.Size = new System.Drawing.Size(177, 43);
            this.chbPeppers.TabIndex = 4;
            this.chbPeppers.Tag = "2.0";
            this.chbPeppers.Text = "Peppers";
            this.chbPeppers.UseVisualStyleBackColor = true;
            this.chbPeppers.CheckedChanged += new System.EventHandler(this.chbPeppers_CheckedChanged);
            this.chbPeppers.Click += new System.EventHandler(this.chbPeppers_CheckedChanged);
            // 
            // chbOnions
            // 
            this.chbOnions.AutoSize = true;
            this.chbOnions.Location = new System.Drawing.Point(289, 37);
            this.chbOnions.Name = "chbOnions";
            this.chbOnions.Size = new System.Drawing.Size(157, 43);
            this.chbOnions.TabIndex = 3;
            this.chbOnions.Tag = "2.0";
            this.chbOnions.Text = "Onions";
            this.chbOnions.UseVisualStyleBackColor = true;
            this.chbOnions.CheckedChanged += new System.EventHandler(this.chbOnions_CheckedChanged);
            this.chbOnions.Click += new System.EventHandler(this.chbOnions_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Location = new System.Drawing.Point(28, 157);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(144, 43);
            this.chbOlives.TabIndex = 2;
            this.chbOlives.Tag = "3.0";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            this.chbOlives.Click += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbMushroom
            // 
            this.chbMushroom.AutoSize = true;
            this.chbMushroom.Location = new System.Drawing.Point(28, 97);
            this.chbMushroom.Name = "chbMushroom";
            this.chbMushroom.Size = new System.Drawing.Size(191, 43);
            this.chbMushroom.TabIndex = 1;
            this.chbMushroom.Tag = "3.0";
            this.chbMushroom.Text = "Mushrom";
            this.chbMushroom.UseVisualStyleBackColor = true;
            this.chbMushroom.CheckedChanged += new System.EventHandler(this.chbMushroom_CheckedChanged);
            this.chbMushroom.Click += new System.EventHandler(this.chbMushroom_CheckedChanged);
            // 
            // chbExtraChees
            // 
            this.chbExtraChees.AutoSize = true;
            this.chbExtraChees.Location = new System.Drawing.Point(28, 37);
            this.chbExtraChees.Name = "chbExtraChees";
            this.chbExtraChees.Size = new System.Drawing.Size(261, 43);
            this.chbExtraChees.TabIndex = 0;
            this.chbExtraChees.Tag = "5.0";
            this.chbExtraChees.Text = "Extra Cheese";
            this.chbExtraChees.UseVisualStyleBackColor = true;
            this.chbExtraChees.CheckedChanged += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            this.chbExtraChees.Click += new System.EventHandler(this.chbExtraChees_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbDineIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.Maroon;
            this.gbWhereToEat.Location = new System.Drawing.Point(265, 547);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(268, 166);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(16, 111);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(155, 36);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "TakeOut";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbTakeOut.Click += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbDineIn
            // 
            this.rbDineIn.AutoSize = true;
            this.rbDineIn.Location = new System.Drawing.Point(16, 41);
            this.rbDineIn.Name = "rbDineIn";
            this.rbDineIn.Size = new System.Drawing.Size(135, 36);
            this.rbDineIn.TabIndex = 0;
            this.rbDineIn.Text = "Dine In";
            this.rbDineIn.UseVisualStyleBackColor = true;
            this.rbDineIn.CheckedChanged += new System.EventHandler(this.OrderPizzabtEnabled);
            this.rbDineIn.Click += new System.EventHandler(this.rbDineIn_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btOrderPizza
            // 
            this.btOrderPizza.Enabled = false;
            this.btOrderPizza.Location = new System.Drawing.Point(1074, 912);
            this.btOrderPizza.Name = "btOrderPizza";
            this.btOrderPizza.Size = new System.Drawing.Size(134, 44);
            this.btOrderPizza.TabIndex = 15;
            this.btOrderPizza.Text = "Order Pizza";
            this.btOrderPizza.UseVisualStyleBackColor = true;
            this.btOrderPizza.Click += new System.EventHandler(this.btOrderPizza_Click);
            // 
            // btResetForm
            // 
            this.btResetForm.Location = new System.Drawing.Point(1343, 915);
            this.btResetForm.Name = "btResetForm";
            this.btResetForm.Size = new System.Drawing.Size(121, 41);
            this.btResetForm.TabIndex = 16;
            this.btResetForm.Text = "Reset Form";
            this.btResetForm.UseVisualStyleBackColor = true;
            this.btResetForm.Click += new System.EventHandler(this.btResetForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(841, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Order Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(841, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(841, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Crust:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(841, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toppings:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(856, 691);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "Where TO Eat:";
            // 
            // tbSize
            // 
            this.tbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSize.Location = new System.Drawing.Point(1119, 368);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(257, 39);
            this.tbSize.TabIndex = 11;
            // 
            // tbCrust
            // 
            this.tbCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCrust.Location = new System.Drawing.Point(1119, 447);
            this.tbCrust.Name = "tbCrust";
            this.tbCrust.ReadOnly = true;
            this.tbCrust.Size = new System.Drawing.Size(257, 39);
            this.tbCrust.TabIndex = 12;
            // 
            // tbToppings
            // 
            this.tbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToppings.Location = new System.Drawing.Point(1023, 536);
            this.tbToppings.Multiline = true;
            this.tbToppings.Name = "tbToppings";
            this.tbToppings.ReadOnly = true;
            this.tbToppings.Size = new System.Drawing.Size(496, 136);
            this.tbToppings.TabIndex = 13;
            this.tbToppings.Text = "No Toppings";
            // 
            // tbWhereToEat
            // 
            this.tbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWhereToEat.Location = new System.Drawing.Point(1137, 693);
            this.tbWhereToEat.Name = "tbWhereToEat";
            this.tbWhereToEat.ReadOnly = true;
            this.tbWhereToEat.Size = new System.Drawing.Size(259, 39);
            this.tbWhereToEat.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(351, 810);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("EuroRoman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(681, 810);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 45);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "0$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1167, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1552, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btResetForm);
            this.Controls.Add(this.btOrderPizza);
            this.Controls.Add(this.tbWhereToEat);
            this.Controls.Add(this.tbToppings);
            this.Controls.Add(this.tbCrust);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "FrmPizzaOrder";
            this.Text = "Pizza Order";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbSmallSize;
        private System.Windows.Forms.RadioButton rbMediumSize;
        private System.Windows.Forms.RadioButton rbLargeSize;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbTomato;
        private System.Windows.Forms.CheckBox chbPeppers;
        private System.Windows.Forms.CheckBox chbOnions;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbMushroom;
        private System.Windows.Forms.CheckBox chbExtraChees;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbDineIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btOrderPizza;
        private System.Windows.Forms.Button btResetForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.TextBox tbCrust;
        private System.Windows.Forms.TextBox tbToppings;
        private System.Windows.Forms.TextBox tbWhereToEat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

