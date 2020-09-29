using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMusic.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }
        public string Title { get; set; }
        public int AlbumId { get; set; }
    }
}
