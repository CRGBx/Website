using AspNetCore.ReCaptcha;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TestLinux.Models;

namespace TestLinux.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly DatabaseContext _database;
        public HomeController(ILogger<HomeController> logger , IWebHostEnvironment webHostEnvironment , DatabaseContext database)
        {
            _database = database;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }

        public IActionResult Administration()
        {
            return View();
        }

        public string encrypt(string encryptString)
        {
            string EncryptionKey = "SHISHIRSHUKLACRGBRAIPUR123456";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }

        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "SHISHIRSHUKLACRGBRAIPUR123456";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }


        public IActionResult AddNew(string msg = "")
        {
            ViewBag.Message = msg;
            var g = _database.Branches.Select(a => a.District).Distinct().ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "--- Select District---", Value = "" });
            foreach (var item in g)
            {
                items.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.District = items;

            #region newCodeAdded
            //----Added on 09-06-2022-------
            Random random = new Random();
            var s = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5);
            string characters = "*bcdefgh@#$%";
            var i = random.Next(0, characters.Length);
            s = characters[i] + s;
            var b = GenCaptcha(s);
            
            byte[] encodedPassword = new UTF8Encoding().GetBytes(s.ToString());
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded;
            ViewData["IsPostBack"] = false;
            ViewData["_viewdata"] = encrypt(DateTime.Now.Ticks.ToString());
           
            //---------------------------------------------
            #endregion
            return View();
        }

        public byte[] ImageToByte2(Bitmap img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        public byte[] GenCaptcha(string inp)
        {
            Bitmap objBitmap = new Bitmap(120, 60);
            Graphics objGraphics = Graphics.FromImage(objBitmap);
            objGraphics.Clear(Color.White);
            Random objRandom = new Random();
            objGraphics.DrawLine(Pens.Black, objRandom.Next(0, 50), objRandom.Next(10, 30), objRandom.Next(0, 200), objRandom.Next(0, 50));
            objGraphics.DrawRectangle(Pens.Blue, objRandom.Next(0, 20), objRandom.Next(0, 20), objRandom.Next(50, 80), objRandom.Next(0, 20));
            objGraphics.DrawLine(Pens.Blue, objRandom.Next(0, 20), objRandom.Next(10, 50), objRandom.Next(100, 200), objRandom.Next(0, 80));
            Brush objBrush =
                default(Brush);
            //create background style  
            HatchStyle[] aHatchStyles = new HatchStyle[]
            {
                HatchStyle.BackwardDiagonal, HatchStyle.Cross, HatchStyle.DashedDownwardDiagonal, HatchStyle.DashedHorizontal, HatchStyle.DashedUpwardDiagonal, HatchStyle.DashedVertical,
                    HatchStyle.DiagonalBrick, HatchStyle.DiagonalCross, HatchStyle.Divot, HatchStyle.DottedDiamond, HatchStyle.DottedGrid, HatchStyle.ForwardDiagonal, HatchStyle.Horizontal,
                    HatchStyle.HorizontalBrick, HatchStyle.LargeCheckerBoard, HatchStyle.LargeConfetti, HatchStyle.LargeGrid, HatchStyle.LightDownwardDiagonal, HatchStyle.LightHorizontal
            };
            //create rectangular area  
            RectangleF oRectangleF = new RectangleF(0, 0, 300, 300);
            objBrush = new HatchBrush(aHatchStyles[objRandom.Next(aHatchStyles.Length - 3)], Color.FromArgb((objRandom.Next(100, 255)), (objRandom.Next(100, 255)), (objRandom.Next(100, 255))), Color.White);
            objGraphics.FillRectangle(objBrush, oRectangleF);
            //Generate the image for captcha  
            Font objFont = new Font("Courier New", 15, FontStyle.Bold);
            //Draw the image for captcha  
            objGraphics.DrawString(inp, objFont, Brushes.Black, 20, 20);
            var c = ImageToByte2(objBitmap);
            return c;
        }
        [ValidateReCaptcha]
        [HttpPost]
        public ActionResult AddNew(Grievance g, string token,string captcha , string viewdata)
        {
            ModelState.Remove("Id");
            ModelState.Remove("AmountInvolved");
            ModelState.Remove("Recaptcha");
            if (ModelState.IsValid == false )
            {
                //ModelState.
                ViewBag.Message = "Please enter proper values";
                return RedirectToAction("AddNew", new { msg = "Please enter proper values" });
            }
            try
            {
                var tt = long.Parse(Decrypt(viewdata));
                var now = DateTime.Now.Ticks;
                var diff = now - tt;
                TimeSpan elapsedSpan = new TimeSpan(diff);
                if (elapsedSpan.TotalMinutes > 5)
                {
                    return RedirectToAction("AddNew", new { msg = "Please fill the form within 5 Minutes" });
                }

                byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha);
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                string encoded = BitConverter.ToString(hash)
                   .Replace("-", string.Empty)
                   .ToLower();

                if (encoded != token)
                {
                    return RedirectToAction("AddNew", new { msg = "Invalid Code" });
                }
                //----Added on 09-06-2022-------
                if (g != null)
                {
                    var cnt = _database.Grievances.Where(a => a.MobileNo == g.MobileNo).Count();
                    if (cnt > 10)
                    {
                        return RedirectToAction("AddNew", new { msg = "This mobile number is already registered with multiple complains." });
                    }
                    //---------------------------------------------
                    var st = String.Format("{0}{1}", g.Branch, _database.Grievances.Count());
                    g.Id = st;
                    g.RegisterDate = DateTime.Now;
                    g.Status = "Pending";
                    g.RO = _database.Branches.Find(g.Branch).RO;
                    g.Branch = _database.Branches.Find(g.Branch).BranchName;
                    g.ComplaintType = "Online";
                    g.ComplaintChannel = "Online";
                    _database.Grievances.Add(g);
                    _database.SaveChanges();
                    string s = String.Format("https://www.fast2sms.com/dev/bulkV2?authorization=iwdrsu4U3va5nAjyJtogxFChYOH9ckI7N0R1M8PDXS2ZEq6WpfvBq31iwpkogtLc7zOPMnZCKeTbxDYG&route=dlt&sender_id=CRGBHO&message=124497&variables_values={0}&flash=0&numbers={1}", g.Id, g.MobileNo);
                    HttpClient c = new HttpClient();
                    c.GetAsync(s);
                    ViewBag.Message = "Complaint Registered Succesfully";
                    return View("Registered", g);
                    //----Added on 09-06-2022-------
                }
                else
                {
                    ViewBag.Message = "Please fill the required details";
                    return View();
                }
            }
           
           
                 catch (Exception)
            {

                ViewBag.Message = "Please input proper details";
                return View();
            }
            //---------------------------------------------
        }
        public ActionResult AddContent()
        {
            return View();
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
        public ActionResult GetMain()
        {
            List<MainCategory> mainCategories = new List<MainCategory>();
            mainCategories.Add(new MainCategory { CategoryName = "CBS", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "P Segment Loans", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "SME Loans", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Agri Loans", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Deposits & KYC", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Cross Selling", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Financial Inclusion", CategoryURL = "" });
            mainCategories.Add(new MainCategory { CategoryName = "Others", CategoryURL = "" });
            return Json(mainCategories);
        }
        public ActionResult GetLink(string id)
        {
            var learnings = _database.Learnings.Where(a => a.Heading == id).ToList();
            List<MainCategory> mainCategories = new List<MainCategory>();
            foreach (var item in learnings)
            {
                
                    mainCategories.Add(new MainCategory { CategoryName = item.Address, CategoryURL = item.Link });
               
                
            }
            
            return Json(mainCategories);
        }

        public ActionResult CheckStatus(string msg = "")
        {
            ViewBag.Message = msg;

            Random random = new Random();
            var s = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 6);
            string characters = "*bcdefgh@#$%";
            var i = random.Next(0, characters.Length);
            s = characters[i] + s;
            var b = GenCaptcha(s);
            byte[] encodedPassword = new UTF8Encoding().GetBytes(s.ToString());
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded;
            ViewData["IsPostBack"] = false;
            ViewData["_viewdata"] = encrypt(DateTime.Now.Ticks.ToString());

            return View();
        }
        [HttpPost]
        public ActionResult CheckStatus(Grievance g , string token, string captcha, string viewdata)
        {
            //----Added on 09-06-2022-------
            if (g != null)
            {

                byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha);
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                string encoded = BitConverter.ToString(hash)
                   .Replace("-", string.Empty)
                   .ToLower();

                if (encoded != token)
                {
                    return RedirectToAction("CheckStatus", new { msg = "Invalid Code" });
                }
                //---------------------------------------------
                var gr = _database.Grievances.Find(g.Id);
                if (gr == null)
                {
                    return RedirectToAction("CheckStatus", new { msg = "Invalid input values" });
                }
                if (gr.MobileNo != g.MobileNo)
                {
                    return RedirectToAction("CheckStatus", new { msg = "Invalid input values" });
                }
                return View("Registered", gr);
            //----Added on 09-06-2022-------
            }
            else
            {
                ViewBag.Message = "Please fill the required details";
                return View();
            }
            //---------------------------------------------
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
        public IActionResult PageL(String Id)
        {
            ViewBag.Id = Id;
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;
            var filePath = Path.Combine(webRootPath, "Pages", Id + ".html");
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
        public IActionResult Locations()
        {
            return View();
        }
        public IActionResult Index()
        {
            _database.Users.Count();
            string webRootPath = _webHostEnvironment.WebRootPath;
            var filePath = Path.Combine(webRootPath, "Pages", "NoticeBoard.html");
            var folderMain = Path.Combine(webRootPath, "assets", "img", "mainCarousel");
            if (System.IO.File.Exists(filePath))
            {
                ViewBag.Id = filePath;
            }
            List<string> list = new List<string>();
            var d = new DirectoryInfo(folderMain);
            foreach (var item in d.GetFiles())
            {
                list.Add(item.Name);
            }
            ViewBag.Images = list;
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
