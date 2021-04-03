using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace OnlyZa
{
    public partial class Confirmation : Form
    {

        public API_Handler api;
        public JObject resp_in;

        public Confirmation(API_Handler api_in, JObject resp_in)
        {
            api = api_in;

            InitializeComponent();
            if (resp_in != null)
            {
                Debug.WriteLine(resp_in);

                total_price.Text = "$" + resp_in["Order"]["Amounts"]["Payment"];
            }
            else
            {
                total_price.Text = "Something went wrong...";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Confirmation Screen Loaded");
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void continue_button_Click(object sender, EventArgs e)
        {

            JObject resp = api.Place_Order(resp_in);
            if (resp != null)
            {
                MessageBox.Show("Order Placed!");
            }
            else
            {
                MessageBox.Show("Something went wrong.. :(");
            }
            this.Close();

        }
    }
}
