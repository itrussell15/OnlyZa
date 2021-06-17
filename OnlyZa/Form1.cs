using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace OnlyZa
{

    public partial class Form1 : Form
    {
        public API_Handler api;
        //*** This is when the program is buried inside the VSCode file structure.
        string json_path = Path.Combine(
            Directory.GetCurrentDirectory(), "..", "..", "..", "data.json");

        //****This is for when the data.json is in the same folder as the program that is running.
        //string json_path = Path.Combine(
        //Directory.GetCurrentDirectory(),"data.json");

        public JArray stores;
        public string curr_store;
        public bool has_payment;

        public Form1()
        {
            InitializeComponent();
            JObject user_data = load_json(json_path);
            api = new API_Handler(user_data);
            has_payment = false;
            set_settings(user_data);   
        }

        private string format_location()
        {
            string line2 = String.Format("{0}, {1}, {2}",
                City_text.Text,
                State_text.Text,
                Zip_text.Text
                );
            return line2;
        }

        private void set_settings(JObject data)
        {
            City_text.Enabled = false;
            State_text.Enabled = false;
            Zip_text.Enabled = false;
            FName_text.Enabled = false;
            LName_text.Enabled = false;
            Address_text.Enabled = false;
            Phone_text.Enabled = false;

            City_text.Text = (string)data["customer"]["city"];
            State_text.Text = (string)data["customer"]["state"];
            Zip_text.Text = (string)data["customer"]["zip"];
            FName_text.Text = (string)data["customer"]["fname"];
            LName_text.Text = (string)data["customer"]["lname"];
            Phone_text.Text = (string)data["customer"]["phone"];
            Address_text.Text = (string)data["customer"]["address"];

            stores = api.find_stores(Address_text.Text, format_location());
            foreach (JObject store in stores)
            {

                Stores_Box.Items.Add(store["StoreID"]);
                if (store["StoreID"] == data["desired_store"])
                {
                    Stores_Box.SelectedItem = (string)store["StoreID"];
                    Stores_Box.Text = (string)store["StoreID"];
                }
            }

            MethodBox.Items.Add("Carryout");
            if (data["payments"].GetType() == new JObject().GetType())
            {
                MethodBox.Items.Add("Delivery");
                has_payment = true;
            }


            MethodBox.Text = (string)data["service_method"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("Form Loaded");
            
        }
        private JObject load_json(string json_path)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(@json_path));

            //string full_path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "data_json.json"));
            string full_path = Path.GetFullPath(@json_path);
            using (StreamReader file = File.OpenText(full_path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                return (JObject)JToken.ReadFrom(reader);
            }

        }

        private void Stores_Box_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (JObject store in stores)
            {
                if ((string)store["StoreID"] == (string)Stores_Box.Text)
                {

                    Store_info.Text = (string)store["AddressDescription"];
                    api.store = Convert.ToInt32(Stores_Box.Text);

                    if ((bool)store["ServiceIsOpen"]["Delivery"])
                    {
                        string min =
                            (string)store["ServiceMethodEstimatedWaitMinutes"]["Delivery"]["Min"];

                        string max =
                            (string)store["ServiceMethodEstimatedWaitMinutes"]["Delivery"]["Max"];

                        Delivery_time.Text =
                            String.Format("{0} to {1} minutes", min, max);

                    }
                    else
                    {
                        Delivery_time.Text = "Delivery Unavailable";
                    }
                    if((bool)store["ServiceIsOpen"]["Carryout"])
                    {
                        string min =
                            (string)store["ServiceMethodEstimatedWaitMinutes"]["Carryout"]["Min"];

                        string max =
                            (string)store["ServiceMethodEstimatedWaitMinutes"]["Carryout"]["Max"];

                        Carryout_time.Text =
                            String.Format("{0} to {1} minutes", min, max);
                        Order_button.Enabled = true;
                        Store_Status.BackColor = Color.DarkGreen;
                        Store_Status_label.Text = "Store Open";

                    }
                    else
                    {
                        Carryout_time.Text = "Service Unavailable";
                        Order_button.Enabled = false;
                        Store_Status.BackColor = Color.DarkRed;
                        Store_Status_label.Text = "Store Closed";
                    }

                }
            }
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            JObject resp = api.Price_Order(Convert.ToInt32(Stores_Box.Text));
            Confirmation confirm = new Confirmation(api, resp, has_payment);
            confirm.ShowDialog();
            this.Close();
        }

    }
}
