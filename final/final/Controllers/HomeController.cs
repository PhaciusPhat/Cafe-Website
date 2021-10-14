using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using final.Models;
using System.Text;
using System.Security.Cryptography;

namespace final.Controllers
{
    public class HomeController : Controller
    {
        QLCafeDataContext contextDB = new QLCafeDataContext();

        private string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void createSession()
        {
            Session["UserNameKH"] = null;
            Session["PassWordKH"] = null;
            Session["SDT"] = null;
            Session["PhanQuyen"] = null;
            Session["TenKH"] = null;
        }

        public ActionResult Index()
        {
            List<SanPham> sanPhams = contextDB.SanPhams.ToList();
            ViewBag.SanPhams = sanPhams;
            return View();
        }

        public ActionResult Product(int id)
        {
            SanPham product = contextDB.SanPhams.FirstOrDefault(sp => sp.MaSP == id);
            ViewBag.anotherProducts = contextDB.SanPhams.Where(sp => sp.MaLoaiSP == product.MaLoaiSP).ToList();
            if(Request.Form.Count > 0)
            {
                if (Session["UserNameKH"] != null)
                {
                    HoaDon temp = contextDB.HoaDons.FirstOrDefault(hd => hd.UserNameKH == Session["UserNameKH"].ToString() && hd.DaMua == false);
                    if (temp == null)
                    {
                        HoaDon newHoaDon = new HoaDon();
                        newHoaDon.MaKM = null;
                        newHoaDon.NgayMua = null;
                        newHoaDon.UserNameKH = Session["UserNameKH"].ToString();
                        newHoaDon.TongTien = 0;
                        newHoaDon.DiaChiGiaoHang = null;
                        contextDB.HoaDons.InsertOnSubmit(newHoaDon);
                        contextDB.SubmitChanges();
                        CTHD newCTHD = new CTHD();
                        newCTHD.MaHD = newHoaDon.MaHD;
                        newCTHD.MaSP = product.MaSP;
                        newCTHD.SoLuong = 1;
                        contextDB.CTHDs.InsertOnSubmit(newCTHD);
                        contextDB.SubmitChanges();
                        var notice = MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công", "Thông báo", MessageBoxButton.OK);
                    }
                    else
                    {
                        CTHD tempCTHD = contextDB.CTHDs.FirstOrDefault(cthd => cthd.MaSP == product.MaSP && cthd.MaHD == temp.MaHD);
                        if (tempCTHD == null)
                        {
                            CTHD newCTHD = new CTHD();
                            newCTHD.MaHD = temp.MaHD;
                            newCTHD.MaSP = product.MaSP;
                            newCTHD.SoLuong = 1;
                            contextDB.CTHDs.InsertOnSubmit(newCTHD);
                            contextDB.SubmitChanges();
                            var notice = MessageBox.Show("Thêm sản phẩm vào giỏ hàng thành công", "Thông báo", MessageBoxButton.OK);
                        }
                        else
                        {
                           var notice = MessageBox.Show("Đã có sản phẩm này trong giỏ hàng", "Thông báo", MessageBoxButton.OK);
                        }

                    }
                }
                else
                {
                    var notice = MessageBox.Show("Vui lòng đăng nhập để thực hiện tính năng này", "Thông báo", MessageBoxButton.OK);
                }
               
            }
            return View(product);
        }

        public ActionResult Menu()
        {
            List<LoaiSP> loaiSPs = contextDB.LoaiSPs.ToList();            
            List<SanPham> hoaTans = contextDB.SanPhams.Where(ht => ht.LoaiSP.TenLoai == "Hòa Tan").ToList();
            List<SanPham> rangXays = contextDB.SanPhams.Where(ht => ht.LoaiSP.TenLoai == "Rang Xay").ToList();
            ViewBag.SanPham = contextDB.SanPhams.ToList();
            ViewBag.LoaiSP = loaiSPs;
            ViewBag.HoaTan = hoaTans;
            ViewBag.RangXay = rangXays;
            return View();
        }

        public ActionResult Login()
        {
            if (Request.Form.Count > 0)
            {
                if (Request.Form["UserNameKH"].Trim() == "" || Request.Form["PassWordKH"].Trim() == "")
                {
                    var result = MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!", "Sai Định dạng", MessageBoxButton.OK);
                }
                else
                {
                    string pass = MD5Hash(Request.Form["PassWordKH"].Trim());
                    TaiKhoan taiKhoan = contextDB.TaiKhoans.FirstOrDefault(tk => tk.UserNameKH == Request.Form["UserNameKH"].Trim() && tk.PassWordKH == pass);
                    if (taiKhoan != null)
                    {
                        var result = MessageBox.Show("Đăng nhập thành công!!!", "Thông báo", MessageBoxButton.OK);
                        Session["UserNameKH"] = taiKhoan.UserNameKH;
                        Session["PassWordKH"] = taiKhoan.PassWordKH;
                        Session["SDT"] = taiKhoan.SDT;
                        Session["PhanQuyen"] = taiKhoan.PhanQuyen.ToString();
                        Session["TenKH"] = taiKhoan.TenKH;
                        return Redirect("Index");
                    }
                    else
                    {
                        var result = MessageBox.Show("Đăng nhập thất bại!!!", "Thông báo", MessageBoxButton.OK);
                    }
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            var result = MessageBox.Show("Bạn muốn đăng xuất à :((", "Thông báo", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                createSession();
            }
            return Redirect("Index");
        }
       
        public ActionResult Logup()
        {
            if (Request.Form.Count > 0)
            {
                if (Request.Form["UserNameKH"].Trim() == "" || Request.Form["PassWordKH"].Trim() == "" || Request.Form["rePassWordKH"].Trim() == "" || Request.Form["TenKH"].Trim() == "" || Request.Form["SDT"].Trim() == "")
                {
                    var result = MessageBox.Show("Vui lòng điền đầy đủ thông tin!!", "Thông báo", MessageBoxButton.OK);
                    return View();
                }
                if(contextDB.TaiKhoans.Any(tk => tk.UserNameKH == Request.Form["UserNameKH"]))
                {
                    var result = MessageBox.Show("Tài khoản này đã được sử dụng!!", "Thông báo", MessageBoxButton.OK);
                    return View();
                }
                if (Request.Form["PassWordKH"] != Request.Form["rePassWordKH"])
                {
                    var result = MessageBox.Show("Nhập lại mật khẩu không đúng!!", "Thông báo", MessageBoxButton.OK);
                    return View();
                }
                TaiKhoan temp = new TaiKhoan();
                temp.UserNameKH = Request.Form["UserNameKH"].Trim();
                temp.PassWordKH = Request.Form["PassWordKH"].Trim();
                temp.TenKH = Request.Form["TenKH"].Trim();
                temp.SDT = int.Parse(Request.Form["SDT"].Trim());
                temp.PhanQuyen = false;
                contextDB.TaiKhoans.InsertOnSubmit(temp);
                contextDB.SubmitChanges();
                Session["UserNameKH"] = temp.UserNameKH;
                Session["TenKH"] = temp.TenKH;
                MessageBox.Show("Tạo tài khoản thành công!!");
                return Redirect("Index");
            }
            return View();
        }

        public ActionResult Cart()
        {
            if (Session["UserNameKH"] == null)
            {
                MessageBox.Show("Vui lòng đăng nhập để thực hiện tính năng này!!");
                return Redirect("Index");
            }
            DateTime temp = DateTime.Now;
            string maKM = null;
            int count = 1;
            ViewBag.ListCart = contextDB.CTHDs.Where(ct => ct.HoaDon.DaMua == false && ct.HoaDon.UserNameKH == Session["UserNameKH"].ToString()).ToList();
            List<CTHD> ListCart = contextDB.CTHDs.Where(ct => ct.HoaDon.DaMua == false && ct.HoaDon.UserNameKH == Session["UserNameKH"].ToString()).ToList();
            KhuyenMai test = contextDB.KhuyenMais.FirstOrDefault(km => (temp.Month - 1) * 30 + temp.Day > (km.NgayBD.Month - 1) * 30 + km.NgayBD.Day &&
                (temp.Month - 1) * 30 + temp.Day < (km.NgayKT.Month - 1) * 30 + km.NgayKT.Day);
            if (test == null) {
                ViewBag.ListSale = "không có";
            }
            else
            {
                ViewBag.ListSale = test.GiamGia;
                maKM = test.MaKM.ToString();
            }
            if(Request.Form.Count > 0)
            {
                if(contextDB.CTHDs.Where(ct => ct.HoaDon.DaMua == false && ct.HoaDon.UserNameKH == Session["UserNameKH"].ToString()).Count() == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào trong giỏ hàng của bạn");
                    return View();
                }
                int total = 0;
                foreach (var item in ListCart)
                {
                    if(int.Parse(Request.Form[count + "+Number"]) < 0)
                    {
                        var notice = MessageBox.Show("Vui lòng nhập đúng định dạng số lượng");
                        return View();
                    }
                    item.SoLuong = int.Parse(Request.Form[count + "+Number"]);
                    total += int.Parse(Request.Form[count + "+Number"]) * item.SanPham.GiaSP;
                    count++;
                }
                if (Request.Form["local"].Trim() == "")
                {
                    var result = MessageBox.Show("Vui lòng nhập địa chỉ giao hàng");
                    return View();
                }
                HoaDon hoaDon = contextDB.HoaDons.FirstOrDefault(ct => ct.DaMua == false && ct.UserNameKH == Session["UserNameKH"].ToString());
                if(test == null)
                {
                    hoaDon.MaKM = null;
                    hoaDon.TongTien = total;
                }
                else
                {
                    hoaDon.MaKM = hoaDon.MaKM;
                    hoaDon.TongTien = total * (test.GiamGia / 100);
                }
                hoaDon.NgayMua = temp.Date;
                hoaDon.DiaChiGiaoHang = Request.Form["local"].Trim();
                hoaDon.DaMua = true;
                contextDB.SubmitChanges();
                var final = MessageBox.Show("Mua Hàng thành công");
                return Redirect("Index");
            }
            return View(); 
        }
        public ActionResult DeleteCart(int idHd, int idSP)
        {
            CTHD cthd = contextDB.CTHDs.FirstOrDefault(ct => ct.MaHD == idHd && ct.MaSP == idSP);
            var result = MessageBox.Show("Bạn muốn xóa sản phẩm này khỏi giỏ hàng?", "Thông báo", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK) {
                contextDB.CTHDs.DeleteOnSubmit(cthd);
                contextDB.SubmitChanges();
            }
            return Redirect("Cart");
        }
    }
}