
namespace Pr3
{
    public partial class Form2 : Form
    {
        public Form2(User user)
        {
            InitializeComponent();
            List<string> positions = new List<string>
            {
                "Клавиатура",
                "Мышь",
                "Монитор",
                "Наушники",
                "Блок питания",
                "Видеокарта",
                "Графический планшет",
                "Материнская плата",
                "Удлинитель",
                "Процессор",
            };

            listBox.Items.AddRange(positions.ToArray());
            switch (user.role)
            {
                case "user":
                    roleL.Text = "Пользователь";
                    newPosL.Visible = false;
                    addPosTB.Visible = false;
                    addBut.Visible = false;
                    deleteBut.Visible = false;
                    deleteAllBut.Visible = false;
                    break;
                case "admin":
                    roleL.Text = "Админ";
                    break;
                case "manager":
                    roleL.Text = "Менеджер";
                    deleteBut.Visible = false;
                    deleteAllBut.Visible = false;
                    break;
                case "guest":
                    roleL.Text = "Гость";
                    sortBut.Visible = false;
                    newPosL.Visible = false;
                    addPosTB.Visible = false;
                    addBut.Visible = false;
                    deleteBut.Visible = false;
                    deleteAllBut.Visible = false;
                    break;
                default:
                    roleL.Text = "undefined";
                    sortBut.Visible = false;
                    newPosL.Visible = false;
                    addPosTB.Visible = false;
                    addBut.Visible = false;
                    deleteBut.Visible = false;
                    deleteAllBut.Visible = false;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sortBut_Click(object sender, EventArgs e)
        {
            listBox.Sorted = true;
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if (addPosTB.Text != "") listBox.Items.Add(addPosTB.Text);
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
            
        }

        private void deleteAllBut_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
         
        private void label2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
