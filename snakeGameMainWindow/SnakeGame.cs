using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using snakeControl;
using System.Data.SqlClient;

namespace snakeGameMainWindow
{
    public partial class SnakeGame : Form
    {
        private FileManager file;
        private List<string> defaultSettings;
        private Timer t1;
        private string pathDatabase = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Desktop\Projekty\snakeGameCsharp\snakeGameMainWindow\snakeDatabase.mdf;Integrated Security=True";

        private SqlConnection myConn;
        private SqlCommand addPlayer;
        private SqlCommand addScore;
        private SqlCommand selectPlayerId;
        private SqlCommand playerExisted;
        private DateTime date1;
        public SnakeGame()
        {
            InitializeComponent();
        }
        private void SnakeGame_Load(object sender, EventArgs e)
        {
            file = new FileManager();
            file.readFile();
            defaultSettings = file.list;
            this.Width = Convert.ToInt32(defaultSettings[0]);
            this.Height = Convert.ToInt32(defaultSettings[1]);
            snakeControl1.timer1.Stop();
            snakeControl1.Hide();
            mainMenuButton.Hide();
            resolutionBox.Items.Add("800x600");
            resolutionBox.Items.Add("1024x768");
            resolutionBox.Items.Add("1280x720");
            resolutionBox.Items.Add("1920x1080");
            speedBox.Items.Add("1x");
            speedBox.Items.Add("2x");
            speedBox.Items.Add("5x");
            if (this.Width == 800)
                resolutionBox.SelectedIndex = 0;
            else if (this.Width == 1024)
                resolutionBox.SelectedIndex = 1;
            else if (this.Width == 1280)
                resolutionBox.SelectedIndex = 2;
            else
                resolutionBox.SelectedIndex = 3;
            if (Convert.ToInt32(defaultSettings[2]) == 1)
                speedBox.SelectedIndex = 0;
            else if (Convert.ToInt32(defaultSettings[2]) == 2)
                speedBox.SelectedIndex = 1;
            else
                speedBox.SelectedIndex = 2;

            if (Convert.ToBoolean(defaultSettings[4]))
                wallBox.Checked = true;
            else
                wallBox.Checked = false;
            if (defaultSettings[3] == "Blue")
                radioButtonBlue.Checked = true;
            else if (defaultSettings[3] == "White")
                radioButtonWhite.Checked = true;
            else
                radioButtonGreen.Checked = true;
            pictureBoxBlue.BackColor = Color.FromArgb(255, Color.Blue);
            pictureBoxGreen.BackColor = Color.FromArgb(255, Color.Green);
            pictureBoxWhite.BackColor = Color.FromArgb(255, Color.White);
            t1 = new Timer();
            t1.Interval = 1;
            t1.Tick += new EventHandler(scoreUpdate);
            t1.Tick += new EventHandler(GameOver);
            t1.Enabled = true;
        }
        private void saveSettings()
        {
            string resolutionText = resolutionBox.SelectedItem.ToString();
            string[] resolution = resolutionText.Split('x');
            this.Width = Convert.ToInt32(resolution[0]);
            this.Height = Convert.ToInt32(resolution[1]);
            string speedText = speedBox.SelectedItem.ToString();
            string[] speedSplit = speedText.Split('x');
            string color;
            bool wall = false;
            int speed = Convert.ToInt32(speedSplit[0]);
            if (radioButtonBlue.Checked)
            {
                color = "Blue";
            }
            else if (radioButtonWhite.Checked)
            {
                color = "White";
            }
            else
            {
                color = "Green";
            }
            if (wallBox.Checked)
            {
                wall = true;
            }

            file.saveFile(Convert.ToInt32(resolution[0]), Convert.ToInt32(resolution[1]), speed, color, wall);


        }
        private void startGameButton_Click(object sender, EventArgs e)
        {

            snakeControl1.Width = this.Width - 60;
            snakeControl1.Height = this.Height - 95;
            snakeControl1.timer1.Start();
            startGameButton.Hide();
            topResultButton.Hide();
            optionsMenuButton.Hide();
            startGameButton.Hide();
            exitButton.Hide();
            snakeControl1.Show();
            scoreLabel.Show();
            if (!(startGameButton.Text == "Resume Game") || snakeControl1.gameOver)
            {

                snakeControl1.refresh(defaultSettings);

            }

            newGameButton.Hide();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            if (!(UsernameText.Text == "Insert Your NickName.."))
            {
                myConn = new SqlConnection(pathDatabase);
                addUserToDatabase(myConn);
                UsernameText.Text = "Insert Your NickName..";
            }
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            mainMenuClick();
        }
        public void mainMenuClick()
        {
            if (snakeControl1.gameOver)
            {

                PanelGameOver.Hide();
                
                t1.Start();
                snakeControl1.gameOver = false;
                exitButton.Hide();
                mainMenuButton.Hide();
                playerTopButton.Hide();
                
                startGameButton.Text = "START GAME";

                if (!(UsernameText.Text == "Insert Your NickName.."))
                {
                    myConn = new SqlConnection(pathDatabase);
                    addUserToDatabase(myConn);
                    UsernameText.Text = "Insert Your NickName..";
                }
                


            }
            exitButton.Location = new Point(topResultButton.Location.X, topResultButton.Location.Y + 92);
            mainMenuButton.Location = new Point(saveOptions.Location.X, saveOptions.Location.Y - 92);
            gridLabel.Hide();
            dataGridView1.Hide();
            startGameButton.Show();
            topResultButton.Show();

            optionsMenuButton.Show();
            exitButton.Show();
            snakeControl1.timer1.Stop();
            snakeControl1.Hide();

            mainMenuButton.Hide();
            saveOptions.Hide();
            resolutionLabel.Hide();
            resolutionBox.Hide();
            speedBox.Hide();
            speedLabel.Hide();
            wallBox.Hide();
            pictureBoxGreen.Hide();
            radioButtonGreen.Hide();
            pictureBoxBlue.Hide();
            radioButtonBlue.Hide();
            radioButtonWhite.Hide();
            pictureBoxWhite.Hide();
            BoardLabel.Hide();
            scoreLabel.Hide();
            if (startGameButton.Text == "Resume Game")
            {
                newGameButton.Show();
            }




        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //problem with priority of key down solved by this
        {

            if (keyData == Keys.Escape)
            {
                startGameButton.Text = "Resume Game";
                newGameButton.Show();
                mainMenuClick();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);

            }
        }

        private void SnakeGame_SizeChanged(object sender, EventArgs e)
        {
            startGameButton.Width = this.Width / 5;
            exitButton.Width = this.Width / 5;
            topResultButton.Width = this.Width / 5;
            optionsMenuButton.Width = this.Width / 5;

            mainMenuButton.Width = this.Width / 5;
            saveOptions.Width = this.Width / 5;
            resolutionLabel.Width = this.Width / 5;
            resolutionBox.Width = this.Width / 5;
            speedBox.Width = this.Width / 5;
            speedLabel.Width = this.Width / 5;
            wallBox.Width = this.Width / 5;
            saveOptions.Width = this.Width / 5;
            radioButtonGreen.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width)));
            pictureBoxGreen.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width))) + 35;
            radioButtonBlue.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width))) + 100;
            pictureBoxBlue.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width))) + 135;
            radioButtonWhite.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width))) + 200;
            pictureBoxWhite.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width))) + 235;
            BoardLabel.Left = this.Width / 2 + (Convert.ToInt32(Math.Round(0.15 * this.Width))) + 100;
            scoreLabel.Location = new Point(20, 10);
            

        }
        private void scoreUpdate(object sender, EventArgs e)
        {

            scoreLabel.Text = "Score:" + Convert.ToString(snakeControl1.score);
        }

        private void optionsMenuButton_Click(object sender, EventArgs e)
        {
            startGameButton.Hide();
            topResultButton.Hide();
            optionsMenuButton.Hide();
            exitButton.Hide();
            mainMenuButton.Show();
            saveOptions.Show();
            resolutionLabel.Show();
            resolutionBox.Show();
            speedBox.Show();
            speedLabel.Show();
            wallBox.Show();
            saveOptions.Show();
            pictureBoxGreen.Show();
            radioButtonGreen.Show();
            pictureBoxBlue.Show();
            radioButtonBlue.Show();
            radioButtonWhite.Show();
            pictureBoxWhite.Show();
            BoardLabel.Show();
            newGameButton.Hide();
        }

        private void saveOptions_Click(object sender, EventArgs e)
        {
            saveSettings();
            string message = "Changes have been saved and will be visible in the new game";
            string caption = "INFO about saving settings";

            DialogResult result = MessageBox.Show(message, caption,
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation);

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            file = new FileManager();
            file.readFile();
            defaultSettings = file.list;
            snakeControl1.refresh(defaultSettings);
            snakeControl1.Width = this.Width - 60;
            snakeControl1.Height = this.Height - 95;
            snakeControl1.timer1.Start();
            startGameButton.Hide();
            topResultButton.Hide();
            optionsMenuButton.Hide();
            startGameButton.Hide();
            exitButton.Hide();
            newGameButton.Hide();
            snakeControl1.Show();
            snakeControl1.score = 0;
            scoreLabel.Show();
        }
        private void GameOver(object sender, EventArgs e)
        {
            if (snakeControl1.gameOver)
            {
                PanelGameOver.Show();
                PanelGameOver.Refresh();
                t1.Stop();
            }
        }

        private void PanelGameOver_Paint(object sender, PaintEventArgs e)
        {
            PanelGameOver.Width = this.Width;
            PanelGameOver.Height = this.Height;
            String StringOver = "GAME OVER";

            Font drawFont = new Font("Algerian", 40);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            StringFormat drawFormat = new StringFormat();
            PanelGameOver.BackColor = Color.FromArgb(125, Color.Red);
            Font ScoreFont = new Font("Algerian", 30);
            e.Graphics.DrawString(StringOver, drawFont, drawBrush, this.Width / 2, this.Height / 8, drawFormat);
            e.Graphics.DrawString(scoreLabel.Text, ScoreFont, drawBrush, this.Width / 2, this.Height / 4, drawFormat);
            UsernameLabel.Left = this.Width / 2;
            UsernameLabel.Height = this.Height / 3;
            UsernameText.Left = this.Width / 2;
            UsernameText.Height = this.Height / 2;
            mainMenuButton.Location = new Point(this.Width / 2, this.Height / 2 + 50);
            exitButton.Location = new Point(this.Width / 2, this.Height / 2 + 150);
            playerTopButton.Location = new Point(this.Width / 2 + this.Width / 4, this.Height / 2 + 50);
            exitButton.Show();
            mainMenuButton.Show();
            playerTopButton.Show();
            scoreLabel.Hide();
        }
        private void playerTopButton_Click(object sender, EventArgs e)
        {
            if (UsernameText.Text == "Insert Your NickName..")
            {
                MessageBox.Show("to see your result and save this score, enter your login", "Insert username problem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                myConn = new SqlConnection(pathDatabase);
                addUserToDatabase(myConn);
                showPlayerStats(myConn);
                UsernameText.Text = "Insert Your NickName..";
            }
       ;


        }

        private void addUserToDatabase(SqlConnection myConn)
        {
           
            try
            {
                myConn.Open();
                date1 = DateTime.Now;
               
               
                if (!usernameExisted(myConn, UsernameText.Text))
                { 
                addPlayer = new SqlCommand("INSERT INTO Players(username,dateCreation) VALUES (@a1,@a2)", myConn);
                addPlayer.Parameters.AddWithValue("a1", UsernameText.Text);
                
                addPlayer.Parameters.AddWithValue("a2", date1);
                addPlayer.ExecuteNonQuery();
                }
                addScore = new SqlCommand("INSERT INTO Results(score,PlayerId,date) VALUES (@a1,@a2,@a3)", myConn);
                addScore.Parameters.AddWithValue("a1", snakeControl1.score);
                addScore.Parameters.AddWithValue("a2", getIdByUsername(myConn, UsernameText.Text));
                addScore.Parameters.AddWithValue("a3", date1);
                addScore.ExecuteNonQuery();
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SnakeGame ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private int getIdByUsername(SqlConnection myConn, string username)
        {
            selectPlayerId = new SqlCommand("Select id from Players where username=@a1", myConn);
            selectPlayerId.Parameters.AddWithValue("a1", username);
            int result = (int)(selectPlayerId.ExecuteScalar());
            return result;
        }
        private bool usernameExisted(SqlConnection myConn, string username)
        {
            playerExisted = new SqlCommand("Select id from Players where username=@a1", myConn);
            playerExisted.Parameters.AddWithValue("a1", username);
            using (SqlDataReader reader = playerExisted.ExecuteReader())
            {
                if (reader.Read())
                {
                    return true;
                }
            }
            return false;
        }
        private void showPlayerStats(SqlConnection myConn)
        {
            try
            {
                myConn.Open();
                string query = "SELECT score AS SCORE,date AS DATE FROM Results WHERE PlayerId=" + Convert.ToString(getIdByUsername(myConn, UsernameText.Text)+
                    "ORDER BY Score DESC");
                SqlDataAdapter SDA = new SqlDataAdapter(query, myConn);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Location= new Point(this.Width / 2, this.Height/8);
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Width =
                dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + this.Width/8;
                PanelGameOver.Hide();
                snakeControl1.Hide();
                playerTopButton.Hide();
                
                gridLabel.Location=new Point(this.Width / 2, this.Height / 12);
                gridLabel.Text = UsernameText.Text + " Restults History:";
                gridLabel.Show();
                
                dataGridView1.Show();

            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SnakeGame ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void topResultButton_Click(object sender, EventArgs e)
        {
            myConn = new SqlConnection(pathDatabase);
            try
            {
                myConn.Open();
                string query = "SELECT p.username as NICK,s.Score AS SCORE,s.date AS DATE FROM Results s " +
                "INNER JOIN Players p ON p.Id =s.PlayerId ORDER by s.Score DESC";
                
                
                SqlDataAdapter SDA = new SqlDataAdapter(query, myConn);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                List<DataTable> tables = new List<DataTable>();
                int i = 0;
                int j = 1;
                DataTable newDt = dt.Clone();
                newDt.Clear();

                foreach (DataRow row in dt.Rows)
                {

                    if (i < 10)
                    {
                        DataRow newRow = newDt.NewRow();
                        newRow.ItemArray = row.ItemArray;
                        newDt.Rows.Add(newRow);

                    }
                    i++;
                }

                    dataGridView1.DataSource = newDt;
                dataGridView1.Location = new Point(this.Width / 2-70, this.Height / 8);
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Width =
                dataGridView1.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                + (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0) + this.Width / 8;
                PanelGameOver.Hide();
                snakeControl1.Hide();
                playerTopButton.Hide();
                dataGridView1.Font = new Font(gridLabel.Font.Name, 10.0F);
                gridLabel.Location = new Point(this.Width / 2-70, this.Height / 12);
                gridLabel.Text = " Restults History:";
                gridLabel.Show();
                mainMenuButton.Location = new Point(this.Width / 2+100, this.Height / 2 + 50);
                exitButton.Location = new Point(this.Width / 2+100, this.Height / 2 + 150);
                mainMenuButton.Show();
                dataGridView1.Show();
                topResultButton.Hide();
                optionsMenuButton.Hide();
                newGameButton.Hide();
                startGameButton.Hide();

            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "SnakeGame ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
