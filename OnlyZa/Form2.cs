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
        public JObject resp;
        public bool has_payment;

        public Confirmation(API_Handler api_in, JObject resp_in, bool payment)
        {
            api = api_in;
            has_payment = payment;
            resp = resp_in;

            InitializeComponent();
            if (resp_in != null)
            { 
                total_price.Text = "$" + resp_in["Order"]["Amounts"]["Payment"];
                resp = resp_in;
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
            //api.Place_Order(resp, has_payment);
            JObject final_resp = api.Place_Order(resp, has_payment);
            if (final_resp != null)
            {
                MessageBox.Show("Order Placed!");
            }
            else
            {
                MessageBox.Show("Something went wrong.. :(");
            }
            Debug.WriteLine(final_resp);
            this.Close();

        }
    }
}
