using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace OnlyZa
{
    public class API_Handler
    {
        RestClient client = new RestClient("https://order.dominos.com");
        RestClient httpbin = new RestClient("https://httpbin.org");
        public Urls url;
        public JObject user_data;
        public string store;

        public API_Handler(JObject data)
        {
            Debug.WriteLine("API Caller Initialized");
            url = new Urls();
            user_data = data;
        }

        public JArray find_stores(string formatted_string, string address)
        {

            string api_string = url.Find(formatted_string, address);
            JObject resp = Get(api_string);
            return (JArray)resp["Stores"];
        }

        public JObject get_menu()
        {
            string api_string = url.Menu(store);
            return Get(api_string);

        }

        public JObject prep_order(string current_store, bool add_coupons)
        {
            Order order = new Order((string)user_data["service_method"]);
            if (add_coupons)
            {
                Coupon coupon_details = new Coupon((string)user_data["coupon_code"]);
                order.Coupons.Add(coupon_details.toJson());
            }

            JObject from_menu = (JObject)get_menu()["Variants"][(string)user_data["Product"]["code"]];
            Product product = new Product(from_menu, (JObject)user_data["Product"]["Options"]);
            order.Products.Add(product.toJson());

            Address address = new Address(user_data);
            order.Address = address.toJson();
            order.FirstName = (string)user_data["customer"]["fname"];
            order.LastName = (string)user_data["customer"]["lname"];
            order.Phone = (string)user_data["customer"]["phone"];
            order.StoreID = current_store;

            return order.toJson();
        }

        public Order add_payment(Order order)
        {
            Debug.WriteLine("Payment information added to order");
            order.Payments.Add(user_data["payments"]);
            return order;
        }

        public JObject Price_Order(string current_store, bool add_coupons = true)
        {
            JObject order = prep_order(current_store, add_coupons);
            return Post(url.Price, order);
        }

        public void Place_Order(JObject data, bool need_payment)
        {
            // Add payment information right before that order is to be processed.
            // Will need to include the pricing amount before placing the order.
            if (need_payment)
            {
                Debug.WriteLine("Payment Information Added");
                Payment payment = new Payment((JObject)user_data["payments"],
                    Math.Round((float)data["Order"]["Amounts"]["Payment"], 2));
                
                JArray data_payment = (JArray)data["Order"]["Payments"];
                //data_payment["amount"] = data["Order"]["Amounts"][0]["Payment"];
                data_payment.Add(payment.toJson());
            }
            Debug.WriteLine(data);

            //return Post(url.Place, data);
        }

        private JObject Get(string endpoint)
        {
            var request = new RestRequest(endpoint);
            var response = client.Get(request);
            return (JObject)JsonConvert.DeserializeObject(response.Content);
        }

        private JObject Post(string endpoint, JObject data)
        {

            var request = new RestRequest(endpoint);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            request.AddJsonBody(json);
            request.AddHeader("Referer", "https://order.dominos.com/en/pages/order/");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("char", "utf-8");
            var response = client.Post(request);
            Debug.WriteLine(response.StatusCode.GetType());
            //Debug.WriteLine(JsonConvert.DeserializeObject(response.Content));
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return (JObject)JsonConvert.DeserializeObject(response.Content);
            }
            else
            {
                return null;
            }

        }

        public class Urls
        {
            private readonly string find_url;
            private readonly string menu_url;
            public readonly string Price = "/power/price-order";
            public readonly string Place = "/power/place-order";
            public readonly string Validate = "/power/validate-order";

            public Urls()
            {
                find_url = "/power/store-locator?s={0}&c={1}&type={2}";
                menu_url = "/power/store/{0}/menu?lang=en&structured=true";
            }

            public string Find(string s1, string s2)
            {
                return String.Format(find_url, s1, s2, "Carryout");
            }

            public string Menu(string s1)
            {
                return String.Format(menu_url, s1);
            }
        }

        public class Order
        {
            public JObject Address;
            public JArray Coupons;
            public string CustomerID;
            public string Extension;
            public string OrderChannel;
            public string OrderID;
            public bool NoCombine;
            public string OrderMethod;
            public string OrderTaker;
            public JArray Payments;
            public JArray Products;
            public string Market;
            public string Currency;
            public string ServiceMethod;
            public JObject Tags;
            public string Version;
            public string LanguageCode;
            public string SourceOrganizationURI;
            public JObject Partners;
            public bool NewUser;
            public JObject metaData;
            public JObject Amounts;
            public string BusinessDate;
            public string EstimatedWaitMinutes;
            public string PriceOrderTime;
            public JObject AmountsBreakdown;
            public string FirstName;
            public string LastName;
            public string Phone;
            public string StoreID; 

            public Order(string service_method)
            {
                Coupons = new JArray();
                CustomerID = "";
                Extension = "";
                OrderChannel = "OLO";
                OrderID = "";
                NoCombine = true;
                OrderMethod = "Web";
                OrderTaker = null;
                Version = "1.0";
                ServiceMethod = service_method;
                Tags = new JObject();
                Payments = new JArray();
                Products = new JArray();
                Market = "";
                Currency = "";
                LanguageCode = "en";
                SourceOrganizationURI = "order.dominos.com";
                Partners = new JObject();
                NewUser = true;
                metaData = new JObject();
                Amounts = new JObject();
                BusinessDate = "";
                EstimatedWaitMinutes = "";
                PriceOrderTime = "";
                AmountsBreakdown = new JObject();
            }

            public JObject toJson()
            {
                return new JObject(new JProperty("Order", JObject.FromObject(this)));
            }
        }

        private class Coupon 
        {
            public string Code;
            public int Qty;
            public bool IsBelowMinimumOrderAmount;
            public bool IsBelowMinimumPaymentAmount;

            public Coupon(string code)
            {
                Code = code;
                Qty = 1;
                IsBelowMinimumOrderAmount = false;
                IsBelowMinimumPaymentAmount = false;
            }
            public JObject toJson()
            {
                return JObject.FromObject(this);
            }
        }

        private class Product
        {
            public JObject main;

            public Product(JObject from_menu, JObject options, int qty = 1)
            {
                main = from_menu;

                main.Add("AutoRemove", false);
                main.Add("Qty", qty);
                main.Add("ID", 1);
                main.Add("isNew", true);
                main.Add("Options", options);

            }
            public JObject toJson()
            {
                return JObject.FromObject(main);
            }
        }

        private class Address
        {
            public string Street;
            public string City;
            public string Region;
            public string PostalCode;
            public string Type;

            public Address(JObject data)
            {
                Street = (string)data["customer"]["address"];
                City = (string)data["customer"]["city"];
                Region = (string)data["customer"]["state"];
                PostalCode = (string)data["customer"]["zip"];
                Type = (string)data["customer"]["type"];

            }

            public JObject toJson()
            {
                return JObject.FromObject(this);
            }

        }

        private class Payment
        {
            public string type;
            public double amount;
            public double tipAmount;
            public string number;
            public string cardType;
            public string expiration;
            public string securityCode;
            public string postalCode;

            public Payment(JObject card_info, double price)
            {
                type = "CreditCard";
                amount = price;
                tipAmount = 0.0;
                number = (string)card_info["number"];
                cardType = (string)card_info["cardType"];
                expiration = (string)card_info["expiration"];
                securityCode = (string)card_info["securityCode"];
                postalCode = (string)card_info["postalCode"];
            }
            public JObject toJson()
            {
                return JObject.FromObject(this);
            }

        }

    }
}
