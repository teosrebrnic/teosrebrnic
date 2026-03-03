namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Odaberite Yes / No / Cancel";

            string naslov = "Naslovna linija Dijaloga za poruke";

            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;

            MessageBoxIcon ikona = MessageBoxIcon.Information;
            // MessageBox.Show() vraća vrijednost tipa DialogResult

            // tu vrijednost dodjeljujemo varijabli rez

            DialogResult rez = MessageBox.Show(poruka, naslov, buttons, ikona);
            switch (rez)
            {
                case DialogResult.Yes:
                    textBoxRezultat.Text = "Izabrali ste dugme YES";
                    break;
                case DialogResult.No:
                    textBoxRezultat.Text = "Izabrali ste dugme NO";
                    break;
                case DialogResult.Cancel:
                    textBoxRezultat.Text = "Izabrali ste dugme Cancel";
                    break;
            }
        }
    }
}
