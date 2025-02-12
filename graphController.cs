using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace graph_by_using_mvc.Controllers
{
    public class graphController : Controller
    {
        // GET: graph
        public ActionResult Index()
        {
            string[] X_Axis = { "Reliance", "Tata", "HDFC", "Airtel", "ICICI", "Infosys", "SBI", "Hindustan", "ITC" };
            string[] Y_Axis = { "1256", "4001", "1708", "1700", "1254", "1891", "735", "2345", "423" };
            var bytes = new Chart(width: 1200, height: 600)
                .AddSeries(chartType: "Column", xValue: X_Axis, yValues: Y_Axis)
                .AddTitle("1 Share market price of Top 9 company")
                .SetXAxis("Company Names")
                .SetYAxis("Company share prices ")
                .GetBytes("JPG");
            return File(bytes, "Image/jpg");
        }
    }
}




//, "Bajaj" };
//, "8216" };

// string[] X_Axis = { "A", "B", "C", "D", "E", "F", "G", "H", "I" , "J" };
// string[] Y_Axis = { "1", "2", "3", "4", "5", "6", "7", "8", "9" , "10" };