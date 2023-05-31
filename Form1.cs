using System.Diagnostics;

namespace Left4Dead2_Audio_File_Duplicator
{
    public partial class Form1 : Form
    {
        private string rutaArchivoOriginal;
        private string carpetaDestino;
        private bool recordarUbicacion = false;
        public Form1()
        {
            InitializeComponent();
            duplicarBtn.Enabled = false;
            checkDir.Enabled = false;
            checkLetras.Enabled = false;
            checkEnumeracionAlternativa.Enabled = false;
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
                abrirSonidoBtn.Text = nombreArchivo;
                MessageBox.Show("Archivo de audio seleccionado.");
                duplicarBtn.Enabled = true;
                checkDir.Enabled = true;
                checkLetras.Enabled = true;
                checkEnumeracionAlternativa.Enabled = true;
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

            string nuevoNombre = txtNuevoNombre.Text.Trim();
            int inicio = int.Parse(txtInicio.Text);
            int fin = int.Parse(txtFin.Text);

            if (!recordarUbicacion || string.IsNullOrEmpty(carpetaDestino))
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    carpetaDestino = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    return; // Cancelar la operación si no se selecciona una carpeta
                }
            }

            string formatoNumerico = checkEnumeracionAlternativa.Checked ? "D2" : string.Empty;

            for (int i = inicio; i <= fin; i++)
            {
                string nuevoNombreCompleto;

                if (checkLetras.Checked)
                {
                    char letra = (char)(i + 96); // 1a, 1b, 1c,...
                    nuevoNombreCompleto = $"{nuevoNombre}{letra}{extensionArchivoOriginal}";
                }
                else
                {
                    nuevoNombreCompleto = $"{nuevoNombre}{i.ToString(formatoNumerico)}{extensionArchivoOriginal}";
                }

                string rutaArchivoDestino = Path.Combine(carpetaDestino, nuevoNombreCompleto);

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

        private void checkDir_CheckedChanged(object sender, EventArgs e)
        {
            recordarUbicacion = checkDir.Checked;
        }
    }
}