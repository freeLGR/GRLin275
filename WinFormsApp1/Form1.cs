namespace WinFormsApp1
{
    public partial class sub : Form
    {
        public sub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Number11 = Number1.Text;
            double num1=double.Parse(Number11);
            string Number22=Number2.Text;
            double num2=double.Parse(Number22);
            if (add.Checked)
            {
                double answer;
                answer = num1 + num2;
                result.Text = "运算结果是" + answer;
            }
            if (sub2.Checked)
            {
                double answer;
                answer = num1 - num2;
                result.Text = "运算结果是" + answer;
            }
            if (multiply.Checked)
            {
                double answer;
                answer = num1 * num2;
                result.Text = "运算结果是" + answer;
            }
            if (div.Checked)
            {
                double answer;
                answer = num1 /num2;
                result.Text = "运算结果是" + answer;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 第一个数_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sub_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}