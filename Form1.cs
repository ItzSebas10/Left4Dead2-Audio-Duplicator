using System.Diagnostics;

namespace Left4Dead2_Audio_File_Duplicator
{
    public partial class Form1 : Form
    {
        private string rutaArchivoOriginal;
        private string nuevoNombre;
        public Form1()
        {
            InitializeComponent();
            duplicarBtn.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void abrirSonidoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de audio (*.mp3, *.wav)|*.mp3;*.wav|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo de audio";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoOriginal = openFileDialog.FileName;
                string nombreArchivo = Path.GetFileName(rutaArchivoOriginal);
                lblNombreArchivo.Text = nombreArchivo;
                MessageBox.Show("Archivo de audio seleccionado.");
                duplicarBtn.Enabled = true;
            }
        }

        private void duplicarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoOriginal))
            {
                MessageBox.Show("Por favor, seleccione un archivo de audio primero.");
                return;
            }

            if (string.IsNullOrEmpty(txtNuevoNombre.Text) || string.IsNullOrEmpty(txtInicio.Text) || string.IsNullOrEmpty(txtFin.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de nombre y rango.");
                return;
            }

            string extensionArchivoOriginal = Path.GetExtension(rutaArchivoOriginal);

            nuevoNombre = txtNuevoNombre.Text.Trim();
            int inicio = int.Parse(txtInicio.Text);
            int fin = int.Parse(txtFin.Text);

            // Solicitar una nueva ubicación para guardar las copias
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string directorioDestino = folderBrowserDialog.SelectedPath;

                for (int i = inicio; i <= fin; i++)
                {
                    string nuevoNombreCompleto = $"{nuevoNombre}{i.ToString("D2")}{extensionArchivoOriginal}";
                    string rutaArchivoDestino = Path.Combine(directorioDestino, nuevoNombreCompleto);

                    if (File.Exists(rutaArchivoDestino))
                    {
                        DialogResult overwriteResult = MessageBox.Show($"El archivo {nuevoNombreCompleto} ya existe en la ubicación destino. ¿Desea sobrescribirlo?", "Archivo existente", MessageBoxButtons.YesNoCancel);

                        if (overwriteResult == DialogResult.Yes)
                        {
                            File.Copy(rutaArchivoOriginal, rutaArchivoDestino, true);
                        }
                        else if (overwriteResult == DialogResult.No)
                        {
                            continue; // Omitir la copia y pasar al siguiente archivo
                        }
                        else if (overwriteResult == DialogResult.Cancel)
                        {
                            break; // Detener el proceso de duplicación
                        }
                    }
                    else
                    {
                        File.Copy(rutaArchivoOriginal, rutaArchivoDestino);
                    }
                }

                MessageBox.Show("Copias completadas.");
            }
        }
    }
}