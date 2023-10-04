using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestLinux.Models;

namespace TestLinux.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly DatabaseContext _database;
        public AttendanceController(ILogger<HomeController> logger , IWebHostEnvironment webHostEnvironment , DatabaseContext database)
        {
            _database = database;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
       
        public async Task<IActionResult> SendOTPAsync(string mnumber)
        {
            Random random = new Random();
            var otp = random.Next(1000, 9999);
            var otps = new OTP();
            string m = String.Format("https://www.fast2sms.com/dev/bulkV2?authorization=iwdrsu4U3va5nAjyJtogxFChYOH9ckI7N0R1M8PDXS2ZEq6WpfvBq31iwpkogtLc7zOPMnZCKeTbxDYG&route=dlt&sender_id=CRGBHO&message=130046&variables_values=Attendance%7C{1}%7C&flash=0&numbers={0}", mnumber,otp.ToString());
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(m);
            if (response.IsSuccessStatusCode)
            {
                otps.Application = "Attendance";
                otps.OTPValue = otp.ToString();
                otps.MobileNumber = mnumber;
                otps.IsUsed = "False";
                _database.OTPs.Add(otps);
                _database.SaveChanges();
                return Json(new LoginResult { StatusMessage = "OK", UserName = otp.ToString() });
            }
            

            return Json(new LoginResult { StatusMessage = "Fail" , UserName = response.ReasonPhrase });
        }
        public ActionResult VerifyLogin(string mnumber)
        {
            var emp = _database.Employee.Find(mnumber);
            if (emp != null)
            {
                return Json(new LoginResult { StatusMessage = "OK", UserName = emp.UserName });
            }


            return Json(new LoginResult { StatusMessage = "Fail", UserName = "" });
        }
        public ActionResult VerifyOTP(string mnumber , string otp , string app)
        {
            var z = _database.OTPs.Where(a => a.MobileNumber == mnumber && a.OTPValue == otp && a.Application == app && a.IsUsed == "False").FirstOrDefault();
            if (z is null)
            {
                return Json(new LoginResult { StatusMessage = "Fail", UserName = "Invalid OTP" });
            }
            else
            {
                var u = _database.Employee.Find(mnumber);
                return Json(new LoginResult { StatusMessage = "OK", UserName = u.UserName });
            }



            
        }
       
        public ActionResult AddNew(string mnumber , string fordate , string attend , string remarks , string LatLong)
        {
            var k = _database.Attendances.Where(a => a.MobileNumber == mnumber && a.ForDate == DateTime.ParseExact(fordate, "dd-MM-yyyy", CultureInfo.InvariantCulture)).FirstOrDefault();
            if (k != null)
            {
                _database.Entry(k).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _database.SaveChanges();
            }
            var attendanceProfie = new AttendanceProfie();
            attendanceProfie.MarkDate = DateTime.Now;
            attendanceProfie.MobileNumber = mnumber;
            attendanceProfie.ForDate = DateTime.ParseExact(fordate,"dd-MM-yyyy", CultureInfo.InvariantCulture);
            attendanceProfie.Remarks = remarks;
            attendanceProfie.Attendance = attend;
            attendanceProfie.LatLong = LatLong;
            _database.Attendances.Add(attendanceProfie);
            _database.SaveChanges();
            return Json(new LoginResult { StatusMessage = "OK", UserName = "Attendance Marked" });
        }
        public ActionResult ViewAtt(string mnumber)
        {
            var x = _database.Attendances.Where(a => a.MobileNumber == mnumber).ToList();
            return View(x);
        }
        public IActionResult AttendanceList()
        {
            List<AttendanceOutput> o = new List<AttendanceOutput>();
            return View(o);
        }
        [HttpPost]
        public IActionResult AttendanceList(DateTime d)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("09901", "Bilaspur");
            dict.Add("09902", "Raigarh");
            dict.Add("09903", "Jagdalpur");
            dict.Add("09904", "Raipur");
            dict.Add("09905", "Dhamtari");
            dict.Add("09906", "Korba");
            dict.Add("09907", "Ambikapur");
            dict.Add("09908", "Baikunthpur");
            dict.Add("09909", "Rajnandgaon");
            dict.Add("09910", "Durg");
            List<AttendanceOutput> o = new List<AttendanceOutput>();

            var g = _database.Attendances.Where(a => a.ForDate == d).Join(_database.Employee, a => a.MobileNumber, b => b.MobileNumber, (a, b) => new { Attendance = a, Employee = b }).ToList();
            foreach (var item in g)
            {
                AttendanceOutput x = new AttendanceOutput();
                x.Attendance = item.Attendance.Attendance;
                x.EmpName = item.Employee.UserName;
                x.RegionCode = item.Employee.Posting;
                x.Remarks = item.Attendance.Remarks;
                x.LatLong = item.Attendance.LatLong;
                x.ForDate = item.Attendance.ForDate.ToShortDateString();
                x.MarkDate = item.Attendance.MarkDate;
                string s;
                dict.TryGetValue(x.RegionCode, out s);
                x.NetWorkName = s;
                o.Add(x);
            }
            return View(o);
        }
        public ActionResult CheckLogin(string UserName , string Password)
        {
            LoginResult loginResult = new LoginResult();
            loginResult.StatusMessage = "OK";
            loginResult.UserName = "Shishir Shukla";
            return Json(loginResult);
        }
        public ActionResult GetMain()
        {
            List<MainCategory> mainCategories = new List<MainCategory>();
            mainCategories.Add(new MainCategory { CategoryName = "CBS", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "P-Loans", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "SME Loans", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Deposits", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Financial Inclusion", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Cross Selling", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Other Matters", CategoryURL = "" });
            return Json(mainCategories);
        }
        public ActionResult GetLink(string id)
        {
            List<MainCategory> mainCategories = new List<MainCategory>();
            mainCategories.Add(new MainCategory { CategoryName = "Repayment Schedules in CBS", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            mainCategories.Add(new MainCategory { CategoryName = "P-Loans", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            mainCategories.Add(new MainCategory { CategoryName = "SME Loans", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            mainCategories.Add(new MainCategory { CategoryName = "Deposits", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            mainCategories.Add(new MainCategory { CategoryName = "Financial Inclusion", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            mainCategories.Add(new MainCategory { CategoryName = "Cross Selling", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            mainCategories.Add(new MainCategory { CategoryName = "Other Matters", CategoryURL = "http://cgbank.in:5000/Home/Page/IT" });
            return Json(mainCategories);
        }

        public ActionResult CheckStatus()
        {
            ViewBag.Message = "";

            return View();
        }
        [HttpPost]
        public ActionResult CheckStatus(Grievance g)
        {
            var gr = _database.Grievances.Find(g.Id);
            if (gr.MobileNo != g.MobileNo)
            {
                ViewBag.Message = "Mobile Number / Email & Grievance Id do not match , please enter correct Id & Mobile Number / Email";
                return View();
            }
            return View("Registered", gr);
        }

        public IActionResult Page(String Id)
        {
            ViewBag.Id = Id;
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            var filePath = Path.Combine(webRootPath, "Pages",Id + ".html");
            if (System.IO.File.Exists(filePath))
            {
                ViewBag.Id = filePath;
            }
            else
            {
                ViewBag.Id = Path.Combine(webRootPath, "Pages", "Demo.html"); ;
            }
            
            return View();
        }
        public IActionResult TieUps()
        {
            return View();
        }
        public IActionResult Index()
        {
            _database.Users.Count();
            string webRootPath = _webHostEnvironment.WebRootPath;
            var filePath = Path.Combine(webRootPath, "Pages", "NoticeBoard.html");
            if (System.IO.File.Exists(filePath))
            {
                ViewBag.Id = filePath;
            }
            return View();
        }
        [HttpPost()]
        public IActionResult BranchLocator(string query)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
