using System.Text;
using Text_Redactor.Lib;

namespace Text_Redactor
{
    public partial class Form1 : Form
    {
        private FileInfo _OutputFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.AddRange(openFileDialog.FileNames);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericLength.Value = 3;
            _OutputFile = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "Output.txt"));
            txtOutputFile.Text = _OutputFile.Name;
        }

        private async void btnRedact_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Выберите файл с текстом для обработки");
            }

            btnRedact.Enabled = false;
            btnRedact.Text = "Идет обработка";

            try
            {
                RedactorParameters redactorParameters = new RedactorParameters()
                {
                    OutputFile = _OutputFile.FullName,
                    WordMinLength = (int)numericLength.Value,
                    RemovePunctuation = checkMarks.Checked,
                    RemoveShortWords = checkLength.Checked,
                    OverwriteFile = checkOverwrite.Checked,
                    InputFiles = new List<string>()
                };

                foreach (var path in listBox1.Items)
                {
                    redactorParameters.InputFiles.Add(path.ToString());
                }

                await Task.Run(() =>
                {
                    Redactor redactor = new Redactor(redactorParameters);
                    redactor.Redact();
                });
                MessageBox.Show($"Отредактированный текст сохранен по пути {_OutputFile.FullName}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            finally
            {
                btnRedact.Enabled = true;
                btnRedact.Text = "Обработать файлы";
            }
        }

        private void numericLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void numericLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.ActiveControl = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFile.Text = openFileDialog.SafeFileName;
                    _OutputFile = new FileInfo(openFileDialog.FileName);
                }
            }
        }
    }
}
