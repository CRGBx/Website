using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using TestLinux.Models;
using TestLinux.Services;

namespace TestLinux.Controllers
{
    public class VisitController : Controller
    {
        private readonly ILogger<VisitController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly DatabaseContext _database;
        private IConfiguration _config;
        public VisitController(ILogger<VisitController> logger , IWebHostEnvironment webHostEnvironment , DatabaseContext database , IConfiguration config)
        {
            _database = database;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _config = config;
        }

        public string Login(string userId , string Password)
        {
            var c = _database.EmployeeMasters.Where(a => a.UserId == userId && a.Password == Password).FirstOrDefault();
            if (!(c is  null))
            {
                var jwt = new JwtService(_config);
                var token = jwt.GenerateSecurityToken(c);
                return token;
            }
            return "Failed";
        }

        EmployeeMaster getEmp(string token) {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwt = new JwtSecurityToken(token);
                EmployeeMaster employeeMaster = new EmployeeMaster();
                employeeMaster.BranchCode = jwt.Claims.FirstOrDefault(a => a.Type == ClaimTypes.PostalCode).Value;
                employeeMaster.UserId = jwt.Claims.FirstOrDefault(a => a.Type == "unique_name").Value;
                employeeMaster.Designation = jwt.Claims.FirstOrDefault(a => a.Type == "role").Value;
                employeeMaster.Role1 = jwt.Claims.FirstOrDefault(a => a.Type == "given_name").Value;
                employeeMaster.Password = token;
                return employeeMaster;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
        public IActionResult GetBranches(string x)
        {
            if (x == "HO")
            {
                ViewBag.Branches = null;
                ViewBag.Data1 = "HO";
            }
            else if (x == "NW1")
            {
                ViewBag.Branches = null;
                ViewBag.Data1 = "NW1";
            }
            else if (x == "NW2")
            {
                ViewBag.Branches = null;
                ViewBag.Data1 = "NW2";
            }
            else
            {
                var branches = _database.Branches.Where(a => a.RO == x).ToList();
                ViewBag.Branches = branches;
            }
                
            return View();
        }

        public IActionResult BranchPerformance()
        {
            List<string> DataPoints = new List<string>();
            DataPoints.Add("Mar-20");
            DataPoints.Add("Mar-21");
            DataPoints.Add("Sep-21");
            DataPoints.Add("Nov-21");
            DataPoints.Add("30/12/21");
            ViewBag.DataPoints = DataPoints;
            var x = _database.BranchPerformances.Find("HO");
            return View(x);
        }
        [HttpPost]
        public IActionResult BranchPerformance(string Region , string Branch)
        {
            List<string> DataPoints = new List<string>();
            DataPoints.Add("Mar-20");
            DataPoints.Add("Mar-21");
            DataPoints.Add("Sep-21");
            DataPoints.Add("Nov-21");
            DataPoints.Add("30/12/21");
            ViewBag.DataPoints = DataPoints;
            var x = _database.BranchPerformances.Find(Branch);
            return View(x);
        }
        public IActionResult BCVisitSummary()
        {
            ViewBag.PostBack = false;
            return View();
        }
        [HttpPost]
        public IActionResult BCVisitSummary(string region, DateTime fromDate , DateTime toDate)
        {
            ViewBag.PostBack = true;
            var x = _database.CSPVisits.Include(a=> a.Csp).Include(a=> a.EmployeeMaster).Include(a=> a.Csp.BranchMaster).Where(a => a.Csp.BranchMaster.RO == region && a.VisitDate >= fromDate && a.VisitDate <= toDate).ToList();   
            ViewBag.Data = x;
            return View();
        }
        public IActionResult BCVisitCount()
        {
            ViewBag.PostBack = false;
            return View();
        }
        [HttpPost]
        public IActionResult BCVisitCount(string region, DateTime fromDate, DateTime toDate)
        {
            ViewBag.PostBack = true;
            var x = _database.CSPVisits.Include(a => a.Csp).Include(a => a.EmployeeMaster).Include(a => a.Csp.BranchMaster).Where(a => a.Csp.BranchMaster.RO == region && a.VisitDate >= fromDate && a.VisitDate <= toDate).GroupBy(a=> a.EmployeeMaster.EmployeeName).Select(g => new {Key = g.Key , Count = g.Count() }).ToDictionary(k=> k.Key,i=> i.Count);
            ViewBag.Data = x;
            return View();
        }
        public IActionResult PreInspectionList() { 
            List<PreInspection> list = new List<PreInspection>();
            return View(list);
        }

        [HttpPost]
        
        public IActionResult PreInspectionList(string ApplicationId)
        {
            var c = _database.PreInspection.Where(a=> a.ApplicationId == ApplicationId).ToList();
            return View(c);
        }

        public IActionResult CSPList(string token , string lat , string loc_long)
        {
            EmployeeMaster employeeMaster = getEmp(token);
            ViewBag.lat = lat;
            ViewBag.loc_long = loc_long;
            return View(employeeMaster);
        }
       
        public IActionResult EmployeeInfo(string token)
        {
            EmployeeMaster employeeMaster = getEmp(token);
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            int Year = 0;
            if (DateTime.Now.Month > 3)
            {
                Year = DateTime.Now.Year;
            }
            else
            {
                Year = DateTime.Now.Year - 1;
            }
            var firstDayOfFY = new DateTime(Year, 4, 1);
            int totalVisits = _database.CSPVisits.Where(a=> a.UserId == employeeMaster.UserId && a.VisitDate >= firstDayOfFY).Count();
            
            int visitCurrentMonth = _database.CSPVisits.Where(a => a.UserId == employeeMaster.UserId && a.VisitDate >= firstDayOfMonth).Count();
            Dashboard dashboard = new Dashboard();
            dashboard.CSPVisitsCM = visitCurrentMonth;
            dashboard.TotalCSPVisitsFY = totalVisits;
            dashboard.employee = employeeMaster;
            return Json(dashboard);
        }
        public IActionResult ViewList(string token, string lat, string loc_long)
        {
            EmployeeMaster employeeMaster = getEmp(token);
            var CSPs = _database.Csps.Where(a=> a.BrCode == int.Parse(employeeMaster.BranchCode).ToString()).ToList();
            ViewBag.CSPs = CSPs;
            ViewBag.lat = lat;
            ViewBag.loc_long = loc_long;
            return View(employeeMaster);
        }
        public IActionResult AddNewInspection(string token, string lat, string loc_long)
        {
            EmployeeMaster employeeMaster = getEmp(token);
            employeeMaster.EmployeeName = _database.EmployeeMasters.Find(employeeMaster.UserId).EmployeeName;
            ViewBag.Location_lat = String.Format("{0},{1}",lat,loc_long);
            ViewBag.Token = token;
            return View(employeeMaster);
        }
        [HttpPost]
        public ActionResult AddNewInspection(PreInspection g, string token)
        {
            PreInspection visit = new PreInspection();
            g.CopyAllTo(visit);
            visit.SystemLogDate = DateTime.Now;
            
            _database.PreInspection.Add(visit);
            _database.SaveChanges();
            return RedirectToAction("InspectionStart", new { VisitId = visit.Id, token = token });
        }
        public IActionResult AddNew(string token , string BCId, string lat, string loc_long)
        {
            EmployeeMaster employeeMaster = getEmp(token);
            CSPVisit CspVisit = new CSPVisit();
            CspVisit.UserId = employeeMaster.UserId;
            CspVisit.CSPId = BCId;
            CspVisit.Status = "Pending";
            CspVisit.VisitDate = DateTime.Now;
            CspVisit.VisitRemarks = token;
            CspVisit.Location_lat = lat;
            CspVisit.Location_long = loc_long;
            return View(CspVisit);
        }
        [HttpPost]
        public ActionResult AddNew(CSPVisit g,string token, string lat, string loc_long)
        {
            CSPVisit visit = new CSPVisit();
            visit.UserId = g.UserId;
            visit.VisitDate = g.VisitDate;
            visit.SystemLogDate = DateTime.Now;
            visit.Status = "Pending";
            visit.CSPId = g.CSPId;
            visit.Location_lat = lat;
            visit.Location_long = loc_long;
            _database.CSPVisits.Add(visit);
            _database.SaveChanges();
            return RedirectToAction("VisitStart", new {VisitId = visit.Id , token = token});
        }
        public ActionResult VisitStart(int VisitId , string token)
        {
            var ValueStatements = _database.CSPValueStatements.ToList();
            ViewBag.Data = ValueStatements;
            ViewBag.VisitId = VisitId;
            ViewBag.Token = token;
            return View();
        }
        public ActionResult InspectionStart(int VisitId, string token)
        {
            var visitType = _database.PreInspection.Find(VisitId).Status;
            var ValueStatements = _database.PreInspectionValueStatements.Where(a=> a.Status == visitType).ToList();
            ViewBag.Data = ValueStatements;
            ViewBag.VisitId = VisitId;
            ViewBag.Token = token;
            return View();
        }
        [HttpPost]
        public IActionResult InspectionStart(int VisitId, IFormCollection formCollection, string token)
        {
            try
            {



                foreach (var item in formCollection)
                {
                    int key = 0;
                    int.TryParse(item.Key, out key);
                    if (key > 0)
                    {
                        PreVisitRemark visit = new PreVisitRemark();
                        visit.VisitId = VisitId;
                        visit.RemarksVisitingOfficial = item.Value;
                        visit.ValueStatementId = int.Parse(item.Key);
                        visit.Status = "Entered";
                        visit.RemarksVerifyingOfficial = "";
                        _database.PreIsnpectionRemarks.Add(visit);


                    }


                }
                foreach (var item in formCollection.Files)
                {

                    var uniqueFileName = GetUniqueFileName(item.FileName);
                    var uploads = Path.Combine(_webHostEnvironment.WebRootPath, "uploadedImages");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    item.CopyTo(new FileStream(filePath, FileMode.Create));
                    PreVisitRemark visit = new PreVisitRemark();
                    visit.VisitId = VisitId;
                    visit.RemarksVisitingOfficial = uniqueFileName;
                    visit.ValueStatementId = int.Parse(item.Name);
                    visit.Status = "File";
                    visit.RemarksVerifyingOfficial = "";
                    _database.PreIsnpectionRemarks.Add(visit);

                }
                _database.SaveChanges();
                ViewBag.Result = "OK";
                return View("Result");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                ViewBag.Result = "BAD";
                return View("Result");
            }

        }
        public ActionResult VisitList()
        {
            var visits1 = _database.CSPVisits.Where(a=> a.Status == "Pending").OrderByDescending(a=> a.VisitDate).ToList();
            List<CSPVisitView> visits = new List<CSPVisitView>();
            foreach (var v in visits1)
            {
                CSPVisitView x = new CSPVisitView();
                v.CopyAllTo(x);
                x.EmployeeDetails = _database.EmployeeMasters.Find(v.UserId);
                x.BCDetails = _database.Csps.Find(v.CSPId);
                visits.Add(x);
            }
            return View(visits);
        }
        public ActionResult ReportPreInspection(int Id)
        {
            var visit = _database.PreInspection.Find(Id);
            var visitReport = _database.PreIsnpectionRemarks.Where(a => a.VisitId == Id).ToList();
            var empl = _database.EmployeeMasters.Find(visit.UserId);
            
            var visitReportStatment = new List<PreVisitWithStatement>();
            foreach (var v in visitReport)
            {
                var x = new PreVisitWithStatement();
                v.CopyAllTo(x);
                x.ValueStatement = _database.CSPValueStatements.Find(v.ValueStatementId).Statement;
                visitReportStatment.Add(x);
            }
            var visits = new PreVisitReport();
            visits.EmployeeDetails = empl;
            
            visits.VisitRemarks = visitReportStatment;
            visits.VisitDetails = visit;
            return View(visits);
        }
        public ActionResult ReportCSP(int Id)
        {
            var visit = _database.CSPVisits.Find(Id);
            var visitReport = _database.VisitRemarks.Where(a => a.VisitId == Id).ToList();
            var empl = _database.EmployeeMasters.Find(visit.UserId);
            var BCDetails = _database.Csps.Find(visit.CSPId);
            var visitReportStatment = new List<CSPVisitWithStatement>();
            foreach (var v in visitReport)
            {
                var x = new CSPVisitWithStatement();
                v.CopyAllTo(x);
                x.ValueStatement = _database.CSPValueStatements.Find(v.ValueStatementId).Statement;
                visitReportStatment.Add(x);
            }
            var visits = new CPSVisitReport();
            visits.EmployeeDetails = empl;
            visits.BCDetails = BCDetails;
            visits.VisitRemarks = visitReportStatment;
            visits.VisitDetails = visit;
            return View(visits);
        }
        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
        [HttpPost]
        public IActionResult VisitStart(int VisitId , IFormCollection formCollection , string token)
        {
            try {
                
                
            
                foreach (var item in formCollection)
                {
                    int key = 0;
                    int.TryParse(item.Key,out key);
                    if (key > 0)
                    {
                        VisitRemark visit = new VisitRemark();
                        visit.VisitId = VisitId;
                        visit.RemarksVisitingOfficial = item.Value;
                        visit.ValueStatementId = int.Parse(item.Key);
                        visit.Status = "Entered";
                        visit.RemarksVerifyingOfficial = "";
                        _database.VisitRemarks.Add(visit);
                       
                        
                    }
                   

                }
                foreach (var item in formCollection.Files)
                {

                    var uniqueFileName = GetUniqueFileName(item.FileName);
                    var uploads = Path.Combine(_webHostEnvironment.WebRootPath, "uploadedImages");
                    var filePath = Path.Combine(uploads, uniqueFileName);
                    item.CopyTo(new FileStream(filePath, FileMode.Create));
                    VisitRemark visit = new VisitRemark();
                    visit.VisitId = VisitId;
                    visit.RemarksVisitingOfficial = uniqueFileName;
                    visit.ValueStatementId = int.Parse(item.Name);
                    visit.Status = "File";
                    visit.RemarksVerifyingOfficial = "";
                    _database.VisitRemarks.Add(visit);
                    
                }
                _database.SaveChanges();
                ViewBag.Result = "OK";
                return View("Result");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;   
                ViewBag.Result = "BAD";
               return View("Result");
            }
            
        }
        public IActionResult GetBranch(string d)
        {
            var g = _database.Branches.Where(a => a.District == d).ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var item in g)
            {
                items.Add(new SelectListItem { Text = item.BranchName, Value = item.BrCode });
            }
            return Json(items);
        }
        public ActionResult CheckLogin(string UserName , string Password)
        {
            LoginResult loginResult = new LoginResult();
            loginResult.StatusMessage = "OK";
            loginResult.UserName = "Shishir Shukla";
            return Json(loginResult);
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
