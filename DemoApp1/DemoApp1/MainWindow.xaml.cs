using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //FirefoxDriver firefoxDriver = new FirefoxDriver();
            //firefoxDriver.Url = "https://www.facebook.com/";
            //firefoxDriver.Navigate();
            LoadChrome();
            //OpenQA.Selenium.By By = new;
            //var searchBar = firefoxDriver.FindElement( );

            // gõ giá trị Selenium Kteam vào thanh tìm kiếm
            //searchBar.SendKeys("Selenium Kteam");
        }
        private string chromeDriverPath = @"D:\Demo\DemoApp1\DemoApp1\bin\Debug\net6.0-windows\chromedriver.exe"; //Path to chromedriver.exe
        private string braveBrowserPath = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe"; //Path to brave.exe

        private FirefoxOptions chromeOptions; //Default value of chromeOptions is null
        private IWebDriver driver; //Default value of driver is null

        public void LoadChrome()
        {
            try
            {
                Environment.SetEnvironmentVariable("webdriver.chrome.driver", chromeDriverPath); //Sets process evnironment
                chromeOptions = new FirefoxOptions(); //Initialize chromeOptions
                chromeOptions.BinaryLocation = braveBrowserPath; //Sets the location of Brave
                driver= new FirefoxDriver(chromeOptions);  //Initialize driver with chromeOptions
                driver.Url="https://www.facebook.com/";
                //driver.Manage().Window.Maximize(); //Set Brave window maximized
                driver.Navigate(); //Loads page Google
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //Print any errors to console log
            }
        }
    }
}