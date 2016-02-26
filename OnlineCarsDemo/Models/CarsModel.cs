using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Web.Configuration;

namespace OnlineCarsDemo.Models
{
    public class Car
    {
        private Int32 m_ID;
        private string m_model;
        private string m_make;
        private string m_year;
        private string m_priceType;
        private string m_price;
        private string m_DapPrice;
        private string m_EGCPrice;
        private string m_email;
        private string m_contact_name;
        private string m_phone;
        private string m_dealerABN;
        private string m_comments;
        private string m_imageUrl;


        public Int32 ID
        {
            get
            {
                return m_ID;
            }
            set
            {
                m_ID = value;
            }
        }

        public string Model
        {
            get
            {
                return m_model;
            }
            set
            {
                m_model = value;
            }
        }


        public string Make
        {
            get
            {
                return m_make;
            }
            set
            {
                m_make = value;
            }
        }

        public string Year
        {
            get
            {
                return m_year;
            }
            set
            {
                m_year = value;
            }
        }


        public string PriceType
        {
            get
            {
                return m_priceType;
            }
            set
            {
                m_priceType = value;
            }
        }

        public string Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }

        public string DapPrice
        {
            get
            {
                return m_DapPrice;
            }
            set
            {
                m_DapPrice = value;
            }
        }

        public string EGCPrice
        {
            get
            {
                return m_EGCPrice;
            }
            set
            {
                m_EGCPrice = value;
            }
        }

        public string Email
        {
            get
            {
                return m_email;
            }
            set
            {
                m_email = value;
            }
        }
        public string ContactName
        {
            get
            {
                return m_contact_name;
            }
            set
            {
                m_contact_name = value;
            }
        }

        public string Phone
        {
            get
            {
                return m_phone;
            }
            set
            {
                m_phone = value;
            }
        }

        public string DealerABN
        {
            get
            {
                return m_dealerABN;
            }
            set
            {
                m_dealerABN = value;
            }
        }

        public string Comments
        {
            get
            {
                return m_comments;
            }
            set
            {
                m_comments = value;
            }
        }

        public string ImageURL
        {
            get
            {
                return m_imageUrl;
            }
            set
            {
                m_imageUrl = value;
            }
        }
    }

    public class CarsPool
    {
        private IEnumerable<Car> m_listofCars;

        public CarsPool()
        {

            //Read the JSON File car_data.json
            string appDir = System.Web.HttpContext.Current.Server.MapPath("~");
            string strFileLocation = appDir + WebConfigurationManager.AppSettings[@"jsonCarsList"];
            string json = new StreamReader(strFileLocation).ReadToEnd();
            m_listofCars = JsonConvert.DeserializeObject<IList<Car>>(json);


        }

        public IEnumerable<Car> GetPool
        {
            get
            {
                return m_listofCars;
            }
        }
    }

}