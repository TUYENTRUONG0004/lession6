
using lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson06.Controllers
{
    public class TdtSongController : Controller
    {
        private static List<TdtSong> tdtSongs = new List<TdtSong>()
        {
            new TdtSong{ Id = 221090085, TdtTitle = "truong dinh tuyen", TdtAuthor = "k22cntt3", TdtArtist = "NTU", TdtYearRelease = 2020},
            new TdtSong{ Id = 1, TdtTitle = "truong dinh tuyen", TdtAuthor = "k22cnt3", TdtArtist = "NTU", TdtYearRelease = 2020}
        };

        // GET: TdtSong
        public ActionResult TdtIndex()
        {
            return View(tdtSongs);
        }

        public ActionResult TdtCreate()
        {
            var newTdtSong = new TdtSong();
            return View(newTdtSong);
        }

        [HttpPost]
        public ActionResult TdtCreate(TdtSong newTdtSong)
        {
            if (ModelState.IsValid)
            {
                tdtSongs.Add(newTdtSong);
                return RedirectToAction("TdtIndex");
            }
            return View(newTdtSong);
        }
    }
}