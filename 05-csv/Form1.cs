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

        private void button1_Click(object sender, EventArgs e)
        {
            string fichero = "personas_puntocoma.csv";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";" //establece el delimitador en ";"               
            };

            using StreamReader sr = new StreamReader(fichero);
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

        private void button2_Click(object sender, EventArgs e)
        {

            string fichero = "personas_puntocoma_sinencabezados.csv";

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", //establece el delimitador en ";"               
                HasHeaderRecord = false //csv sin encabezados
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

        private void btnGuardarCSVHelper_Click(object sender, EventArgs e)
        {
            string fichero = "personas_guardadas.csv";

            // Crear una lista de ejemplo de personas (puedes reemplazarla con datos dinámicos)
            var personas = new List<Persona>
            {
                new Persona { nombre = "Carlos", edad = 35, altura = 170 },
                new Persona { nombre = "María", edad = 28, altura = 160 },
                new Persona { nombre = "Pedro", edad = 40, altura = 180 }
            };

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";", // Establece el delimitador en ";"
                HasHeaderRecord = true // Incluye encabezados en el CSV
            };

            try
            {
                using (var sw = new StreamWriter(fichero, false, new System.Text.UTF8Encoding(true)))
                using (var csv = new CsvWriter(sw, config))
                {
                    csv.WriteRecords(personas);
                }

                MessageBox.Show("Lista de personas guardada correctamente en el fichero CSV.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el fichero CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
