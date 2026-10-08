
namespace Pr3
{
    public partial class Form1 : Form
    {
        static User vasya = new User("vasya", "123", "user");
        static User oleg = new User("oleg", "789", "admin");
        static User galya = new User("galya", "123", "manager");
        static User guest = new User("guest", "guest", "guest");
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenForm2(User user)
        {
            Form2 form2 = new Form2(user);
            form2.Show();
            this.Hide();
        }
        private void ToEnter()
        {  
            wrongL.Text = " ";
            foreach (var user in User.usersList)
            {
                if (loginTB.Text == user.login && pswdTB.Text == user.pswd)
                {
                    OpenForm2(user);
                    return;
                }
            }
                wrongL.Text = "Неверный логин или пароль";
        }
        private void ToReg()
        {
            wrongL.Text = " ";
            new User(loginTB.Text, pswdTB.Text, "user");
        }
        private void enterBut_Click(object sender, EventArgs e)
        {
            if (enterBut.Text == "Зарегистрироваться") ToReg();
            else if (enterBut.Text == "Войти") ToEnter();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenForm2(guest);
        }

        private async void lookPswdL_Click(object sender, EventArgs e)
        {
            pswdTB.PasswordChar = '\0';
            await System.Threading.Tasks.Task.Delay(500);
            pswdTB.PasswordChar = '*';
        }

        private void regL_Click(object sender, EventArgs e)
        {
            this.Text = "Регистрация";
            enterBut.Text = "Зарегистрироваться";
        }

        private void enterL_Click(object sender, EventArgs e)
        {
            this.Text = "Войти";
            enterBut.Text = "Войти";
        }
    }
}
