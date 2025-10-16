using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


namespace _05_csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerCSV_Click(object sender, EventArgs e)
        {
            String fichero = "personas_puntocoma.csv";
            if (File.Exists(fichero))
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    string? linea;

                    while ((linea = sr.ReadLine()) != null)
                    {
                        //dividir por ;
                        var campos = linea.Split(';');

                        foreach (var campo in campos)
                        {
                            this.label1.Text += campo + " ";
                        }
                        this.label1.Text += System.Environment.NewLine;
                    }
                }

            }
        }

        private void btnLeerCSVHelper_Click(object sender, EventArgs e)
        {
            string fichero = "personas.csv";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture) 
            { 
            
            };

            StreamReader sr = new StreamReader(fichero);
            using (var csv = new CsvReader(sr, config))
            {
                var personas = csv.GetRecords<Persona>();

                foreach (var persona in personas)
                {
                    this.label1.Text += persona.nombre + " " +
                                        persona.edad + " " +
                                        persona.altura + System.Environment.NewLine;
                }
            }
        }
    }
}
