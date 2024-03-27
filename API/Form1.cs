using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace API
{
    public partial class Form1 : Form
    {

        private HttpClient client;
        private Currency currency;
        private CurrencyContext CurrencyCon;
        public Form1()
        {
            InitializeComponent();
            CurrencyCon = new CurrencyContext();
            client = new HttpClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = ":)";
            if (File.Exists("Value.db"))
            {
                File.Delete("Value.db");
            }
            DateTime selectedDate = dateTimePicker1.Value;
            string call = $"https://openexchangerates.org/api/historical/{selectedDate.ToString("yyyy-MM-dd")}.json?app_id=b62e67397a5744a6973dd512d6bf7139";

            string response = await client.GetStringAsync(call);
            currency = JsonSerializer.Deserialize<Currency>(response);
            textBox1.Text = currency.ToString();
            bool recordExists = CurrencyCon.Currencies.Any(c => c.Date.Date == selectedDate.Date);
            if (recordExists)
            {
                textBox4.Text = "Ta data ju¿ istnieje w bazie danych";
;
                return;
            }
            else
            {
                CurrencyCon.Currencies.Add(new CurrencyData()
                { Date = selectedDate, Timestamp = currency.timestamp, Base = currency.@base, CHF = currency.rates.CHF, EUR = currency.rates.EUR, GBP = currency.rates.GBP, JPY = currency.rates.JPY, PLN = currency.rates.PLN });
                CurrencyCon.SaveChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n;
            if (!double.TryParse(textBox2.Text, out n) || n < 0)
            {
                textBox2.BackColor = Color.Red;
            }
            else { textBox2.BackColor = Color.White; }

            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                comboBox2.BackColor = Color.Red;
                comboBox1.BackColor = Color.Red;
                return;
            }
            else if (comboBox1.SelectedItem == null)
            {
                comboBox1.BackColor = Color.Red;
                comboBox2.BackColor = Color.White;
                return;
            }
            else if (comboBox2.SelectedItem == null)
            {
                comboBox2.BackColor = Color.Red;
                comboBox1.BackColor = Color.White;
                return;
            }
            else
            {
                comboBox1.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
            }

            string selectedCurrency1 = comboBox1.SelectedItem.ToString();
            string selectedCurrency2 = comboBox2.SelectedItem.ToString();

            if (currency.rates != null)
            {
                double result = 0;

                switch (selectedCurrency1)
                {
                    case "USD":

                        switch (selectedCurrency2)
                        {
                            case "USD":
                                result = n;
                                break;
                            case "CHF":
                                result = n * currency.rates.CHF;
                                break;
                            case "EUR":
                                result = n * currency.rates.EUR;
                                break;
                            case "GBP":
                                result = n * currency.rates.GBP;
                                break;
                            case "JPY":
                                result = n * currency.rates.JPY;
                                break;
                            case "PLN":
                                result = n * currency.rates.PLN;
                                break;
                        }
                        break;
                    case "EUR":

                        switch (selectedCurrency2)
                        {
                            case "USD":
                                result = n / currency.rates.EUR;
                                break;
                            case "CHF":
                                result = n * currency.rates.CHF / currency.rates.EUR;
                                break;
                            case "EUR":
                                result = n * currency.rates.EUR / currency.rates.EUR;
                                break;
                            case "GBP":
                                result = n * currency.rates.GBP / currency.rates.EUR;
                                break;
                            case "JPY":
                                result = n * currency.rates.JPY / currency.rates.EUR;
                                break;
                            case "PLN":
                                result = n * currency.rates.PLN / currency.rates.EUR;
                                break;
                        }
                        break;
                    case "GBP":
                        switch (selectedCurrency2)
                        {
                            case "USD":
                                result = n / currency.rates.GBP;
                                break;
                            case "CHF":
                                result = n * currency.rates.CHF / currency.rates.GBP;
                                break;
                            case "EUR":
                                result = n * currency.rates.EUR / currency.rates.GBP;
                                break;
                            case "GBP":
                                result = n * currency.rates.GBP / currency.rates.GBP;
                                break;
                            case "JPY":
                                result = n * currency.rates.JPY / currency.rates.GBP;
                                break;
                            case "PLN":
                                result = n * currency.rates.PLN / currency.rates.GBP;
                                break;
                        }
                        break;
                    case "JPY":
                        switch (selectedCurrency2)
                        {
                            case "USD":
                                result = n / currency.rates.JPY;
                                break;
                            case "CHF":
                                result = n * currency.rates.CHF / currency.rates.JPY;
                                break;
                            case "EUR":
                                result = n * currency.rates.EUR / currency.rates.JPY;
                                break;
                            case "GBP":
                                result = n * currency.rates.GBP / currency.rates.JPY;
                                break;
                            case "JPY":
                                result = n * currency.rates.JPY / currency.rates.JPY;
                                break;
                            case "PLN":
                                result = n * currency.rates.PLN / currency.rates.JPY;
                                break;
                        }
                        break;
                    case "PLN":
                        switch (selectedCurrency2)
                        {
                            case "USD":
                                result = n / currency.rates.PLN;
                                break;
                            case "CHF":
                                result = n * currency.rates.CHF / currency.rates.PLN;
                                break;
                            case "EUR":
                                result = n * currency.rates.EUR / currency.rates.PLN;
                                break;
                            case "GBP":
                                result = n * currency.rates.GBP / currency.rates.PLN;
                                break;
                            case "JPY":
                                result = n * currency.rates.JPY / currency.rates.PLN;
                                break;
                            case "PLN":
                                result = n * currency.rates.PLN / currency.rates.PLN;
                                break;
                            default:
                                textBox3.Text = $"Wybierz walutê docelow¹.";
                                break;
                        }
                        break;
                    default:
                        textBox3.Text = $"Wybierz walutê docelow¹.";
                        break;
                }
                textBox3.Text = $"{n} {selectedCurrency1} = {result} {selectedCurrency2}";

            }
            else
            {
                textBox3.Text = $"Brak danych!";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCurrency = comboBox1.SelectedItem.ToString();
            switch (selectedCurrency)
            {
                case "USD":
                    panel1.BackgroundImage = Properties.Resources.USD;
                    break;
                case "CHF":
                    panel1.BackgroundImage = Properties.Resources.CHF;
                    break;
                case "EUR":
                    panel1.BackgroundImage = Properties.Resources.EUR;
                    break;
                case "GBP":
                    panel1.BackgroundImage = Properties.Resources.GBP;
                    break;
                case "JPY":
                    panel1.BackgroundImage = Properties.Resources.JPY;
                    break;
                case "PLN":
                    panel1.BackgroundImage = Properties.Resources.PLN;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCurrency = comboBox2.SelectedItem.ToString();
            switch (selectedCurrency)
            {
                case "USD":
                    panel2.BackgroundImage = Properties.Resources.USD;
                    break;
                case "CHF":
                    panel2.BackgroundImage = Properties.Resources.CHF;
                    break;
                case "EUR":
                    panel2.BackgroundImage = Properties.Resources.EUR;
                    break;
                case "GBP":
                    panel2.BackgroundImage = Properties.Resources.GBP;
                    break;
                case "JPY":
                    panel2.BackgroundImage = Properties.Resources.JPY;
                    break;
                case "PLN":
                    panel2.BackgroundImage = Properties.Resources.PLN;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DateTime selectedDate = dateTimePicker1.Value;
            bool recordExists = CurrencyCon.Currencies.Any(c => c.Date.Date == selectedDate.Date);
            if (recordExists)
            {
                textBox4.Text = "Usuniêto dane z wybranego dnia";
                var student = CurrencyCon.Currencies.First(s => s.Date.Date == selectedDate.Date);
                CurrencyCon.Currencies.Remove(student);
                CurrencyCon.SaveChanges();
                return;
            }
            else
            {
                textBox4.Text = "Nie ma danych do usuniêcia";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                var sortedData = CurrencyCon.Currencies.OrderBy(c => c.Date).ToList();
                listBox1.DataSource = sortedData;
            
        }
    }
}
