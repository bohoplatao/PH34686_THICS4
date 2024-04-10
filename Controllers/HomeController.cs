using Microsoft.AspNetCore.Mvc;
using PH34686_THICS4.Models;
using System.Diagnostics;

namespace PH34686_THICS4.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        AppDBContext _context;
        public HomeController()
        {
            _context = new AppDBContext();
        }
        public IActionResult Index()
        {
            var ca = _context.Cas.ToList();
            return View(ca);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] // nhớ phải thêm httpPost
        public IActionResult Create(Ca ca) // truyền vào bảng và đặt tên
        {
            try
            {
                _context.Cas.Add(ca);
                _context.SaveChanges();
                return RedirectToAction("Index");   
            }catch (Exception ex)
            {
                return Content(" them that bai");
            }
        }

        public IActionResult Details(string id) // khai báo string id()  // nhớ đoạn này viết đúng có dấu s (Details)
        {
            var ca = _context.Cas.ToList().FirstOrDefault(p =>p.ID == id);
            return View(ca);
        }

        public IActionResult Edit(string id) // nhớ đặt tên là Edit, đừng đặt là Update 
        {
            var edit = _context.Cas.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(Ca ca)
        {
            try
            {
                var edit = _context.Cas.Find(ca.ID);
                edit.Ten = ca.Ten;
                edit.Tuoi = ca.Tuoi;
                edit.NoiSong = ca.NoiSong;
                edit.ID_DongVat = ca.ID_DongVat;
                _context.Cas.Update(edit);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest();
            }
        }


        public IActionResult Delete(string id)
        {
            var delete = _context.Cas.Find(id);
            _context.Cas.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





        public IActionResult Privacy()
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
