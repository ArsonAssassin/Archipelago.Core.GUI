using Archipelago.Core.GUI.Logging;
using Serilog;
using Serilog.Core;

namespace Archipelago.Core.GUI
{
    public partial class MainForm : Form
    {
        public event EventHandler<ConnectClickedEventArgs> ConnectClicked;
        public event EventHandler<ArchipelagoCommandEventArgs> CommandReceived;
        private static Logger _log;
        public MainForm(GuiDesignOptions options)
        {
            InitializeComponent();
            if (!string.IsNullOrWhiteSpace(options.Title))
            {
                this.Text = options.Title;
            }
            if (options.BackgroundColor != null)
            {
                this.BackColor = options.BackgroundColor.Value;
            }
            if (options.ButtonColor != null)
            {
                connectBtn.BackColor = options.ButtonColor.Value;
                commandBtn.BackColor = options.ButtonColor.Value;
            }
            if (options.ButtonTextColor != null)
            {
                connectBtn.ForeColor = options.ButtonTextColor.Value;
                commandBtn.ForeColor = options.ButtonTextColor.Value;
            }
            if (options.Image != null)
            {
                pictureBox1.Image = options.Image;
            }
            LoggerConfig.Initialize((e) => WriteLine(e));
        }
        public MainForm()
        {
            InitializeComponent();
            LoggerConfig.Initialize((e) => WriteLine(e));
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            ConnectClicked?.Invoke(this, new ConnectClickedEventArgs() { Host = hostTextbox.Text, Password = passwordTextbox.Text, Slot = slotTextbox.Text });
        }
        private void WriteLine(string output)
        {
            Invoke((Delegate)(() =>
            {
                outputTextbox.Text += output;
                outputTextbox.Text += System.Environment.NewLine;
            }));
        }

        private void commandTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(commandTextbox.Text))
                {
                    return;
                }

                CommandReceived?.Invoke(this, new ArchipelagoCommandEventArgs() { Command = commandTextbox.Text });
                commandTextbox.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(commandTextbox.Text))
            {
                return;
            }

            CommandReceived?.Invoke(this, new ArchipelagoCommandEventArgs() { Command = commandTextbox.Text });
            commandTextbox.Clear();
        }
    }
}
