using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KeyboardTrainer
{
    public partial class Form1 : Form
    {
        public string UserName = "";
        private SQLiteConnection sqliteConnection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            this.KeyPreview = true;
            this.Resize += new EventHandler(Form1_Resize);
            Center();

            panelUserInput.Visible = true;
            panelTraining.Visible = false;
            panelTraining.Controls.Add(keyboard1);

            this.KeyPreview = true;  // Перехват нажатий клавиш на уровне формы
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Делегируем нажатие клавиш компоненту Keyboard
            keyboard1.OnKeyDown(sender, e);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // Делегируем отпускание клавиш компоненту Keyboard
            keyboard1.OnKeyUp(sender, e);
        }

        private void InitializeDatabase()
        {
            string dbPath = "trainer_results.db";

            // Проверяем, существует ли база данных
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            // Подключаемся к базе данных
            sqliteConnection = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            sqliteConnection.Open();

            // Создаем таблицу для хранения результатов тренировок, если её нет
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS TrainingResults (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Speed INTEGER,
                                        Accuracy REAL,
                                        TimeInSeconds REAL,
                                        Date DATETIME)";

            using (SQLiteCommand command = new SQLiteCommand(createTableQuery, sqliteConnection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void Center()
        {
            int x = (this.ClientSize.Width - title.Width) / 2;
            int namelblX = (this.ClientSize.Width - inputNamelbl.Width) / 2;
            int usernameX = (this.ClientSize.Width - username.Width) / 2;
            int loginbutton = (this.ClientSize.Width - login.Width) / 2;
            int y = 20;
            title.Location = new Point(x, y);
            inputNamelbl.Location = new Point(namelblX, 77);
            username.Location = new Point(usernameX, 134);
            login.Location = new Point(loginbutton, 182);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Center();
        }

        private void login_Click(object sender, EventArgs e)
        {
            // Проверка, что имя введено
            if (string.IsNullOrWhiteSpace(username.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя.");
                return;
            }

            UserName = username.Text;
            label2.Text = UserName;
            // Скрываем панель ввода имени
            panelUserInput.Visible = false;

            // Отображаем панель тренировки
            panelTraining.Visible = true;
            panelTraining.BringToFront();
        }


    }
}
