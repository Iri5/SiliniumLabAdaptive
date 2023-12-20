using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumLab {
    public partial class Form1 : Form {

        private IWebDriver chrome;
        private string site = String.Empty;
        private string savePath = String.Empty;
        public Form1() {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, EventArgs e) {
            progressBar1.Minimum = 0;
            int count = 0;
            if (checkBox3840_2160.Checked) count++;
            if (checkBox1920_1080.Checked) count++;
            if (checkBox1366_768.Checked) count++;
            if (checkBox1280_720.Checked) count++;
            if (checkBox_useCustome.Checked) count++;
            progressBar1.Maximum = count;
            site = linkBox.Text;
            if (site == String.Empty) {
                MessageBox.Show("Указана пустая ссылка.");
                return;
            }
            if (savePath == String.Empty) {
                MessageBox.Show("Выберите папку для сохранения.");
                return;
            }
            if (checkBox3840_2160.Checked) {
                try {
                    ChromeOptions opt = new ChromeOptions();
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    if (isSilent.Checked)
                    {
                        opt.AddArgument("--headless");
                        service.HideCommandPromptWindow = true;
                    }
                    chrome = new ChromeDriver(service, opt);
                    chrome.Navigate().GoToUrl(site);
                    chrome.Manage().Window.Size = new Size(3840, 2160);
                    Screenshot chromeShot = (chrome as ITakesScreenshot).GetScreenshot();
                    chromeShot.SaveAsFile(savePath + @"\3840x2160.png");
                    progressBar1.Value++;
                    chrome.Quit();
                }
                catch (Exception ex) {
                    MessageBox.Show("Проверьте введённую ссылку");
                    return;
                }
            }
            if (checkBox1920_1080.Checked)
            {
                try
                {
                    ChromeOptions opt = new ChromeOptions();
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    if (isSilent.Checked)
                    {
                        opt.AddArgument("--headless");
                        service.HideCommandPromptWindow = true;
                    }
                    chrome = new ChromeDriver(service, opt);
                    chrome.Navigate().GoToUrl(site);
                    chrome.Manage().Window.Size = new Size(1920, 1080);
                    Screenshot chromeShot = (chrome as ITakesScreenshot).GetScreenshot();
                    chromeShot.SaveAsFile(savePath + @"\1920x1080.png");
                    progressBar1.Value++;
                    chrome.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте введённую ссылку");
                    return;
                }
            }
            if (checkBox1366_768.Checked)
            {
                try
                {
                    ChromeOptions opt = new ChromeOptions();
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    if (isSilent.Checked)
                    {
                        opt.AddArgument("--headless");
                        service.HideCommandPromptWindow = true;
                    }
                    chrome = new ChromeDriver(service, opt);
                    chrome.Navigate().GoToUrl(site);
                    chrome.Manage().Window.Size = new Size(1366, 768);
                    Screenshot chromeShot = (chrome as ITakesScreenshot).GetScreenshot();
                    chromeShot.SaveAsFile(savePath + @"\1366x768.png");
                    progressBar1.Value++;
                    chrome.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте введённую ссылку");
                    return;
                }
            }
            if (checkBox1280_720.Checked)
            {
                try
                {
                   
                    ChromeOptions opt = new ChromeOptions();
                    ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                    if (isSilent.Checked)
                    {
                        opt.AddArgument("--headless");
                        service.HideCommandPromptWindow = true;
                    }
                    chrome = new ChromeDriver(service, opt);
                    chrome.Navigate().GoToUrl(site);
                    chrome.Manage().Window.Size = new Size(1280, 720);
                    Screenshot chromeShot = (chrome as ITakesScreenshot).GetScreenshot();
                    chromeShot.SaveAsFile(savePath + @"\1280x720.png");
                    progressBar1.Value++;
                    chrome.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте введённую ссылку");
                    return;
                }
            }
            if (checkBox_useCustome.Checked)
            {
                int height = 0;
                int weidth = 0;
                if(textBox_width.Text == "" || textBox_height.Text == "")
                {
                    MessageBox.Show("Заполните поля");
                    return;
                }
                try
                {
                    int s = Convert.ToInt32((textBox_height.Text));
                    height = s;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Недопустимое значение высоты");
                }
                try
                {
                    int s = Convert.ToInt32((textBox_width.Text));
                    weidth = s;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Недопустимое значение ширины");
                }
                try
                {
                   ChromeOptions opt = new ChromeOptions();
                   ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                   if (isSilent.Checked)
                   {
                       opt.AddArgument("--headless");
                       service.HideCommandPromptWindow = true;
                   }
                   chrome = new ChromeDriver(service, opt);
                   chrome.Navigate().GoToUrl(site);
                   chrome.Manage().Window.Size = new Size(weidth, height);
                   Screenshot chromeShot = (chrome as ITakesScreenshot).GetScreenshot();
                   chromeShot.SaveAsFile(savePath + @"\" + weidth + "x" + height +".png");
                    progressBar1.Value++;
                    chrome.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте введённую ссылку");
                    return;
                }
            }

            MessageBox.Show("Тестирование завершено.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            if (chrome != null) {
                chrome.Quit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                savePath = folderBrowserDialog1.SelectedPath;
                folderLabel.Text = savePath.Split('\\')[0] + @"\...\" + savePath.Split('\\')[savePath.Split('\\').Count() - 1];
                var test = savePath.Split('\\');
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32((textBox_height.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Допустимы только цифры");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_width_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32((textBox_width.Text));
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Допустимы только цифры");
            }
        }
    }
}