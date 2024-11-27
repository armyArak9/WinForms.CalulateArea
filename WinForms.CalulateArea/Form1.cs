namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("ยินดีต้อนรับผู้ใช้งาน", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("ต้องการปิดจริงหรือไม่", "แน่ใจนะ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {

            //input รับค่าจาก txtRadius
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRedius.Text);
            if (double.TryParse(txtRedius.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกไม่ถูกต้อง", "Error");
                txtRedius.Focus(); //ให้มี Cursor ที่ texbox
                txtRedius.SelectAll(); //ให้มี Selecte ข้อความใน Textbox
                return;
            }

            //process คำนวณพื้นที่ สูตร pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ให้ค่า Pi
            //Math.Pow(x,y) x ยกกำลัง y

            //output นำไปแสดงผลที่ lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRedius.Focus();
            txtRedius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าความสูง
            if (double.TryParse(txtHeight.Text, out double Height) == false)
            {
                MessageBox.Show("กรอกความสูงไม่ถูกต้อง", "Error");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            // ตรวจสอบค่าฐาน
            if (double.TryParse(txtWidth.Text, out double Base) == false)
            {
                MessageBox.Show("กรอกค่าฐานไม่ถูกต้อง", "Error");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            // คำนวณพื้นที่สามเหลี่ยม (สูตร: 0.5 * ฐาน * ความสูง)
            double TriangleArea = 0.5 * Base * Height;

            // แสดงผลลัพธ์ใน lblResult
            lblResult.Text = TriangleArea.ToString("0.00");

            // ตั้งค่าโฟกัสให้กับ txtHeight
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {

            // ตรวจสอบค่าความยาวด้าน
            if (double.TryParse(txtHexagonWidth.Text, out double Width) == false)
            {
                MessageBox.Show("กรอกค่าความยาวด้านไม่ถูกต้อง", "Error");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // คำนวณพื้นที่รูปหกเหลี่ยมด้านเท่า
            double HexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Width, 2);

            // แสดงผลลัพธ์ใน lblResult
            lblResult.Text = HexagonArea.ToString("0.00");

            // ตั้งค่าโฟกัสให้กับ txtHexagonWidth
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }
    }
}
