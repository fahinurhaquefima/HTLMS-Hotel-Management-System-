using HTLMS.WebApp.DatabaseContest;
using HTLMS.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HTLMS.WebApp.Controllers
{
    public class HotelController : Controller
    {
        private readonly ApplicationDbContest _contest;
        public HotelController(ApplicationDbContest contest)
        {
            _contest = contest;
        }
        [HttpGet]
        public async Task< IActionResult>Index()
        {
            var data = await _contest.Set<Hotel>().AsNoTracking().ToListAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult>CreateOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new Hotel());
            }
            else
            {
                var data = await _contest.Set<Hotel>().FindAsync(id);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult>CreateOrEdit(int id , Hotel hotel)
        {
            if (id == 0)
            {
                if (ModelState.IsValid)
                {
                    await _contest.Set<Hotel>().AddAsync(hotel);
                    await _contest.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                else
                {
                     _contest.Set<Hotel>().Update(hotel);
                    await _contest.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                 
            }
            return View(new Hotel());
        }
        public async Task<IActionResult>Delete(int id)
        {
            if (id != 0)
            {
                var data = await _contest.Set<Hotel>().FindAsync(id);
                if (data is not null)
                {
                    _contest.Set<Hotel>().Remove(data);
                    await _contest.SaveChangesAsync();
                    return RedirectToAction("Index");

                }

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _contest.Set<Hotel>().FindAsync(id);
            return View(data);
        }
    }
}
