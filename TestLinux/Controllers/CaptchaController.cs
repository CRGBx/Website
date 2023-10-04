using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using Microsoft.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TestLinux.Models;

namespace TestLinux.Controllers
{
    public class DeafController : Controller
    {
        private readonly ILogger<DeafController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly DatabaseContext _database;
        public readonly CustomIDataProtection _protector;
        public DeafController(ILogger<DeafController> logger, IWebHostEnvironment webHostEnvironment, DatabaseContext database, CustomIDataProtection protector)
        {
            _database = database;
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _protector = protector;
        }

        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        [HttpGet]
        public IActionResult Login()
        {
            #region newCodeAdded
            //----Added on 09-06-2022-------
            Random random = new Random();
            //string characters = "abcdefgh@#$%";
            
            int captcha = random.Next(1000, 99999);
            var s = Guid.NewGuid().ToString().Replace("-","").Substring(0,6);
            string characters = "*bcdefgh@#$%";
            var i = random.Next(0, characters.Length);
            s = characters[i] + s;
            var b = GenCaptcha(s);
            byte[] encodedPassword = new UTF8Encoding().GetBytes(s);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded;
            ViewData["IsPostBack"] = false;
            //---------------------------------------------
            #endregion
            Response.Cookies.Delete("Login");
            Response.Cookies.Delete("UserId");
            Response.Cookies.Delete("Role");
            foreach (var cookie in HttpContext.Request.Cookies)
            {
                Response.Cookies.Delete(cookie.Key);
            }
            ViewData["CaptchaMessage"] = "";

            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult RedirectToMobile()
        {
            Logs logs = new Logs();
            logs.LogDateTime = DateTime.Now.ToString();
            logs.Type = "Mobile Banking";
            logs.Remarks = "Link Clicked";
            _database.Logs.Add(logs);
            _database.SaveChanges();
            //return View();
            return Redirect("https://play.google.com/store/apps/details?id=com.mbanking.crgb.crgb"); ;
        }
        [HttpGet]
        public IActionResult ViewComplaint(string Id)
        {
            var id = _protector.Encode(Id);
            if (Request.Cookies["Login"] == "Success")
            {
                ViewBag.brcode = HttpContext.Session.GetString("Role");
                var com = _database.Grievances.Find(id);
                if (com != null)
                {
                    return View(com);
                }
                return RedirectToAction("Login");

            }
            return RedirectToAction("Login");
           
        }
        [HttpPost]
        public IActionResult ViewComplaint(Grievance g)
        {

            if (Request.Cookies["Login"] == "Success")
            {
                var com = _database.Grievances.Find(g.Id);
                //com.BrReplyDate = g.BrReplyDate;
                com.InternalReply = g.InternalReply;
                com.ROReply = g.ROReply;
                com.HOReply = g.HOReply;
                com.Status = g.Status;
               
                var brcode = HttpContext.Session.GetString("Role");
                if (g.Status == "Closed")
                {
                    com.ClosureDate = DateTime.Today;
                }

                if (brcode == "09900")
                {
                    com.HOReplyDate = DateTime.Today;
                }
                else if (brcode.StartsWith("099"))
                {
                    com.ROReplyDate = DateTime.Today;
                }
                else
                {
                    com.BrReplyDate =  DateTime.Today;
                }


                _database.Entry(com).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _database.SaveChanges();
                return RedirectToAction("Dashboard");
            }

            return RedirectToAction("Login");
        }
        [HttpGet]
        
        public IActionResult Dashboard()
        {

            Response.GetTypedHeaders().CacheControl = new CacheControlHeaderValue()
            {
                Public = true,
                MaxAge = TimeSpan.FromSeconds(1),
                MustRevalidate = true,
                NoStore = true,
                NoCache = true,
                MaxStale = true
            };


            int pending_d = 0, pending_g = 0, closed_d = 0, closed_g = 0;

            if (Request.Cookies.ContainsKey("Login") == false)
            {
                return RedirectToAction("Login");
            }
            if (HttpContext.Session.GetString("Role") == null)
            {
                return RedirectToAction("Login");
            }
            if (Request.Cookies["Login"] == "Success")
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserId");

                var brcode = HttpContext.Session.GetString("Role");
                var bname = _database.Branches.Where(a => a.BrCode == brcode).FirstOrDefault();
                if (brcode == "09900")
                {
                    pending_d = _database.Grievances.Where(a => a.Status != "Closed" && a.Segment == "D").Count();
                    pending_g = _database.Grievances.Where(a => a.Status != "Closed" && a.Segment != "D").Count();
                    closed_d = _database.Grievances.Where(a => a.Status == "Closed" && a.Segment == "D").Count();
                    closed_g = _database.Grievances.Where(a => a.Status == "Closed" && a.Segment != "D").Count();
                }
                else if (brcode.StartsWith("099"))
                {
                    var ro = _database.Branches.Find(brcode).RO;
                    pending_d = _database.Grievances.Where(a => a.Status != "Closed" && a.Segment == "D" && a.RO == ro).Count();
                    pending_g = _database.Grievances.Where(a => a.Status != "Closed" && a.Segment != "D" && a.RO == ro).Count();
                    closed_d = _database.Grievances.Where(a => a.Status == "Closed" && a.Segment == "D" && a.RO == ro).Count();
                    closed_g = _database.Grievances.Where(a => a.Status == "Closed" && a.Segment != "D" && a.RO == ro).Count();
                }
                else
                {
                    pending_d = _database.Grievances.Where(a => a.Status != "Closed" && a.Segment == "D" && (a.Branch == bname.BranchName || a.Branch == bname.BrCode)).Count();
                    pending_g = _database.Grievances.Where(a => a.Status != "Closed" && a.Segment != "D" && (a.Branch == bname.BranchName || a.Branch == bname.BrCode)).Count();
                    closed_d = _database.Grievances.Where(a => a.Status == "Closed" && a.Segment == "D" && (a.Branch == bname.BranchName || a.Branch == bname.BrCode)).Count();
                    closed_g = _database.Grievances.Where(a => a.Status == "Closed" && a.Segment != "D" && (a.Branch == bname.BranchName || a.Branch == bname.BrCode)).Count();
                }
            }
            ViewBag.P_D = pending_d;
            ViewBag.P_G = pending_g;
            ViewBag.C_D = closed_d;
            ViewBag.C_G = closed_g;
            return View();
        }
        [HttpGet]
        public IActionResult BrComplaint()
        {
           
            if (Request.Cookies["Login"] == "Success")
            {
                var brcode = Request.Cookies["role"];
                ViewBag.ComplaintChannel = brcode;

            }
            else
            {
                return RedirectToAction("Login");
            }

            var g = _database.Branches.Select(a => a.District).Distinct().ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem { Text = "--- Select District---", Value = "" });
            foreach (var item in g)
            {
                items.Add(new SelectListItem { Text = item, Value = item });
            }
            ViewBag.District = items;

            return View();
        }
        [HttpGet]
        public IActionResult FetchList(string a , string b)
        {

            List<Grievance> list = new List<Grievance>();
            if (Request.Cookies["Login"] == "Success")
            {
                
                var brcode = HttpContext.Session.GetString("Role");
                var bname = _database.Branches.Where(a => a.BrCode == brcode).FirstOrDefault();
                if (brcode == "09900")
                {
                    if (a == "Pending")
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Status != "Closed").ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Status != "Closed").ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Status != "Closed").ToList();
                        }
                    }
                    else if (a == "Closed")
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Status == "Closed").ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Status == "Closed").ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Status == "Closed").ToList();
                        }
                    }
                    else
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D").ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D").ToList();
                        }
                    }

                }
                else if (brcode.StartsWith("099"))
                {
                    var ro = _database.Branches.Find(brcode).RO;
                    if (a == "Pending")
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Status != "Closed" && z.RO == ro).ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Status != "Closed" && z.RO == ro).ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Status != "Closed" && z.RO == ro).ToList();
                        }
                    }
                    else if (a == "Closed")
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Status == "Closed" && z.RO == ro).ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Status == "Closed" && z.RO == ro).ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Status == "Closed" && z.RO == ro).ToList();
                        }
                    }
                    else
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.RO == ro).ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.RO == ro).ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.RO == ro).ToList();
                        }
                    }
                }
                else
                {
                    if (a == "Pending")
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Status != "Closed" && z.Branch == bname.BranchName).ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Status != "Closed" && z.Branch == bname.BranchName).ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Status != "Closed" && z.Branch == bname.BranchName).ToList();
                        }
                    }
                    else if (a == "Closed")
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Status == "Closed" && z.Branch == bname.BranchName).ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Status == "Closed" && z.Branch == bname.BranchName).ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Status == "Closed" && z.Branch == bname.BranchName).ToList();
                        }
                    }
                    else
                    {
                        if (b == "D")
                        {
                            list = _database.Grievances.Where(z => z.Segment == "D" && z.Branch == bname.BranchName).ToList();
                        }
                        else if (b == "All")
                        {
                            list = _database.Grievances.Where(z => z.Branch == bname.BranchName).ToList();
                        }
                        else
                        {
                            list = _database.Grievances.Where(z => z.Segment != "D" && z.Branch == bname.BranchName).ToList();
                        }
                    }
                }
            }

            return View(list);
        }
        [HttpPost]
        public IActionResult Login(string captcha, string token, string userid,string password)
        {

            if (captcha is null || token is null || userid is null || password is null)
            {
                return RedirectToAction("Login");
            }

            if (captcha == "" || token == "" || userid == "" || password == "")
            {
                return View();
            }
            #region NewCodeAdded
            //----Added on 09-06-2022-------
            byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash)
               .Replace("-", string.Empty)
               .ToLower();

            if (encoded == token)
            {
                password = CreateMD5(password);
                var x1 = _database.Users.Where(a => a.UserId == userid && a.Password.ToUpper() == password.ToUpper()).ToList();
                var x = x1.Count();
                if (x > 0)
                {
                    HttpContext.Session.SetString("UserId" , userid);
                    HttpContext.Session.SetString("Role", x1.FirstOrDefault().RegionalOffice);
                    Response.Cookies.Append("Login", "Success");
                   // Response.Cookies.Append("UserId", userid);
                   // Response.Cookies.Append("Role", x1.FirstOrDefault().RegionalOffice);
                    ViewData["Captcha"] = "Success";
                    ViewData["IsPostBack"] = true;
                    ViewData["CaptchaImage"] = new byte[50];
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    
                    ViewBag.Message = "Invalid Credentials";
                }
            }
            else
            {
                ViewData["CaptchaMessage"] = "Invalid Captcha";
            }

            Random random = new Random();
            int captcha1 = random.Next(1000, 99999);
            var b = GenCaptcha(captcha.ToString());
            byte[] encodedPassword0 = new UTF8Encoding().GetBytes(captcha.ToString());
            byte[] hash0 = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword0);
            string encoded0 = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded0;
            

            //----------------------------
            #endregion


            #region OldSourceCode
            //----Comeented on 09-06-2022-------
            //password = CreateMD5(password);
            //var x1 = _database.Users.Where(a => a.UserId == userid && a.Password == password).ToList();
            //var x = x1.Count();
            //if (x > 0)
            //{
            //    Response.Cookies.Append("Login", "Success");
            //    Response.Cookies.Append("UserId", userid);
            //    Response.Cookies.Append("Role", x1.FirstOrDefault().RegionalOffice) ;
            //    return RedirectToAction("Dashboard");
            //}
            #endregion

            return View();
        }
        [HttpGet]
        public IActionResult CheckBG(string bg_no = "", Single amount = 0,string mode = "normal")
        {
            Random random = new Random();
            int captcha = random.Next(1000, 99999);

            var b = GenCaptcha(captcha.ToString());
            byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha.ToString());

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();
            byte[] data = Convert.FromBase64String(bg_no);
            string decodedString = Encoding.UTF8.GetString(data);
            if (mode == "qr")
            {
                ViewData["qr"] = true;
            }
            else
            {
                ViewData["qr"] = false;
            }
            
            ViewData["bg_no"] = decodedString;
            ViewData["amount"] = amount;
            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded;
            ViewData["IsPostBack"] = false;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CheckBG(string bg_no, Single amount)
        {
            Random random = new Random();
            int captcha = random.Next(1000, 99999);

            var b = GenCaptcha(captcha.ToString());
            byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha.ToString());

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();
            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded;
            ViewData["IsPostBack"] = true;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync($"https://www.cgbankmobile.in/BG/GetDetails?account={bg_no}&amt={amount}");
            if (response.IsSuccessStatusCode)
            {
                ViewData["IsSuccess"] = true;
                string s = await response.Content.ReadAsStringAsync();
                if (s ==  "Success")
                {
                    ViewData["BGLink"] = $"http://www.cgbankmobile.in/{bg_no}.pdf";
                }
            }
            else
            {
                ViewData["IsSuccess"] = false;
            }
            
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            Random random = new Random();
            int captcha = random.Next(1000, 99999);

            var b = GenCaptcha(captcha.ToString());
            byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha.ToString());

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();

            ViewData["CaptchaImage"] = b;
            ViewData["Captcha"] = encoded;
            ViewData["IsPostBack"] = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string captcha, string token,string Address, string Cust_Name)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(captcha);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();
            
            if (encoded == token)
            {
                ViewData["Captcha"] = "Success";
                var result = _database.Deafs.Where(a => a.Branch.Contains(Address) || a.Cust_Name.Contains(Cust_Name)).ToList();
                ViewData["Result"] = result;
            }
            else
            {
                ViewData["Captcha"] = "Fail";
            }
            
            ViewData["IsPostBack"] = true;
            ViewData["CaptchaImage"] = new byte[50];
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
    }
}
