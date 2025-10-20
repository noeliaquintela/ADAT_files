using System.Text.Json;

namespace _06_json
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerJsonLocal_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "personas.json";

            if (File.Exists(ficheroJSON))
            {
                string jsonText = File.ReadAllText(ficheroJSON);
                Persona p = JsonSerializer.Deserialize<Persona>(jsonText);

                this.lblResultadoFichero.Text += "Nombre: " + p.nombre + System.Environment.NewLine +
                "Edad: " + p.edad + System.Environment.NewLine +
                "Porfesion" + p.profesion + System.Environment.NewLine;


            }
            else
            {
                this.lblResultadoFichero.Text = "El fihcro no existe";
            }

        }

        private void btnSerializarAFichero_Click(object sender, EventArgs e)
        {
            Persona p = new Persona
            {
                nombre = "Macarena",
                edad = 19,
                profesion = "Desarrolladora python"
            };

            string jsonText = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("persona_guardada.json", jsonText);

            this.lblResultadoFichero.Text = "Archivo JSON guardado correctamente.";
        }

        private void btnSerializarFromForm_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.nombre = this.txtNombre.Text;
            p.edad = System.Convert.ToInt32( this.txtEdad.Text);
            p.profesion = this.txtProfesion.Text;

            string jsonText = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("persona_guardada_form.json", jsonText);

            this.lblResultadoFichero.Text = "Archivo JSON guardado correctamente.";

        }
    }
}
