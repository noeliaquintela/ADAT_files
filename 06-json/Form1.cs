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
            string ficheroJSON = "persona_guardada.json";
            Persona p = new Persona
            {
                nombre = "Macarena",
                edad = 19,
                profesion = "Desarrolladora c#"
            };

            string jsonText = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ficheroJSON, jsonText);

            this.lblResultadoFichero.Text = "Archivo JSON guardado correctamente.";
        }

        private void btnSerializarFromForm_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "persona_guardada_form.json";
            Persona p = new Persona();
            p.nombre = this.txtNombre.Text;
            p.edad = System.Convert.ToInt32(this.txtEdad.Text);
            p.profesion = this.txtProfesion.Text;

            string jsonText = JsonSerializer.Serialize(p); //  (p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ficheroJSON, jsonText);

            this.lblResultadoFichero.Text = "Archivo JSON guardado correctamente.";

        }

        private void btnAppendPersona_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "persona_guardada_form.json";
            List<Persona> personas = new List<Persona>();

            // Leer el archivo si existe y deserializar la lista
            if (File.Exists(ficheroJSON))
            {
                string jsonText = File.ReadAllText(ficheroJSON);
                try
                {
                    personas = JsonSerializer.Deserialize<List<Persona>>(jsonText);
                }
                catch
                {
                    // Si el archivo no contiene una lista válida, lo ignoramos
                    personas = new List<Persona>();
                }
            }

            // Crear nueva persona desde el formulario
            Persona nueva = new Persona
            {
                nombre = this.txtNombre.Text,
                edad = Convert.ToInt32(this.txtEdad.Text),
                profesion = this.txtProfesion.Text
            };

            // Agregar a la lista y guardar
            personas.Add(nueva);
            string nuevoJson = JsonSerializer.Serialize(personas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ficheroJSON, nuevoJson);

            this.lblResultadoFichero.Text = "Persona añadida correctamente al archivo.";
        }

        private void btnLeerLista_Click(object sender, EventArgs e)
        {
            string ficheroJSON = "persona_guardada_form.json";
            this.lblResultadoFichero.Text = ""; // Limpiar contenido previo

            if (File.Exists(ficheroJSON))
            {
                string jsonText = File.ReadAllText(ficheroJSON);
                try
                {
                    List<Persona> personas = JsonSerializer.Deserialize<List<Persona>>(jsonText);

                    foreach (Persona p in personas)
                    {
                        this.lblResultadoFichero.Text += "Nombre: " + p.nombre + Environment.NewLine +
                                                         "Edad: " + p.edad + Environment.NewLine +
                                                         "Profesión: " + p.profesion + Environment.NewLine +
                                                         "------------------------" + Environment.NewLine;
                    }
                }
                catch
                {
                    this.lblResultadoFichero.Text = "El archivo no contiene una lista válida de personas.";
                }
            }
            else
            {
                this.lblResultadoFichero.Text = "El archivo no existe.";
            }
        }

    }
}
