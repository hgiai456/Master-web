using QLCoffee.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCoffee.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        QuanLyQuanCoffeeEntities database = new QuanLyQuanCoffeeEntities();
        public ActionResult Index()
        {
            return View(database.SANPHAMs.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(SANPHAM sanpham,HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            { 
                if(Image != null && Image.ContentLength > 0)//Kiểm tra người dùng có upload file hay không
                {
                    var fileName = Path.GetFileName(Image.FileName);//lấy tên file gốc của ảnh 

                    var path = Path.Combine(Server.MapPath("~/Uploads"), fileName);//Đặt đường dẫn file đã được lưu

                    Image.SaveAs(path);//Lưu file vào Uploads

                    sanpham.Image1 = "/Uploads/" + fileName;

                }    
            }
            database.SANPHAMs.Add(sanpham);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(string id)
        {
            return View(database.SANPHAMs.Where(s => s.MaSP == id).FirstOrDefault());
        }
        public ActionResult Edit(string id)
        {
            return View(database.SANPHAMs.Where(s => s.MaSP == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(string id, SANPHAM sanpham)
        {
            database.Entry(sanpham).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            return View(database.SANPHAMs.Where(s => s.MaSP == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(string id, SANPHAM sanpham)
        {
            sanpham = database.SANPHAMs.Where(s => s.MaSP == id).FirstOrDefault();
            database.SANPHAMs.Remove(sanpham);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}