using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreRazor.UI.Models
{
    public class MusicStoreListContext : DbContext
    {

        public MusicStoreListContext(DbContextOptions<MusicStoreListContext> options) 
            : base(options)
        {

        }

        public DbSet<Music> Musics{ get; set; }
    }
}
