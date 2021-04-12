
namespace Gen_6_TID_SID_to_time
{
    partial class Form1
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.year_laber = new System.Windows.Forms.Label();
            this.sid_label = new System.Windows.Forms.Label();
            this.year_box = new System.Windows.Forms.NumericUpDown();
            this.tid_box = new System.Windows.Forms.NumericUpDown();
            this.sid_box = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.game = new System.Windows.Forms.ComboBox();
            this.game_label = new System.Windows.Forms.Label();
            this.date_message = new System.Windows.Forms.Label();
            this.tiny_3 = new System.Windows.Forms.TextBox();
            this.tiny_2 = new System.Windows.Forms.TextBox();
            this.tiny_1 = new System.Windows.Forms.TextBox();
            this.tiny_0 = new System.Windows.Forms.TextBox();
            this.text_3 = new System.Windows.Forms.Label();
            this.text_2 = new System.Windows.Forms.Label();
            this.text_1 = new System.Windows.Forms.Label();
            this.text_0 = new System.Windows.Forms.Label();
            this.min_frame = new System.Windows.Forms.NumericUpDown();
            this.max_frame = new System.Windows.Forms.NumericUpDown();
            this.min_label = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.srch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.year_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tid_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sid_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // year_laber
            // 
            this.year_laber.AutoSize = true;
            this.year_laber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.year_laber.Location = new System.Drawing.Point(12, 82);
            this.year_laber.Name = "year_laber";
            this.year_laber.Size = new System.Drawing.Size(33, 17);
            this.year_laber.TabIndex = 2;
            this.year_laber.Text = "Year";
            // 
            // sid_label
            // 
            this.sid_label.AutoSize = true;
            this.sid_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sid_label.Location = new System.Drawing.Point(12, 142);
            this.sid_label.Name = "sid_label";
            this.sid_label.Size = new System.Drawing.Size(27, 17);
            this.sid_label.TabIndex = 3;
            this.sid_label.Text = "TID";
            // 
            // year_box
            // 
            this.year_box.Location = new System.Drawing.Point(65, 80);
            this.year_box.Maximum = new decimal(new int[] {
            2080,
            0,
            0,
            0});
            this.year_box.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(97, 23);
            this.year_box.TabIndex = 4;
            this.year_box.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.year_box.ValueChanged += new System.EventHandler(this.year_box_ValueChanged);
            // 
            // tid_box
            // 
            this.tid_box.Location = new System.Drawing.Point(65, 140);
            this.tid_box.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.tid_box.Name = "tid_box";
            this.tid_box.Size = new System.Drawing.Size(97, 23);
            this.tid_box.TabIndex = 5;
            // 
            // sid_box
            // 
            this.sid_box.Location = new System.Drawing.Point(65, 170);
            this.sid_box.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.sid_box.Name = "sid_box";
            this.sid_box.Size = new System.Drawing.Size(97, 23);
            this.sid_box.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "SID";
            // 
            // game
            // 
            this.game.FormattingEnabled = true;
            this.game.Items.AddRange(new object[] {
            "XY",
            "ORAS"});
            this.game.Location = new System.Drawing.Point(65, 50);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(97, 23);
            this.game.TabIndex = 8;
            this.game.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // game_label
            // 
            this.game_label.AutoSize = true;
            this.game_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.game_label.Location = new System.Drawing.Point(12, 53);
            this.game_label.Name = "game_label";
            this.game_label.Size = new System.Drawing.Size(42, 17);
            this.game_label.TabIndex = 9;
            this.game_label.Text = "Game";
            // 
            // date_message
            // 
            this.date_message.AutoSize = true;
            this.date_message.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_message.Location = new System.Drawing.Point(194, 33);
            this.date_message.Name = "date_message";
            this.date_message.Size = new System.Drawing.Size(242, 17);
            this.date_message.TabIndex = 10;
            this.date_message.Text = "Set the Citra RTC to 2000-01-01 13:00:00";
            // 
            // tiny_3
            // 
            this.tiny_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tiny_3.Location = new System.Drawing.Point(285, 68);
            this.tiny_3.MaxLength = 8;
            this.tiny_3.Name = "tiny_3";
            this.tiny_3.Size = new System.Drawing.Size(70, 23);
            this.tiny_3.TabIndex = 11;
            this.tiny_3.Text = "00000000";
            this.tiny_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tiny_3.TextChanged += new System.EventHandler(this.tiny_3_TextChanged);
            // 
            // tiny_2
            // 
            this.tiny_2.Location = new System.Drawing.Point(285, 97);
            this.tiny_2.MaxLength = 8;
            this.tiny_2.Name = "tiny_2";
            this.tiny_2.Size = new System.Drawing.Size(70, 23);
            this.tiny_2.TabIndex = 12;
            this.tiny_2.Text = "00000000";
            this.tiny_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tiny_2.TextChanged += new System.EventHandler(this.tiny_2_TextChanged);
            // 
            // tiny_1
            // 
            this.tiny_1.Location = new System.Drawing.Point(285, 126);
            this.tiny_1.MaxLength = 8;
            this.tiny_1.Name = "tiny_1";
            this.tiny_1.Size = new System.Drawing.Size(70, 23);
            this.tiny_1.TabIndex = 13;
            this.tiny_1.Text = "00000000";
            this.tiny_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tiny_1.TextChanged += new System.EventHandler(this.tiny_1_TextChanged);
            // 
            // tiny_0
            // 
            this.tiny_0.Location = new System.Drawing.Point(285, 155);
            this.tiny_0.MaxLength = 8;
            this.tiny_0.Name = "tiny_0";
            this.tiny_0.Size = new System.Drawing.Size(70, 23);
            this.tiny_0.TabIndex = 14;
            this.tiny_0.Text = "00000000";
            this.tiny_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tiny_0.TextChanged += new System.EventHandler(this.tiny_0_TextChanged);
            // 
            // text_3
            // 
            this.text_3.AutoSize = true;
            this.text_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_3.Location = new System.Drawing.Point(256, 68);
            this.text_3.Name = "text_3";
            this.text_3.Size = new System.Drawing.Size(23, 17);
            this.text_3.TabIndex = 15;
            this.text_3.Text = "[3]";
            // 
            // text_2
            // 
            this.text_2.AutoSize = true;
            this.text_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_2.Location = new System.Drawing.Point(256, 97);
            this.text_2.Name = "text_2";
            this.text_2.Size = new System.Drawing.Size(23, 17);
            this.text_2.TabIndex = 16;
            this.text_2.Text = "[2]";
            // 
            // text_1
            // 
            this.text_1.AutoSize = true;
            this.text_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_1.Location = new System.Drawing.Point(256, 126);
            this.text_1.Name = "text_1";
            this.text_1.Size = new System.Drawing.Size(23, 17);
            this.text_1.TabIndex = 17;
            this.text_1.Text = "[1]";
            // 
            // text_0
            // 
            this.text_0.AutoSize = true;
            this.text_0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_0.Location = new System.Drawing.Point(256, 155);
            this.text_0.Name = "text_0";
            this.text_0.Size = new System.Drawing.Size(23, 17);
            this.text_0.TabIndex = 18;
            this.text_0.Text = "[0]";
            // 
            // min_frame
            // 
            this.min_frame.Enabled = false;
            this.min_frame.Location = new System.Drawing.Point(95, 225);
            this.min_frame.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.min_frame.Name = "min_frame";
            this.min_frame.Size = new System.Drawing.Size(67, 23);
            this.min_frame.TabIndex = 19;
            this.min_frame.Visible = false;
            // 
            // max_frame
            // 
            this.max_frame.Location = new System.Drawing.Point(95, 260);
            this.max_frame.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.max_frame.Name = "max_frame";
            this.max_frame.Size = new System.Drawing.Size(67, 23);
            this.max_frame.TabIndex = 20;
            this.max_frame.Visible = false;
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.min_label.Location = new System.Drawing.Point(12, 227);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(70, 17);
            this.min_label.TabIndex = 21;
            this.min_label.Text = "Min Frame";
            this.min_label.Visible = false;
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.max_label.Location = new System.Drawing.Point(12, 262);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(73, 17);
            this.max_label.TabIndex = 22;
            this.max_label.Text = "Max Frame";
            this.max_label.Visible = false;
            // 
            // srch
            // 
            this.srch.Location = new System.Drawing.Point(242, 218);
            this.srch.Name = "srch";
            this.srch.Size = new System.Drawing.Size(180, 40);
            this.srch.TabIndex = 23;
            this.srch.Text = "Search";
            this.srch.UseVisualStyleBackColor = true;
            this.srch.Visible = false;
            this.srch.Click += new System.EventHandler(this.srch_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 308);
            this.Controls.Add(this.srch);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.max_frame);
            this.Controls.Add(this.min_frame);
            this.Controls.Add(this.text_0);
            this.Controls.Add(this.text_1);
            this.Controls.Add(this.text_2);
            this.Controls.Add(this.text_3);
            this.Controls.Add(this.tiny_0);
            this.Controls.Add(this.tiny_1);
            this.Controls.Add(this.tiny_2);
            this.Controls.Add(this.tiny_3);
            this.Controls.Add(this.date_message);
            this.Controls.Add(this.game_label);
            this.Controls.Add(this.game);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sid_box);
            this.Controls.Add(this.tid_box);
            this.Controls.Add(this.year_box);
            this.Controls.Add(this.sid_label);
            this.Controls.Add(this.year_laber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(467, 347);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gen 6 TID/SID to time";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.year_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tid_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sid_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_frame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label year_laber;
        private System.Windows.Forms.Label sid_label;
        private System.Windows.Forms.NumericUpDown year_box;
        private System.Windows.Forms.NumericUpDown tid_box;
        private System.Windows.Forms.NumericUpDown sid_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox game;
        private System.Windows.Forms.Label game_label;
        private System.Windows.Forms.Label date_message;
        private System.Windows.Forms.TextBox tiny_3;
        private System.Windows.Forms.TextBox tiny_2;
        private System.Windows.Forms.TextBox tiny_1;
        private System.Windows.Forms.TextBox tiny_0;
        private System.Windows.Forms.Label text_3;
        private System.Windows.Forms.Label text_2;
        private System.Windows.Forms.Label text_1;
        private System.Windows.Forms.Label text_0;
        private System.Windows.Forms.NumericUpDown min_frame;
        private System.Windows.Forms.NumericUpDown max_frame;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.Button srch;
    }
}

