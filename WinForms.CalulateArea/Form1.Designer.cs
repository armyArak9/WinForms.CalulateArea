namespace WinForms.CalulateArea
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
            groupBox1 = new GroupBox();
            btnCircleArea = new Button();
            txtRedius = new TextBox();
            groupBox2 = new GroupBox();
            btnTriangleArea = new Button();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            groupBox3 = new GroupBox();
            btnHexagonArea = new Button();
            txtHexagonWidth = new TextBox();
            lblResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSalmon;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRedius);
            groupBox1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(397, 41);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(206, 51);
            btnCircleArea.TabIndex = 1;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRedius
            // 
            txtRedius.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRedius.Location = new Point(156, 41);
            txtRedius.Multiline = true;
            txtRedius.Name = "txtRedius";
            txtRedius.Size = new Size(163, 51);
            txtRedius.TabIndex = 0;
            txtRedius.Text = "1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 255, 128);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(29, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(652, 173);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTriangleArea.Location = new Point(397, 49);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(206, 51);
            btnTriangleArea.TabIndex = 2;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWidth.Location = new Point(156, 105);
            txtWidth.Multiline = true;
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(163, 47);
            txtWidth.TabIndex = 2;
            txtWidth.Text = "1";
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(156, 33);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(163, 47);
            txtHeight.TabIndex = 1;
            txtHeight.Text = "1";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 128, 255);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(29, 403);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(652, 151);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHexagonArea.Location = new Point(397, 60);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(231, 51);
            btnHexagonArea.TabIndex = 3;
            btnHexagonArea.Text = "คำนวณพื้นที่รูปหกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHexagonWidth.Location = new Point(156, 58);
            txtHexagonWidth.Multiline = true;
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(163, 51);
            txtHexagonWidth.TabIndex = 3;
            txtHexagonWidth.Text = "1";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(128, 255, 255);
            lblResult.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(743, 166);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(320, 256);
            lblResult.TabIndex = 2;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 51);
            label1.Name = "label1";
            label1.Size = new Size(43, 28);
            label1.TabIndex = 2;
            label1.Text = "รัสมี";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 49);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 3;
            label2.Text = "ความสูง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 115);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 4;
            label3.Text = "ความยาวฐาน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 71);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 5;
            label4.Text = "ความยาวด้าน";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(816, 129);
            label5.Name = "label5";
            label5.Size = new Size(151, 28);
            label5.TabIndex = 6;
            label5.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 575);
            Controls.Add(label5);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblResult;
        private Button btnCircleArea;
        private TextBox txtRedius;
        private Button btnTriangleArea;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Button btnHexagonArea;
        private TextBox txtHexagonWidth;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
