
namespace Theoretical_Mechanics_Motion_MVP
{
    partial class FormView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PointBCheckBox = new System.Windows.Forms.CheckBox();
            this.PointACheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BigRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SmallRaduisNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCinematicParameters = new System.Windows.Forms.GroupBox();
            this.OmegaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.animatedButton1 = new Theoretical_Mechanics_Motion_MVP.AnimatedButton();
            this.StopButton = new Theoretical_Mechanics_Motion_MVP.AnimatedButton();
            this.StartButton = new Theoretical_Mechanics_Motion_MVP.AnimatedButton();
            this.ClearButton = new Theoretical_Mechanics_Motion_MVP.AnimatedButton();
            this.DrawButton = new Theoretical_Mechanics_Motion_MVP.AnimatedButton();
            this.panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigRadiusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallRaduisNumericUpDown)).BeginInit();
            this.groupBoxCinematicParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OmegaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.animatedButton1);
            this.panel.Controls.Add(this.StopButton);
            this.panel.Controls.Add(this.StartButton);
            this.panel.Controls.Add(this.ClearButton);
            this.panel.Controls.Add(this.DrawButton);
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.groupBoxCinematicParameters);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(262, 949);
            this.panel.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.PointBCheckBox);
            this.groupBox2.Controls.Add(this.PointACheckBox);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBox2.Location = new System.Drawing.Point(31, 770);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "траектория";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(32)))), ((int)(((byte)(122)))));
            this.pictureBox2.Location = new System.Drawing.Point(127, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 27);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(187)))), ((int)(((byte)(12)))));
            this.pictureBox1.Location = new System.Drawing.Point(127, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 27);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PointBCheckBox
            // 
            this.PointBCheckBox.AutoSize = true;
            this.PointBCheckBox.Location = new System.Drawing.Point(14, 95);
            this.PointBCheckBox.Name = "PointBCheckBox";
            this.PointBCheckBox.Size = new System.Drawing.Size(109, 19);
            this.PointBCheckBox.TabIndex = 5;
            this.PointBCheckBox.Text = "точка В:";
            this.PointBCheckBox.UseVisualStyleBackColor = true;
            this.PointBCheckBox.CheckedChanged += new System.EventHandler(this.TrajectoryChanged);
            // 
            // PointACheckBox
            // 
            this.PointACheckBox.AutoSize = true;
            this.PointACheckBox.Location = new System.Drawing.Point(14, 43);
            this.PointACheckBox.Name = "PointACheckBox";
            this.PointACheckBox.Size = new System.Drawing.Size(109, 19);
            this.PointACheckBox.TabIndex = 4;
            this.PointACheckBox.Text = "точка А:";
            this.PointACheckBox.UseVisualStyleBackColor = true;
            this.PointACheckBox.CheckedChanged += new System.EventHandler(this.TrajectoryChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BigRadiusNumericUpDown);
            this.groupBox1.Controls.Add(this.SmallRaduisNumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBox1.Location = new System.Drawing.Point(26, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 207);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "геометрические";
            // 
            // BigRadiusNumericUpDown
            // 
            this.BigRadiusNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BigRadiusNumericUpDown.Location = new System.Drawing.Point(19, 153);
            this.BigRadiusNumericUpDown.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.BigRadiusNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BigRadiusNumericUpDown.Name = "BigRadiusNumericUpDown";
            this.BigRadiusNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.BigRadiusNumericUpDown.TabIndex = 3;
            this.BigRadiusNumericUpDown.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.BigRadiusNumericUpDown.ValueChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // SmallRaduisNumericUpDown
            // 
            this.SmallRaduisNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SmallRaduisNumericUpDown.Location = new System.Drawing.Point(19, 74);
            this.SmallRaduisNumericUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SmallRaduisNumericUpDown.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.SmallRaduisNumericUpDown.Name = "SmallRaduisNumericUpDown";
            this.SmallRaduisNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.SmallRaduisNumericUpDown.TabIndex = 2;
            this.SmallRaduisNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.SmallRaduisNumericUpDown.ValueChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "радиус r2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "радиус R2:";
            // 
            // groupBoxCinematicParameters
            // 
            this.groupBoxCinematicParameters.Controls.Add(this.OmegaNumericUpDown);
            this.groupBoxCinematicParameters.Controls.Add(this.label1);
            this.groupBoxCinematicParameters.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCinematicParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupBoxCinematicParameters.Location = new System.Drawing.Point(26, 315);
            this.groupBoxCinematicParameters.Name = "groupBoxCinematicParameters";
            this.groupBoxCinematicParameters.Size = new System.Drawing.Size(206, 125);
            this.groupBoxCinematicParameters.TabIndex = 5;
            this.groupBoxCinematicParameters.TabStop = false;
            this.groupBoxCinematicParameters.Text = "кинематические";
            // 
            // OmegaNumericUpDown
            // 
            this.OmegaNumericUpDown.DecimalPlaces = 2;
            this.OmegaNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.OmegaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.OmegaNumericUpDown.Location = new System.Drawing.Point(20, 67);
            this.OmegaNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.OmegaNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.OmegaNumericUpDown.Name = "OmegaNumericUpDown";
            this.OmegaNumericUpDown.Size = new System.Drawing.Size(124, 22);
            this.OmegaNumericUpDown.TabIndex = 1;
            this.OmegaNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            131072});
            this.OmegaNumericUpDown.ValueChanged += new System.EventHandler(this.ParameterValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "угловая скорость:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(30, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "ПАРАМЕТРЫ:";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(379, 107);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(298, 201);
            this.pictureBoxMain.TabIndex = 1;
            this.pictureBoxMain.TabStop = false;
            // 
            // animatedButton1
            // 
            this.animatedButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.animatedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animatedButton1.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.animatedButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.animatedButton1.Image = global::Theoretical_Mechanics_Motion_MVP.Properties.Resources.submitB;
            this.animatedButton1.Location = new System.Drawing.Point(29, 681);
            this.animatedButton1.Name = "animatedButton1";
            this.animatedButton1.Size = new System.Drawing.Size(190, 45);
            this.animatedButton1.TabIndex = 3;
            this.animatedButton1.UseVisualStyleBackColor = false;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Image = global::Theoretical_Mechanics_Motion_MVP.Properties.Resources.pauseB;
            this.StopButton.Location = new System.Drawing.Point(30, 184);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(190, 43);
            this.StopButton.TabIndex = 14;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Image = global::Theoretical_Mechanics_Motion_MVP.Properties.Resources.playB;
            this.StartButton.Location = new System.Drawing.Point(30, 132);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(190, 43);
            this.StartButton.TabIndex = 13;
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Image = global::Theoretical_Mechanics_Motion_MVP.Properties.Resources.eraseB;
            this.ClearButton.Location = new System.Drawing.Point(30, 77);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(190, 43);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawButton.Image = global::Theoretical_Mechanics_Motion_MVP.Properties.Resources.drawB;
            this.DrawButton.Location = new System.Drawing.Point(30, 22);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(190, 43);
            this.DrawButton.TabIndex = 3;
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 949);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Теоретическая механика";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigRadiusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallRaduisNumericUpDown)).EndInit();
            this.groupBoxCinematicParameters.ResumeLayout(false);
            this.groupBoxCinematicParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OmegaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCinematicParameters;
        private System.Windows.Forms.NumericUpDown OmegaNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown BigRadiusNumericUpDown;
        private System.Windows.Forms.NumericUpDown SmallRaduisNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox PointBCheckBox;
        private System.Windows.Forms.CheckBox PointACheckBox;
        private AnimatedButton DrawButton;
        private AnimatedButton StopButton;
        private AnimatedButton StartButton;
        private AnimatedButton ClearButton;
        private AnimatedButton animatedButton1;
    }
}

