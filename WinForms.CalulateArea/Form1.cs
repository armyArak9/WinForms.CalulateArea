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

            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("��ͧ��ûԴ��ԧ�������", "��㨹�", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {

            //input �Ѻ��Ҩҡ txtRadius
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRedius.Text);
            if (double.TryParse(txtRedius.Text, out Radius) == false)
            {
                MessageBox.Show("��͡���١��ͧ", "Error");
                txtRedius.Focus(); //����� Cursor ��� texbox
                txtRedius.SelectAll(); //����� Selecte ��ͤ���� Textbox
                return;
            }

            //process �ӹǳ��鹷�� �ٵ� pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ����� Pi
            //Math.Pow(x,y) x ¡���ѧ y

            //output ����ʴ��ŷ�� lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRedius.Focus();
            txtRedius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            // ��Ǩ�ͺ��Ҥ����٧
            if (double.TryParse(txtHeight.Text, out double Height) == false)
            {
                MessageBox.Show("��͡�����٧���١��ͧ", "Error");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            // ��Ǩ�ͺ��Ұҹ
            if (double.TryParse(txtWidth.Text, out double Base) == false)
            {
                MessageBox.Show("��͡��Ұҹ���١��ͧ", "Error");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            // �ӹǳ��鹷������������ (�ٵ�: 0.5 * �ҹ * �����٧)
            double TriangleArea = 0.5 * Base * Height;

            // �ʴ����Ѿ��� lblResult
            lblResult.Text = TriangleArea.ToString("0.00");

            // ��駤��⿡�����Ѻ txtHeight
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {

            // ��Ǩ�ͺ��Ҥ�����Ǵ�ҹ
            if (double.TryParse(txtHexagonWidth.Text, out double Width) == false)
            {
                MessageBox.Show("��͡��Ҥ�����Ǵ�ҹ���١��ͧ", "Error");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            // �ӹǳ��鹷���ٻˡ���������ҹ���
            double HexagonArea = (3 * Math.Sqrt(3) / 2) * Math.Pow(Width, 2);

            // �ʴ����Ѿ��� lblResult
            lblResult.Text = HexagonArea.ToString("0.00");

            // ��駤��⿡�����Ѻ txtHexagonWidth
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }
    }
}
