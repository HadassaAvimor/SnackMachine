namespace SnackMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void snackBtn_Click(object sender, EventArgs e)
        {
            title.Text = "�� ������� ������� ���� ����� ���� ����";
            Controls.Remove(coldDrinkBtn);
            Controls.Remove(hotDrinkBtn);
            Controls.Remove(snackBtn);

        }
    }
}