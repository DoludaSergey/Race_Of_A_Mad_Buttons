#region RaceOfAMadButtons
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace RaceOfAMadButtons
{
    //Helps move a button in main thread.
    public delegate void HelperToCall (Button button);

    #region MainForm
    public partial class MainForm : Form
    {
        #region fields
        //Threads for moving buttons.
        private Thread t1, t2, t3, t4;

        private static Random r;
        private HelperToCall helper;
        private GameStatus status;

        private ComparableButton[] buttons;

        private SoundPlayer startSound;
        private SoundPlayer runSound;
        private SoundPlayer stopSound;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();

            r = new Random();

            //Initialize Helper. 
            helper = new HelperToCall(Motion);
            //Fill array.
            buttons = new [] {first_btn, second_btn, third_btn, fourth_btn};

            SetButtonsEnable(true, false, false, false);
            status = GameStatus.Stop;

            startSound = new SoundPlayer(Properties.Resources.v8_start_loop1);
            runSound = new SoundPlayer(Properties.Resources._94_Truck_snd_run03a);
            stopSound = new SoundPlayer(Properties.Resources.lvt_snd_off);
        }
        #endregion

        #region Methods

        #region Motion
        /// <summary>
        /// Move the button.
        /// </summary>
        /// <param name="button">Current button.</param>
        private void Motion(Button button)
        {
            if (status != GameStatus.Stop)
            {
                button.Location = new Point(button.Location.X + r.Next(4), button.Location.Y);

                Leader();
                Finish(button);
            }
        }
        #endregion

        #region Leader
        /// <summary>
        /// Set a leader.
        /// </summary>
        private void Leader()
        {
            Array.Sort(buttons);

            buttons[0].BackColor = Color.Yellow;

            for(int i=1;i<buttons.Length;i++)
            {
                buttons[i].BackColor = SystemColors.Control;
            }
        }
        #endregion

        #region Finish
        /// <summary>
        /// Checking the finish.
        /// </summary>
        /// <param name="button">Current button.</param>
        private void Finish(Button button)
        {
            if (button.Location.X > this.pictureBoxFinish.Location.X - button.Width)
            {
                
                pause_btn_Click(button, new EventArgs());

                MessageBox.Show(
                    string.Format("{0} won!!!!", button.Text),
                    "We have winner!!!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                status = GameStatus.Finish;
                stop_btn_Click(button, new EventArgs());
            }
        }
        #endregion

        #region SetButtonsEnable
        /// <summary>
        /// Switch of buttons.
        /// </summary>
        /// <param name="start">Enable the start button.</param>
        /// <param name="stop">Enable the stop button.</param>
        /// <param name="pause">Enable the pause button.</param>
        /// <param name="resume">Enable the resume button.</param>
        private void SetButtonsEnable(bool start, bool stop, bool pause, bool resume)
        {
            this.start_btn.Enabled = start;
            this.stop_btn.Enabled = stop;
            this.pause_btn.Enabled = pause;
            this.resume_btn.Enabled = resume;
        }
        #endregion

        #region MillisecondsTimeout
        /// <summary>
        /// Random number for sleep.
        /// </summary>
        /// <returns>int</returns>
        private static int MillisecondsTimeout()
        {
            return r.Next(10, 70);
        }
        #endregion

        #region MovementFirstButton
        /// <summary>
        /// Move the first button.
        /// </summary>
        private void MovementFirstButton()
        {
            while (status!=GameStatus.Finish)
            {
                Thread.Sleep(MillisecondsTimeout());
                Invoke(helper, first_btn);
            }
        }
        #endregion

        #region MovementSecondButton
        /// <summary>
        /// Move the second button.
        /// </summary>
        private void MovementSecondButton()
        {
            while (status!=GameStatus.Finish)
            {
                Thread.Sleep(MillisecondsTimeout());
                Invoke(helper, second_btn);
            }
        }
        #endregion

        #region MovementThirdButton
        /// <summary>
        /// Move the third button.
        /// </summary>
        private void MovementThirdButton()
        {
            while (status!=GameStatus.Finish)
            {
                Thread.Sleep(MillisecondsTimeout());
                Invoke(helper, third_btn);
            }
        }
        #endregion

        #region MovementFourthButton
        /// <summary>
        /// Move the fourth button.
        /// </summary>
        private void MovementFourthButton()
        {
            while (status!=GameStatus.Finish)
            {
                Thread.Sleep(MillisecondsTimeout());
                Invoke(helper, fourth_btn);
            }
        }
        #endregion

        #region start_btn_Click
        /// <summary>
        /// Start movement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_btn_Click(object sender, EventArgs e)
        {
            SetButtonsEnable(false, true, true, false);
            status = GameStatus.Run;

            startSound.Load();
            startSound.Play();
            Thread.Sleep(1000);

            t1 = new Thread(MovementFirstButton);
            t2 = new Thread(MovementSecondButton);
            t3 = new Thread(MovementThirdButton);
            t4 = new Thread(MovementFourthButton);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = t4.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            runSound.Load();
            runSound.Play();
        }
        #endregion

        #region stop_btn_Click
        /// <summary>
        /// Stop movement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_btn_Click(object sender, EventArgs e)
        {
            SetButtonsEnable(true, false, false, false);
            
            if (status != GameStatus.Finish && status!=GameStatus.Pause)
            {
                SoundOfStop();
            }


            if (t1.ThreadState == (ThreadState.Background | ThreadState.Suspended))
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                t4.Resume();
            }

            t1.Abort();
            t2.Abort();
            t3.Abort();
            t4.Abort();
            
            status = GameStatus.Stop;
            ResetButtonsLocation();
        }
        #endregion

        #region SoundOfStop
        /// <summary>
        /// Play the sound.
        /// </summary>
        private void SoundOfStop()
        {
            stopSound.Load();
            stopSound.Play();
        }
        #endregion

        #region pause_btn_Click
        /// <summary>
        /// Suspend the movement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pause_btn_Click(object sender, EventArgs e)
        {
            SetButtonsEnable(false, true, false, true);
            
            if (status != GameStatus.Finish)
            {
                SoundOfStop();
            }

            status = GameStatus.Pause;

            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
                t4.Suspend();
            }
        }
        #endregion

        #region resume_btn_Click
        /// <summary>
        /// Resume the movement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resume_btn_Click(object sender, EventArgs e)
        {
            SetButtonsEnable(false, true, true, false);
            status = GameStatus.Resume;
            runSound.PlayLooping();

            if(t1!=null)
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                t4.Resume();
            }
        }
        #endregion

        #region MainForm_FormClosing
        /// <summary>
        /// Stop the threads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t1!=null)
            {
                stop_btn_Click(sender, e);
            }
        }
        #endregion

        #region ResetButtonsLocation
        /// <summary>
        /// Reset the location of buttons.
        /// </summary>
        private void ResetButtonsLocation()
        {
            foreach (var button in buttons)
            {
                button.BackColor = SystemColors.Control;
                button.Location = new Point(20, button.Location.Y);
            }
        }
        #endregion

        #endregion
    }
    #endregion
}
#endregion
