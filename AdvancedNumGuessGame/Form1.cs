namespace AdvancedNumGuessGame
{
    public partial class Form1 : Form
    {
        private string version = "V1.0 BETA";
        public Form1()
        {
            InitializeComponent();
            this.Text = this.Text +" "+version;
        }
        
        System.Windows.Forms.Timer gameTime = new System.Windows.Forms.Timer(); //Game Time
        TextBox historyBox = new TextBox(); //Game History TextBox
        private int second, numberToGuess = 1, estimatedNum, score;
        Random rnd = new Random(); //for number to guess
        private int min, max, durationSec, wrongGuess, rightGuess;
        //number to guess random min and max. wrongGuess: Number of seconds to decrase on wrong guess, rightGuess: Number of seconds to increase on right guess

        private void Form1_Load(object sender, EventArgs e) 
        {
            try {
                this.Size = new Size(419, 156);
                reloadSavedData();
                historyBox.Enabled = false;
                gameTime.Interval = 1000;
                gameTime.Tick += GameTime_Tick;
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "Application load error!");
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {   //Makes the necessary preparations to start the game.
            try {
                if (nameBox.Text == "") { reloadSavedData(); } //If there is no Player Name, the saved Player Name is loaded.
                this.BackColor = Color.Peru;
                hint.Text = "Guess a number";
                score = 0;
                scoreInfo.Text = "Your Score: " + score + " Difficulty: " + difficultyBox.Text;
                second = durationSec;
                createNewNumber();
                inGamePanel.Enabled = true;
                this.Size = new Size(419, 438);
                gameTime.Start(); //The time of the game starts.
                setPanel.Enabled = false; //The settings panel at the top is disabled.
            }catch (Exception ex) {
                emrekiBugLogger(ex, "Game can't start!");
            }
        }

        private int createNewNumber()
        {   //A random new number to be guessed is determined.
            try {
                numberToGuess = rnd.Next(min, max + 1);
            }catch(Exception ex) {
                emrekiBugLogger(ex, "Can't create new random number!");
            }
            return numberToGuess;
        }

        private void GameTime_Tick(object? sender, EventArgs e) {
            try {
                timeInfo.Text = "Time remaining: " + second-- + " Second";
                if (second == 0) {
                    timeEnd();
                }
            }
            catch (Exception ex) {
                emrekiBugLogger(ex, "Game Time Error!");
            }
        }

        //When the time is up etc. Used to end the game.
        private void timeEnd(bool saveResult = true)  {
            try {
                gameTime.Stop();
                guessBox.Clear();
                this.BackColor = Color.Maroon;
                inGamePanel.Enabled = false;
                setPanel.Enabled = true; //settings panel is enabled
                hint.Text = "Time's up! Game over!\nDifficulty: " + difficultyBox.Text + ", Your Score: " + score;
                startBtn.Text = "Play again";
                timeInfo.Text = "Time remaining: 0 Second";
                if (saveResult == true)
                {   //Time played, player name, game difficulty and score are recorded in the game history.
                    string gh = DateTime.Now + " Player Name: " + nameBox.Text + " Difficulty: " + difficultyBox.Text + " Score: " + score;
                    Properties.Settings.Default.gameHistroy.Add(gh);
                    Properties.Settings.Default.Save();
                }
            }catch(Exception ex) {
                emrekiBugLogger(ex, "timeEnd error");
            }
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {   //check your number guess button
            try {
                if (guessBox.Text != "") { estimatedNum = Convert.ToInt32(guessBox.Text); } else { guessBox.Focus(); hint.Text = "Guess a number"; } //If there is no guess, it is asked to guess.
                this.BackColor = Color.Peru;
                if (estimatedNum > numberToGuess)
                {
                    hint.Text = "Try smaller numbers.";
                    second -= wrongGuess; //The remaining time as a penalty for incorrect guessing is reduced.
                }
                else if (estimatedNum < numberToGuess)
                {
                    hint.Text = "Try larger numbers.";
                    second -= wrongGuess; //The remaining time as a penalty for incorrect guessing is reduced.
                }
                else if (estimatedNum == numberToGuess)
                {
                    scoreInfo.Text = "Your Score: " + ++score + " Difficulty: " + difficultyBox.Text;
                    hint.Text = "You found the right number! Now guess the next number.";
                    second += rightGuess;
                    createNewNumber(); //The new number to be guessed is determined.
                    this.BackColor = Color.DarkGreen;
                }
                if (second <= 0) { timeEnd(); } //If the second becomes 0 or less than 0 after the time is decrease due to a penalty, the game is over.
                guessBox.Clear(); //The previous prediction is deleted.
                guessBox.Focus(); //For the new prediction to the text box is focused.
            }catch(Exception ex) {
                emrekiBugLogger(ex, "Check Guess error!");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {   //exit the game
            try {
                gameTime.Enabled = false; //the game is paused.
                switch (MessageBox.Show("Your current progress will be lost. Do you want to exit the game?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        this.Size = new Size(419, 156);
                        timeEnd(false); //Since the game is wanted to be exited before the end of the game, the game is exited without saving the current progress.
                        break;
                    case DialogResult.No:
                        gameTime.Enabled = true; //the game is continue.
                        break;
                }
            }catch(Exception ex) {
                emrekiBugLogger(ex, "Exit Game failed!");
            }
        }

        private void historyBtn_Click(object sender, EventArgs e) {
            try {
                historyBox.Enabled = !historyBox.Enabled;
                if (historyBox.Enabled == true) //Game history is added to the Form and displayed.
                {
                    this.Size = new Size(419, 438);
                    //Game History TextBox getting ready
                    this.Controls.Add(historyBox);
                    historyBox.SetBounds(0, 117, 403, 282);
                    historyBox.ReadOnly = true;
                    historyBox.Multiline = true;
                    historyBox.ScrollBars = ScrollBars.Both;
                    historyBox.BringToFront();
                    reloadSavedData();//Load game history
                }
                else
                {   //Game history is removed from the Form.
                    this.Controls.Remove(historyBox);
                    this.Size = new Size(419, 156);
                }
                startBtn.Enabled = !historyBox.Enabled; //Prevents starting the game when game history is on.
            }catch(Exception ex) {
                emrekiBugLogger(ex, "Cant open game history!");
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {   //Player name setting
            try {
                if (nameBox.Text != "") {
                    Properties.Settings.Default.lastPlayerName = nameBox.Text;
                    Properties.Settings.Default.Save();
                }
            }catch (Exception ex) {
                emrekiBugLogger(ex, "Cant set new player name!");
            }
        }

        private void difficultyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                setDifficulty(difficultyBox.SelectedIndex); //Set game difficulty}
            }
            catch (Exception ex) {
                emrekiBugLogger(ex, "Difficulty pre set failed.");
            }
        }

        private void setDifficulty(int difficultyCode)
        {   //Some features of the game are adjusting according to the difficulty.
            try {
                Properties.Settings.Default.difficulty = difficultyCode;
                Properties.Settings.Default.Save(); //The game difficulty is saved.
                if (difficultyCode == 0) //baby
                {
                    min = 1; max = 9; durationSec = 3600; wrongGuess = 0; rightGuess = 0; guessBox.Mask = "00";
                }
                else if (difficultyCode == 1) //kid
                {
                    min = 0; max = 99; durationSec = 360; wrongGuess = 1; rightGuess = 2; guessBox.Mask = "00";
                }
                else if (difficultyCode == 2) //easy
                {
                    min = 0; max = 99; durationSec = 120; wrongGuess = 2; rightGuess = 4; guessBox.Mask = "00";
                }
                else if (difficultyCode == 3) //medium
                {
                    min = 0; max = 99; durationSec = 90; wrongGuess = 3; rightGuess = 6; guessBox.Mask = "00";
                }
                else if (difficultyCode == 4) //hard
                {
                    min = 0; max = 250; durationSec = 60; wrongGuess = 5; rightGuess = 10; guessBox.Mask = "000";
                }
                else if (difficultyCode == 5) //extreme
                {
                    min = 0; max = 500; durationSec = 60; wrongGuess = 5; rightGuess = 10; guessBox.Mask = "000";
                }
                else if (difficultyCode == 6) //impossible
                {
                    min = -1000; max = 1000; durationSec = 60; wrongGuess = 10; rightGuess = 10; guessBox.Mask = "0000";
                }
                difficultyInfo.Text = "Number range: " + min + "..." + max + "\nDuration: " + durationSec + " Second (" + durationSec / 60 + " Min)\nWrong guess: -" + wrongGuess + " Second\nRight guess: +" + rightGuess + " Second";
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "Difficulty set failed");
            }
        }

        private void reloadSavedData() {
            try {
                difficultyBox.SelectedIndex = Properties.Settings.Default.difficulty; //The saved difficulty setting is loaded.
                nameBox.Text = Properties.Settings.Default.lastPlayerName; ////The saved player name is loaded.
                                                                           //Game History Loader
                historyBox.Clear();
                historyBox.AppendText("GAME HISTORY");
                foreach (String a in Properties.Settings.Default.gameHistroy)
                {
                    historyBox.AppendText(Environment.NewLine + Environment.NewLine + a);
                }
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "Can't reload saved data!");
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e) {
            try {
                about ab = new about();
                ab.Show();
                ab.form1 = this; //When you close the About form, this form will be opened again.
                this.Hide();
            }
            catch(Exception ex) {
                emrekiBugLogger(ex, "About can't open!");
            }
        }

        /*
         Emreki Bug Logger First Version
         By sending the errors caught by the Try Catch method here, 
         a bug log file is created. In this way, the record of the errors encountered 
         can be sent to Emreki.
         */

        private void emrekiBugLogger(Exception exception, string specialDescription = "ANGG Error")
        {   //If Emreki Bug Logger start run while the game is playing, the game is stopped.
            if (gameTime.Enabled == true) {
                timeEnd(false);
            }
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(Application.StartupPath + "\\ANGG_Bug_Logs.txt", true);
                sw.WriteLine("NEW BUG REPORT\nPlease help fix the errors by submitting this error file to this site: https://emreki.art.blog/ \nApplication Version: " + version + "\nTime to encounter the bug: " + DateTime.Now.ToString() + "\nException: " + exception.Message + "\nSpecial description: " + specialDescription);
                sw.Flush();
                sw.Close();
                MessageBox.Show("An error was encountered while running the application. That's why we created a file where you can report the error to Emreki. Please forward the file indicating the error to Emreki. The application will continue to work if possible, but it is best to restart the application.\nName of the file where the error is logged: ANGG_Bug_Logs\nThis file is located in the application's file location.", "Something went wrong :) Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("An error occurred, but another error occurred while preparing to report that error.", "Error upon error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         Example Bug Log: Application File Location/ ANGG_Bug_Logs.txt
         
         NEW BUG REPORT
         Please help fix the errors by submitting this site: https://emreki.art.blog/
         Application Version: V1.0 BETA
         Time to encounter the bug: Date Time Now
         Exception: exception message
         Special Description: ANGG Error
         NEW BUG REPORT
         Every new bug report continues to be added to this file like this.
         */
    }
}