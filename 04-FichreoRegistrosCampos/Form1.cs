using System.Windows.Forms;

namespace _04_FichreoRegistrosCampos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertarNota_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";

            // Abrir el fichero en modo append
            using (StreamWriter sw = File.AppendText(fichero))
            {
                //string linea = txtNombre.Text + "#" + numNota.Value.ToString();
                //sw.WriteLine(linea);
                sw.WriteLine($"{this.txtNombre.Text}#{this.numNota.Value.ToString()}");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";

            // Limpiamos el ListBox antes de cargar los datos
            this.lstNotas.Items.Clear();

            if (File.Exists(fichero))
            {
                using (StreamReader sr = new StreamReader(fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Dividir la l�nea por el car�cter '#'
                        string[] partes = linea.Split('#');

                        // Verificamos que haya dos partes (nombre y nota)
                        if (partes.Length == 2)
                        {
                            string nombre = partes[0];
                            string nota = partes[1];

                            // A�adimos al ListBox en formato "Nombre - Nota"
                            this.lstNotas.Items.Add($"{nombre} - {nota}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontr� el fichero " + fichero, "Error");
            }
        }

        private void btnMejorNota_Click(object sender, EventArgs e)
        {
            String Fichero = "notas.txt";

            if (File.Exists(Fichero))
            {
                string mejorNombre = "";
                int mejorNota = -1;

                using (StreamReader sr = new StreamReader(Fichero))
                {
                    string? linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split('#');
                        if (partes.Length == 2)
                        {
                            if (int.TryParse(partes[1], out int nota))
                            {
                                if (nota > mejorNota)
                                {
                                    mejorNota = nota;
                                    mejorNombre = partes[0];
                                }
                            }
                        }
                    }
                    this.lblMejorNota.Text = mejorNombre + "=>" + mejorNota.ToString();
                }
            }
        }

        private void btnGuardaModifica_Click(object sender, EventArgs e)
        {
            string fichero = "notas.txt";
            string nombre = this.txtNombre.Text.Trim();
            string nuevaNota = this.numNota.Value.ToString();

            // Si el fichero no existe, lo creamos directamente
            if (!File.Exists(fichero))
            {
                using (StreamWriter sw = File.AppendText(fichero))
                {
                    sw.WriteLine($"{nombre}#{nuevaNota}");
                }
                MessageBox.Show("Nota guardada correctamente (nuevo registro).");
                return;
            }

            // Leemos todas las l�neas
            string[] lineas = File.ReadAllLines(fichero);
            //bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] partes = lineas[i].Split('#');
                if (partes.Length == 2 && partes[0].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    //encontrado = true;

                    DialogResult respuesta = MessageBox.Show(
                        $"El nombre '{nombre}' ya existe con la nota {partes[1]}. �Deseas modificarla?",
                        "Modificar nota",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        // Modificamos la nota
                        lineas[i] = $"{nombre}#{nuevaNota}";
                        File.WriteAllLines(fichero, lineas);
                        MessageBox.Show("Nota modificada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios.");
                    }

                    return;
                }
            }

            // Si no se encontr� el nombre, lo a�adimos al final
            //if (!encontrado)
            //{
            //    using (StreamWriter sw = File.AppendText(fichero))
            //    {
            //        sw.WriteLine($"{nombre}#{nuevaNota}");
            //    }
            //    MessageBox.Show("Nota guardada correctamente (nuevo registro).");
            //}
        }
    }
}
