using DM6500Remote;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DM6500RemoteOld
{
    public partial class DM6500Remote : Form
    {
        private const double MIN_DELAY = 0.5;
        private const double MAX_DELAY = 1000000;

        private VirtualMachine _virtualMachine;
        private WorkMachine _workMachine;
        private ExcelWritter _excelWritter;
        private Data _data;

        private string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        private int _amount;
        private double _delay;
        private bool InProcess = false;

        private bool _IsDebug = false;

        private string _errorMessage = "Wrong data";

        private struct Data
        {
            public double Time;
            public double Current;
            public double Voltage;
            public void Init()
            {
                Time = 0;
                Current = 0;
                Voltage = 0;
            }
            public void Update(double time, double current, double voltage)
            {
                if (time < 0)
                {
                    MessageBox.Show("Time cannot be negative");
                    return;
                }
                Time = time;
                Current = current;
                Voltage = voltage;
            }
            public double[] GraspData()
            {
                return new double[] { Time, Current, Voltage };
            }
        }

        public DM6500Remote()
        {
            InitializeComponent();
            IsDebug(ref _IsDebug);
        }

        #region UI
        private void DM6500Remote_Load(object sender, EventArgs e)
        {
            FolderPath.Text = _folderPath;
        }
        private void Path_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            _folderPath = FolderBrowserDialog.SelectedPath;
            FolderPath.Text = _folderPath;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (CheckName() == false)
            {
                MessageBox.Show("Wrong name. Please use only letters, numbers and underscore");
                return;
            }
            if (CheckFields())
            {
                _delay = Math.Round(_delay,2);
                ChangeActivePanel();
                _data.Init();
                RefreshTimer.Interval = (int)(_delay * 1000);
                ProgressBar.Maximum = _amount;
                ProgressBar.Value = 0;
                InProcess = true;
                StartMeasurementAsync();
            }
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            StopMeasurement();
        }
        private void FillTheData()
        {
            Current.Text = _data.Current.ToString();
            Voltage.Text = _data.Voltage.ToString();
            if (ProgressBar.Value < ProgressBar.Maximum)
                ProgressBar.Value++;
            else
                StopMeasurement();
        }
        private void ChangeActivePanel()
        {
            SettingsPanel.Enabled = !SettingsPanel.Enabled;
            MeasurementPanel.Enabled = !MeasurementPanel.Enabled;
            Exit.Enabled = !Exit.Enabled;
        }
        #endregion

        #region AsyncTasks

        private async void StartMeasurementAsync()
        {
            await Task.Run(CreateExcel); // in another thread
            RefreshTimer.Start();
            if (_IsDebug)
                await Task.Run(CreateVirtualMachine); // in another thread
            else
                await Task.Run(CreateMachine); // in another thread
        }
        [Conditional("DEBUG")]
        private void IsDebug(ref bool isDebug)
        {
            isDebug = true;
        }
        private async Task CreateVirtualMachine()
        {
            _virtualMachine = new VirtualMachine(_delay, _amount);
            _virtualMachine.WriteMessage += ReadMessage;   // Subscription
            await Task.Run(() => _virtualMachine.StartExchange());
        }
        private async Task CreateMachine()
        {
            _workMachine = new WorkMachine(_delay, _amount);
            _workMachine.WriteMessage += ReadMessage;   // Subscription
            await Task.Run(() => _workMachine.StartExchange());
        }
        private async Task CreateExcel()
        {
            if(_excelWritter == null)
                _excelWritter = new ExcelWritter(_folderPath, FileName.Text);
            await Task.Run(() => _excelWritter.CreateNewList());
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            FillTheData();
        }
#endregion

#region Non-async

        private bool CheckName()
        {
            return Regex.IsMatch(FileName.Text, @"^[a-zA-Z0-9_]+$");
        }
        private bool CheckFields()
        {
            bool isCorrect = true;
            isCorrect &= (Int32.TryParse(Amount.Text, out _amount) & _amount > 0 & _amount < Int16.MaxValue);
            isCorrect &= (Double.TryParse(Delay.Text, out _delay) & _delay >= MIN_DELAY & _delay <= MAX_DELAY);
            return isCorrect;
        }
        private void StopMeasurement()
        {
            ChangeActivePanel();
             _excelWritter.SaveFile();
            if (_IsDebug)
                _virtualMachine.WriteMessage -= ReadMessage;   // Unsubscription
            else
            {
                _workMachine.WriteMessage -= ReadMessage;   // Unsubscription
                _workMachine.StopExchange();
            }
            InProcess = false;
            RefreshTimer.Stop();
        }
        private void ReadMessage(string[] args)
        {
            if (args[0] == "error")
            {
                MessageBox.Show(args[1]);
                return;
            }
            if (args.Length != 3)
            {
                MessageBox.Show(_errorMessage);
                return;
            }
            Double.TryParse(args[0], out _data.Time);
            Double.TryParse(args[1], out _data.Current);
            Double.TryParse(args[2], out _data.Voltage);
            _excelWritter.AddLine(_data.GraspData());
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
#endregion
    }
}
