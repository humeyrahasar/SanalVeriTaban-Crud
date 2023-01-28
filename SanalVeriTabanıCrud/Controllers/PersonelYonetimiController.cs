using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SanalVeriTabanıCrud.Data;
using SanalVeriTabanıCrud.Models;

namespace SanalVeriTabanıCrud.Controllers
{
    public class PersonelYonetimiController : Controller
    {
        //dependency enjection: bapımlı enjeksiyon
        private readonly AppDbContext _context;
        public PersonelYonetimiController(AppDbContext context)//veri tabanı örnek -->new AppDbContext()
        {
            //sınıf düzeyine yayıldı
            _context= context;
        }
        public IActionResult Index() //CRUD --> R (okumaa listeleme)
        {
            return View(_context.Personels);
        }

        public IActionResult Details(int id) //id:1531 --> ahmet
        {
            //id ----> personel
            var personel = _context.Personels.Where(x => x.SicilNo == id).SingleOrDefault();
            return View(personel);
        }

        public IActionResult Delete(int id) //id:1531 --> ahmet
        {
            //id ----> personel
            var personel = _context.Personels.Where(x => x.SicilNo == id).SingleOrDefault();
            _context.Personels.Remove(personel);
            _context.SaveChanges();
            return RedirectToAction("Index"); //liste ekrana tekrar yazdırlır
        }
        //[HttpGet] varsayılan 
        public IActionResult Create() //CRUD --> C (oluşturma)
        {
            return View();//form ---> model binding --->personel
        }

        [HttpPost]
        public IActionResult Create(Personel personel) //form(persomel)----> veri tabanı
  
        {
            _context.Personels.Add(personel);//lissteye eklendi(sanal veri tabanı)
            _context.SaveChanges();//gerçek veri tabanına yazabilmesi için listedeki değişikleri tabloya yansıtır
            return RedirectToAction("Index");//listeleme
        }
        public IActionResult Edit(int id)
        {
            //id --linq----> personel
            var personel = _context.Personels.Where(x => x.SicilNo == id).SingleOrDefault();
            return View(personel);//form <<<--model binding----<<<<personel  
        }
        [HttpPost]
        public IActionResult Edit(Personel personel)
        {
            var guncellenecekPersonel = _context.Personels.Where(x => x.SicilNo == personel.SicilNo).SingleOrDefault();

            //uzun yol
            guncellenecekPersonel.Adi = personel.Adi;
            guncellenecekPersonel.Soyadi = personel.Soyadi;
            guncellenecekPersonel.Resim = personel.Resim;
            _context.SaveChanges();
            return RedirectToAction("Index");//listeleme
        }
    }
}
