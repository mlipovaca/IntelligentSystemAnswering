using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace IntelligentAnsweringSystem
{
    public partial class IntelligentAnsweringSystemForm : Form
    {
        private readonly SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        private readonly SpeechSynthesizer Mirana = new SpeechSynthesizer();
        private readonly SpeechRecognitionEngine mainCommandListener = new SpeechRecognitionEngine();
        private readonly Random random = new Random();
        private int recordTimeOut = 0;
        private readonly DateTime currentTime = DateTime.Now;

        public IntelligentAnsweringSystemForm()
        {
            InitializeComponent();
        }

        private void IntelligentAnsweringSystem_Load(object sender, EventArgs e)
        {
            this.ActiveControl = MainTitleLabel;
            BackgroundImage.Image = Properties.Resources.background_image;
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Commands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            mainCommandListener.SetInputToDefaultAudioDevice();
            mainCommandListener.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"Commands.txt")))));
            mainCommandListener.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(mainCommandListener_SpeechRecognized);
        }

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            switch (speech)
            {
                case "Hello":
                    HandleAgentSpeakAndAppendText("Hello to you as well.");
                    break;
                case "How are you":
                    HandleAgentSpeakAndAppendText("I'm doing totally fine, thanks for asking!");
                    break;
                case "What time is it":
                    HandleAgentSpeakAndAppendText(currentTime.ToString("HH:mm", CultureInfo.InvariantCulture));
                    break;
                case "Which day is today":
                    HandleAgentSpeakAndAppendText(currentTime.ToString("dddd", CultureInfo.InvariantCulture));
                    break;
                case "Stop talking":
                    Mirana.SpeakAsyncCancelAll();
                    int randomNumber = random.Next(1, 3);
                    if (randomNumber == 1)
                    {
                        HandleAgentSpeakAndAppendText("Yes sir!");
                    }
                    else if (randomNumber == 2)
                    {
                        HandleAgentSpeakAndAppendText("I'm sorry, I'll be quiet from now on.");
                    }
                    break;
                case "Stop listening":
                    _recognizer.RecognizeAsyncCancel();
                    mainCommandListener.RecognizeAsync(RecognizeMode.Multiple);
                    break;
                case "Search on google foi":
                    Process.Start("https://www.google.com/search?q=foi");
                    HandleAgentSpeakAndAppendText("I found this on google!");
                    break;
                case "Play some funk music":
                    Process.Start("https://www.youtube.com/watch?v=uUqcBwQjj4k");
                    HandleAgentSpeakAndAppendText("Okay!");
                    break;
                case "Close browser":
                case "Stop music":
                    var alreadyRunningProc = Process.GetProcessesByName("chrome");
                    if (alreadyRunningProc.Any())
                    {
                        foreach (var process in alreadyRunningProc)
                        {
                            process.Kill();
                        }
                        HandleAgentSpeakAndAppendText("Okay!");
                    }
                    else
                    {
                        HandleAgentSpeakAndAppendText("There's nothing playing.");
                    }
                    break;
                case "Show interface":
                    this.Visible = true;
                    break;
                case "Hide interface":
                    this.Visible = false;
                    break;
            };

            userTextBox.AppendText(speech + "\r\n");
        }

        private void HandleAgentSpeakAndAppendText(string speech)
        {
            Mirana.SpeakAsync(speech);
            agentTextBox.AppendText(speech + "\r\n");
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            recordTimeOut = 0;
        }

        private void mainCommandListener_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            switch (speech)
            {
                case "Hey Mirana":
                    mainCommandListener.RecognizeAsyncCancel();
                    Mirana.SpeakAsync("Hi, my name is Mirana, how can I help?");
                    _recognizer.RecognizeAsync(RecognizeMode.Multiple);
                    break;
            };
        }

        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (recordTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if (recordTimeOut == 11)
            {
                TmrSpeaking.Stop();
                mainCommandListener.RecognizeAsync(RecognizeMode.Multiple);
                recordTimeOut = 0;
            }
        }
    }
}
