namespace AsyncBooksLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName.Split("\\").LastOrDefault();
            }

        }
        //Claire Battelle
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            lstReport.Items.Clear();
            lstReport2.Items.Clear();
            List<Task> tasks = new List<Task>();
            tasks.Add(ReadBook(openFileDialog1.FileName, lstReport));
            tasks.Add(ReadBook(openFileDialog2.FileName, lstReport2));
            await Task.WhenAll(tasks);
        }

        private async Task ReadBook(string filename, ListBox listbox)
        {
            var lines = await File.ReadAllLinesAsync(filename);

            //process the lines and remove spaces and punctuation
            var arrayLinesCleaned = lines.Where(x => x != string.Empty)
                .AsParallel()
                .Select(x => x.ToLower()
                .Trim()
                .Replace(",", "")
                .Replace("'", "")
                .Replace(".", "")
                .Replace("the", ""));

            var arrayOfWords = arrayLinesCleaned.SelectMany(x => x.Split(" "));

            Dictionary<string, int> wordDic = new Dictionary<string, int>();

            arrayOfWords.ToList().ForEach(x =>
            {
                if (wordDic.ContainsKey(x))
                {
                    wordDic[x]++;
                }
                else
                {
                    wordDic.Add(x, 1);
                }

            });

            var top10 = wordDic.Where(x => !string.IsNullOrWhiteSpace(x.Key))
                                                   .OrderByDescending(x => x.Value).Take(10);


            foreach (var word in top10)
            {
                listbox.Items.Add(word.Key + " - " + word.Value);
            }

        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog2.FileName.Split("\\").LastOrDefault();
            }
                
        }
    }
}
