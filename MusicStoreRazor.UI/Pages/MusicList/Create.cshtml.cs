using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MusicStoreRazor.UI.Models;

namespace MusicStoreRazor.UI.Pages.MusicList
{
    public class CreateModel : PageModel
    {
        private readonly MusicStoreListContext _db;

        public CreateModel(MusicStoreListContext db)
        {
            _db = db;

        }

        public  Music Musics { get; set; }
        

        public void  OnGet()
        {
            

        }
    }
}
