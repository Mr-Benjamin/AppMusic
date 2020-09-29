using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMusic.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        public string Title{ get; set; }

        public string Year{ get; set; }

        public int GenreId { get; set; }

        public int MyArtist { get; set; }
        public List<Artist> ArtistIds { get; set; }

        public string MySong { get; set; }
        public List<Song> Songs{ get; set; }

    }
}
