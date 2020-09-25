using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBDKillers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbl_killerNickname.Text = "";
            lbl_killerName.Text = "";
        }

        private readonly string[,] _killers = {
            {"0", "Evan MacMillan", "Trapper"},
            {"1", "Philip Ojomo", "Wraith"},
            {"2", "Max Thompson Jr.", "Hillbilly"},
            {"3", "Sally Smithson", "Nurse"},
            {"4", "Michael Myers", "Shape"},
            {"5", "Lisa Sherwood", "Hag"},
            {"6", "Herman Carter", "Doctor"},
            {"7", "Anna", "Huntress"},
            {"8", "Bubba Sawyer", "Cannibal"},
            {"9", "Freddy Krueger", "Nightmare"},
            {"10", "Amanda Young", "Pig"},
            {"11", "Jeffrey Hawk", "Clown"},
            {"12", "Rin Yamaoka", "Spirit"},
            {"13", "Frank, Julie, Susie, Joey", "Legion"},
            {"14", "Adiris", "Plague"},
            {"15", "Danny Johnson", "Ghost Face"},
            {"16", "Demogorgon", "Demogorgon"},
            {"17", "Kazan Yamaoka", "Oni"},
            {"18", "Caleb Quinn", "Deathslinger"},
            {"19", "Pyramid Head", "Executioner"},
            {"20", "Talbot Grimes", "Blight"}
        };

        Random RDM = new Random();

        private async void Btn_chooseRDMKiller_Click(object sender, EventArgs e)
        {
            pBar.Value = 0;
            int delay = RDM.Next(10, 50);
            pBar.Maximum = delay;
            await RdmKiller(delay);
            int rdmKiller = RDM.Next(21);

            lbl_killerName.Text = _killers[rdmKiller, 1];
            lbl_killerNickname.Text = _killers[rdmKiller, 2];
            switch (_killers[rdmKiller, 2])
            {
                case "Trapper":
                    picBox.Image = Properties.Resources.Trapper;
                    break;
                case "Wraith":
                    picBox.Image = Properties.Resources.Wraith;
                    break;
                case "Hillbilly":
                    picBox.Image = Properties.Resources.Hillbilly;
                    break;
                case "Nurse":
                    picBox.Image = Properties.Resources.Nurse;
                    break;
                case "Shape":
                    picBox.Image = Properties.Resources.Shape;
                    break;
                case "Hag":
                    picBox.Image = Properties.Resources.Hag;
                    break;
                case "Doctor":
                    picBox.Image = Properties.Resources.Doctor;
                    break;
                case "Huntress":
                    picBox.Image = Properties.Resources.Huntress;
                    break;
                case "Cannibal":
                    picBox.Image = Properties.Resources.Cannibal;
                    break;
                case "Nightmare":
                    picBox.Image = Properties.Resources.Nightmare;
                    break;
                case "Pig":
                    picBox.Image = Properties.Resources.Pig;
                    break;
                case "Clown":
                    picBox.Image = Properties.Resources.Clown;
                    break;
                case "Spirit":
                    picBox.Image = Properties.Resources.Spirit;
                    break;
                case "Legion":
                    picBox.Image = Properties.Resources.Legion;
                    break;
                case "Plague":
                    picBox.Image = Properties.Resources.Plague;
                    break;
                case "Ghost Face":
                    picBox.Image = Properties.Resources.Ghost_Face;
                    break;
                case "Demogorgon":
                    picBox.Image = Properties.Resources.Demogorgon;
                    break;
                case "Oni":
                    picBox.Image = Properties.Resources.Oni;
                    break;
                case "Deathslinger":
                    picBox.Image = Properties.Resources.Deathslinger;
                    break;
                case "Executioner":
                    picBox.Image = Properties.Resources.Executioner;
                    break;
                case "Blight":
                    picBox.Image = Properties.Resources.Blight;
                    break;

            }
        }

        private async Task RdmKiller(int delay)
        {
            for (int i = 0; i < delay; i++)
            {
                int rdmKiller = RDM.Next(21);

                lbl_killerName.Text = _killers[rdmKiller, 1];
                lbl_killerNickname.Text = _killers[rdmKiller, 2];
                switch (_killers[rdmKiller, 2])
                {
                    case "Trapper":
                        picBox.Image = Properties.Resources.Trapper;
                        break;
                    case "Wraith":
                        picBox.Image = Properties.Resources.Wraith;
                        break;
                    case "Hillbilly":
                        picBox.Image = Properties.Resources.Hillbilly;
                        break;
                    case "Nurse":
                        picBox.Image = Properties.Resources.Nurse;
                        break;
                    case "Shape":
                        picBox.Image = Properties.Resources.Shape;
                        break;
                    case "Hag":
                        picBox.Image = Properties.Resources.Hag;
                        break;
                    case "Doctor":
                        picBox.Image = Properties.Resources.Doctor;
                        break;
                    case "Huntress":
                        picBox.Image = Properties.Resources.Huntress;
                        break;
                    case "Cannibal":
                        picBox.Image = Properties.Resources.Cannibal;
                        break;
                    case "Nightmare":
                        picBox.Image = Properties.Resources.Nightmare;
                        break;
                    case "Pig":
                        picBox.Image = Properties.Resources.Pig;
                        break;
                    case "Clown":
                        picBox.Image = Properties.Resources.Clown;
                        break;
                    case "Spirit":
                        picBox.Image = Properties.Resources.Spirit;
                        break;
                    case "Legion":
                        picBox.Image = Properties.Resources.Legion;
                        break;
                    case "Plague":
                        picBox.Image = Properties.Resources.Plague;
                        break;
                    case "Ghost Face":
                        picBox.Image = Properties.Resources.Ghost_Face;
                        break;
                    case "Demogorgon":
                        picBox.Image = Properties.Resources.Demogorgon;
                        break;
                    case "Oni":
                        picBox.Image = Properties.Resources.Oni;
                        break;
                    case "Deathslinger":
                        picBox.Image = Properties.Resources.Deathslinger;
                        break;
                    case "Executioner":
                        picBox.Image = Properties.Resources.Executioner;
                        break;
                    case "Blight":
                        picBox.Image = Properties.Resources.Blight;
                        break;
                }
                pBar.PerformStep();
                await Task.Delay(50);
            }
        }
    }
}
