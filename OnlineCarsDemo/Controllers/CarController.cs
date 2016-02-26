using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using OnlineCarsDemo.Models;
using Newtonsoft.Json;

namespace OnlineCarsDemo.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {

            OnlineCarsDemo.Models.CarsPool allCars = new OnlineCarsDemo.Models.CarsPool();

            IEnumerable<Car> listofallcars = allCars.GetPool;

            return View(listofallcars);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            OnlineCarsDemo.Models.CarsPool allCars = new OnlineCarsDemo.Models.CarsPool();

            var objCar = from c in allCars.GetPool
                         where c.ID == id
                         select c;

            return View("CarDetail", (Car)objCar.First());
        }

        [HttpPost]
        public ActionResult SendEnq(UserEnquiry UE)
        {
            if (ModelState.IsValid)
            {

                //Create a Record in Data Store

                string json = JsonConvert.SerializeObject(UE);

                string appDir = System.Web.HttpContext.Current.Server.MapPath("~");

                /* //Commented because IIS process face write permission issue. */
                //string strFileLocation = appDir + WebConfigurationManager.AppSettings[@"userEnquiries"];  
                //using (System.IO.StreamWriter file =    new System.IO.StreamWriter(@"strFileLocation", true))
                //{
                //    file.WriteLine(json);
                //}

                ViewData["CarID"] = UE.ID;
                ViewData["name"] = UE.Name;
                ViewData["email"] = UE.Email;

                return View("thanks");

            }

            OnlineCarsDemo.Models.CarsPool allCars = new OnlineCarsDemo.Models.CarsPool();

            var objCar = from c in allCars.GetPool
                         where c.ID == UE.ID
                         select c;

            return View("CarDetail", (Car)objCar.First());
        }

        // GET: Car
        public ActionResult About()
        {
            return View("About");
        }
        // GET: Car
        public ActionResult Contact()
        {
            return View("Contact");
        }

        }
    }
