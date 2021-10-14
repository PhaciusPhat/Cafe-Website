using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using final.Models;
using System.Windows;
using System.Text;
using System.Security.Cryptography;

namespace final.Controllers
{
    public class AdminController : Controller
    {
        QLCafeDataContext contextDB = new QLCafeDataContext();

        //account

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

        public ActionResult createAcc(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                if (form.Count > 0)
                {
                    if (form["UserNameKH"].Trim() == "" || form["TenKH"].Trim() == "" || form["SDT"].Trim() == "" || form["PhanQuyen"] == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                        return View();
                    }
                    if (contextDB.TaiKhoans.Any(tk => tk.UserNameKH == form["UserNameKH"].Trim()))
                    {
                        MessageBox.Show("Username này đã có người dùng");
                        return View();
                    }
                    TaiKhoan newTK = new TaiKhoan();
                    newTK.UserNameKH = form["UserNameKH"].Trim();
                    newTK.PassWordKH = MD5Hash("1");
                    newTK.SDT = int.Parse(form["SDT"].Trim());
                    newTK.TenKH = form["TenKH"].Trim();
                    newTK.PhanQuyen = Boolean.Parse(form["PhanQuyen"]);
                    contextDB.TaiKhoans.InsertOnSubmit(newTK);
                    contextDB.SubmitChanges();
                    MessageBox.Show("thêm thành công");
                    return RedirectToAction("DSTK");
                }
                return View();
            }
        }

        public ActionResult EditAcc(string UserNameKH, FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                TaiKhoan taiKhoan = contextDB.TaiKhoans.FirstOrDefault(tk => tk.UserNameKH == UserNameKH.Trim());
                ViewBag.PQ = taiKhoan.PhanQuyen;
                if (form.Count > 0)
                {
                    if (form["TenKH"].Trim() == "" || form["SDT"].Trim() == "" || form["PhanQuyen"] == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                        return View(taiKhoan);
                    }
                    taiKhoan.SDT = int.Parse(form["SDT"].Trim());
                    taiKhoan.TenKH = form["TenKH"].Trim();
                    taiKhoan.PhanQuyen = Boolean.Parse(form["PhanQuyen"]);
                    contextDB.SubmitChanges();
                    MessageBox.Show("cập nhật thành công");
                    return RedirectToAction("DSTK");
                }
                return View(taiKhoan);
            }
        }

        public ActionResult delAcc(string UserNameKH)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                TaiKhoan taiKhoan = contextDB.TaiKhoans.FirstOrDefault(tk => tk.UserNameKH == UserNameKH.Trim());
                if (contextDB.HoaDons.Any(hd => hd.UserNameKH == taiKhoan.UserNameKH))
                {
                    MessageBox.Show("Tài khoản này đã mua hàng, không thể xóa");
                }
                else
                {
                    var result = MessageBox.Show("Bạn có muốn xóa tài khoản này", "thông báo", MessageBoxButton.OKCancel);
                    if (result == MessageBoxResult.OK)
                    {
                        contextDB.TaiKhoans.DeleteOnSubmit(taiKhoan);
                        contextDB.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                return RedirectToAction("DSTK");
            }
        }

        public ActionResult sortUserName()
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<TaiKhoan> taiKhoans = contextDB.TaiKhoans.OrderByDescending(tk => tk.UserNameKH).ToList();
                return View("DSTK", taiKhoans);
            }
        }

        // GET: Admin
        public ActionResult DSTK(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<TaiKhoan> taiKhoans = contextDB.TaiKhoans.ToList();
                if (form.Count != 0)
                {
                    string searchUser = form["searchUserName"].Trim();
                    searchUser = searchUser.ToLower();
                    List<TaiKhoan> findUser = new List<TaiKhoan>();
                    foreach (var tk in contextDB.TaiKhoans.ToList())
                    {
                        string name = tk.UserNameKH;
                        name = name.ToLower();
                        if (name.Contains(searchUser) == true)
                        {
                            findUser.Add(tk);
                        }
                    }
                    taiKhoans = findUser;
                }
                return View(taiKhoans);
            }
        }


        //product

        public ActionResult createProduct(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                ViewBag.ListLoaiSP = contextDB.LoaiSPs.ToList();
                if (form.Count > 0)
                {
                    SanPham newSP = new SanPham();
                    HttpPostedFileBase file = Request.Files["HinhAnh"];
                    if (form["TenSP"].Trim() == "" || form["GiaSP"] == "" || form["LoaiSP"] == "" || file.FileName.ToString() == "" || form["ChiTiet"].Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                        return View();
                    }
                    if (int.Parse(form["GiaSP"]) <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng giá!!!");
                        return View();
                    }
                    if (file != null)
                    {
                        string severPath = HttpContext.Server.MapPath("~/assets/img");
                        string filePath = severPath + "/" + file.FileName;
                        file.SaveAs(filePath);
                        newSP.HinhAnh = file.FileName;
                    }
                    newSP.TenSP = form["TenSP"].Trim();
                    newSP.GiaSP = int.Parse(form["GiaSP"]);
                    newSP.MaLoaiSP = int.Parse(form["LoaiSP"]);
                    newSP.ThongTinChiTiet = form["ChiTiet"].Trim();
                    contextDB.SanPhams.InsertOnSubmit(newSP);
                    contextDB.SubmitChanges();
                    MessageBox.Show("Thêm thành công!!!");
                    return RedirectToAction("DSSP");
                }
                return View();
            }
        }

        public ActionResult editProduct(int id, FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                SanPham sanPham = contextDB.SanPhams.FirstOrDefault(sp => sp.MaSP == id);
                ViewBag.loaiSP = sanPham.MaLoaiSP;
                ViewBag.ListLoaiSP = contextDB.LoaiSPs.ToList();
                if (form.Count > 0)
                {
                    HttpPostedFileBase file = Request.Files["HinhAnh"];
                    if (form["TenSP"].Trim() == "" || form["GiaSP"] == "" || form["LoaiSP"] == "" || file.FileName.ToString() == "" || form["ThongTinChiTiet"].Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                        return View(sanPham);
                    }
                    if (int.Parse(form["GiaSP"]) <= 0)
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng giá!!!");
                        return View(sanPham);
                    }
                    if (file != null)
                    {
                        string severPath = HttpContext.Server.MapPath("~/assets/img");
                        string filePath = severPath + "/" + file.FileName;
                        file.SaveAs(filePath);
                        sanPham.HinhAnh = file.FileName;
                    }
                    sanPham.TenSP = form["TenSP"].Trim();
                    sanPham.GiaSP = int.Parse(form["GiaSP"]);
                    sanPham.MaLoaiSP = int.Parse(form["LoaiSP"]);
                    sanPham.ThongTinChiTiet = form["ThongTinChiTiet"].Trim();
                    contextDB.SubmitChanges();
                    MessageBox.Show("Cập nhật thành công!!!");
                    return RedirectToAction("DSSP");
                }
                return View(sanPham);
            }
        }

        public ActionResult delProduct(int id)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                SanPham delSP = contextDB.SanPhams.FirstOrDefault(sp => sp.MaSP == id);
                if (contextDB.CTHDs.Any(ct => ct.MaSP == id))
                {
                    MessageBox.Show("Sản phẩm này đã dc mua ko thể xóa");
                }
                else
                {
                    var result = MessageBox.Show("Bạn có muốn xóa sp này", "thông báo", MessageBoxButton.OKCancel);
                    if (result == MessageBoxResult.OK)
                    {
                        contextDB.SanPhams.DeleteOnSubmit(delSP);
                        contextDB.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                return RedirectToAction("DSSP");
            }
        }

        public ActionResult sortProduct()
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<SanPham> sanPhams = contextDB.SanPhams.OrderByDescending(tk => tk.TenSP).ToList();
                return View("DSSP", sanPhams);
            }
        }

        // GET: Admin
        public ActionResult DSSP(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<SanPham> sanPhams = contextDB.SanPhams.ToList();
            if (form.Count != 0)
            {
                string searchUser = form["searchProductName"].Trim();
                searchUser = searchUser.ToLower();
                List<SanPham> findUser = new List<SanPham>();
                foreach (var tk in contextDB.SanPhams.ToList())
                {
                    string name = tk.TenSP;
                    name = name.ToLower();
                    if (name.Contains(searchUser) == true)
                    {
                        findUser.Add(tk);
                    }
                }
                sanPhams = findUser;
            }
            return View(sanPhams);
            }
        }

        //product type

        public ActionResult createKindOfProduct(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                if (form.Count > 0)
                {
                    LoaiSP newLSP = new LoaiSP();
                    if (form["TenLoai"].Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                        return View();
                    }
                    else
                    {
                        newLSP.TenLoai = form["TenLoai"].Trim();
                        contextDB.LoaiSPs.InsertOnSubmit(newLSP);
                        contextDB.SubmitChanges();
                        MessageBox.Show("Thêm thành công!!!");
                        return RedirectToAction("DSLSP");
                    }
                }
                return View();
            }
        }

        public ActionResult editKindOfProduct(int id, FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                LoaiSP newLSP = contextDB.LoaiSPs.FirstOrDefault(lsp => lsp.MaLoaiSP == id);
                if (form.Count > 0)
                {
                    if (form["TenLoai"].Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                        return View();
                    }
                    else
                    {
                        newLSP.TenLoai = form["TenLoai"].Trim();
                        contextDB.SubmitChanges();
                        MessageBox.Show("Cập nhật thành công!!!");
                        return RedirectToAction("DSLSP");
                    }
                }
                return View(newLSP);
            }
        }

        public ActionResult delKindOfProduct(int id)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                LoaiSP newLSP = contextDB.LoaiSPs.FirstOrDefault(lsp => lsp.MaLoaiSP == id);
                if (contextDB.SanPhams.Any(sp => sp.MaLoaiSP == id))
                {
                    MessageBox.Show("Có sản phẩm thuộc loại này, ko thể xóa");
                }
                else
                {
                    var result = MessageBox.Show("Bạn có muốn xóa loại sp này", "thông báo", MessageBoxButton.OKCancel);
                    if (result == MessageBoxResult.OK)
                    {
                        contextDB.LoaiSPs.DeleteOnSubmit(newLSP);
                        contextDB.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                return RedirectToAction("DSLSP");
            }
        }

        public ActionResult showProduct(int id, FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<SanPham> sanPhams = contextDB.SanPhams.Where(sp => sp.MaLoaiSP == id).ToList();
                return View("DSSP", sanPhams);
            }
        }

        public ActionResult sortProductType()
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<LoaiSP> loaiSps = contextDB.LoaiSPs.OrderByDescending(tk => tk.TenLoai).ToList();
                return View("DSLSP", loaiSps);
            }
        }

        // GET: Admin
        public ActionResult DSLSP(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<LoaiSP> loaiSps = contextDB.LoaiSPs.ToList();
            if (form.Count != 0)
            {
                string searchUser = form["searchTypeProductName"].Trim();
                searchUser = searchUser.ToLower();
                List<LoaiSP> findUser = new List<LoaiSP>();
                foreach (var tk in contextDB.LoaiSPs.ToList())
                {
                    string name = tk.TenLoai;
                    name = name.ToLower();
                    if (name.Contains(searchUser) == true)
                    {
                        findUser.Add(tk);
                    }
                }
                loaiSps = findUser;
            }
            return View(loaiSps);
            }
        }


        //invoice

        private int sumTongTien()
        {
            int year = DateTime.Now.Year;
            int sum = 0;
            foreach (var item in contextDB.HoaDons.Where(hd => hd.DaMua == true && hd.NgayMua.Value.Year == year).ToList())
            {
                sum += item.TongTien;
            }
            return sum;
        }

        private int sumMonth()
        {
            int year = DateTime.Now.Month;
            int sum = 0;
            foreach (var item in contextDB.HoaDons.Where(hd => hd.DaMua == true && hd.NgayMua.Value.Month == year).ToList())
            {
                sum += item.TongTien;
            }
            return sum;
        }

        public ActionResult sortInvoice()
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<HoaDon> hoaDons = contextDB.HoaDons.Where(hd => hd.DaMua == true).OrderByDescending(tk => tk.NgayMua).ToList();
                return View("DSHD", hoaDons);
            }
        }

        // GET: Admin
        public ActionResult DSHD(FormCollection form)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                List<HoaDon> hoaDons = contextDB.HoaDons.Where(hd => hd.DaMua == true).ToList();
            ViewBag.TongNam = sumTongTien();
            ViewBag.TongThang = sumMonth();
            return View(hoaDons);
            }
        }

        public ActionResult CTHD(int id)
        {
            if (Session["PhanQuyen"] == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (Session["PhanQuyen"].ToString() != "True")
                {
                    return HttpNotFound();
                }
                ViewBag.DiaChi = contextDB.HoaDons.FirstOrDefault(hd => hd.MaHD == id).DiaChiGiaoHang;
                List<CTHD> cTHDs = contextDB.CTHDs.Where(ct => ct.MaHD == id).ToList();
                return View(cTHDs);
            }
        }

    }
}