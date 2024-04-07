using System.Drawing.Text;
using System.Text;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RealEstate_Price_Prediction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private async void EvaluateButton_Click(object sender, EventArgs e)
        {
            if (ValidForm())
            {
                int bath = int.Parse(BathroomTextBox.Text);
                int bhk = int.Parse(BhkTextBox.Text);
                int balcony = int.Parse(BalconyTextBox.Text);
                double total_sqmt = double.Parse(TotalSqmtTextBox.Text);
                string location = LocationTextBox.Text;
                Specifications data = new Specifications(bath, balcony, bhk, total_sqmt, location);
                string url = "http://127.0.0.1:5000/process_data";

                string jsonData = $"{{\"Specifications\": [{{ \"Bathrooms\": {bath} }}, {{ \"Bhk\": {bhk} }}, {{ \"Balcony\": {balcony} }}, {{ \"TotalSqmt\": {total_sqmt:F2} }}, {{ \"Location\": \"{location}\" }}]}}";  // Format totalSqmt with 2 decimal places;

                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        dynamic responseContent = JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
                        if (responseContent.predicted_price != null)
                        {
                            double price = responseContent.predicted_price;
                            OutputLabel.Text = $"Predicted_Price is {price} lakh";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Failed to process data: " + response.StatusCode); // Assigning error message to OutputTextBox
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the correct format");
            }

        }
        private bool ValidForm()
        {
            bool output = true;
            int bath = 0;
            int bhk = 0;
            int balcony = 0;
            double totalSqmt = 0.0;

            bool Validbath = int.TryParse(BathroomTextBox.Text, out bath);
            bool Validbhk = int.TryParse(BhkTextBox.Text, out bhk);
            bool Validbalcony = int.TryParse(BalconyTextBox.Text, out balcony);
            bool ValidtotalSqmt = double.TryParse(TotalSqmtTextBox.Text, out totalSqmt);
            if (Validbath != true)
            {
                output = false;
            }
            if (bath < 1 || bath > 16)
            {
                output = false;
            }
            if (Validbhk != true)
            {
                output = false;
            }
            if (bhk < 1 || bhk > 16)
            {
                output = false;
            }
            if (Validbalcony != true)
            {
                output = false;
            }
            if (balcony < 0 || balcony > 3)
            {
                output = false;
            }
            if (ValidtotalSqmt != true)
            {
                output = false;

            }
            if (totalSqmt < 60 || totalSqmt > 2787.09)
            {
                output = false;
            }
            return output;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}