namespace Catalog
{
    public partial class Form1 : Form
    {

        string numeElev;
        string materie;
        int[] note;



        private int mediaAritmeticaNote(int[] note)
        {
            int suma = 0;

            foreach (int nota in note)
            {
                suma += nota;
            }
            int media = suma / note.Length;
            return media;


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void numetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTextBox_Click(object sender, EventArgs e)
        {
            string numeElev = numetextBox.Text;
            string materie = materiaTextBox.Text;
            try
            {
                string[] strNote = notaTextBox.Text.Split(',');

                int[] noteVector = Array.ConvertAll(strNote, int.Parse);

                int medieAritmetica = mediaAritmeticaNote(noteVector);

                afisajText.Text = $"Nume elev: {numeElev} \n " +
                                  $"Materia:  {materie}  \n" +
                                  $"Media finala: {medieAritmetica} \n" +
                                  $"Notele pentru {materie}: {noteVector}";
            }
            catch (FormatException)
            {
                
                afisajText.Text = "Formatul notelor este incorect.";
            }


        }
    }
}
