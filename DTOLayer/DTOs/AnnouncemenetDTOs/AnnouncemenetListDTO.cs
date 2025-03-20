using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AnnouncemenetDTOs
{
    public class AnnouncemenetListDTO
    {
        public int AnnouncemenetID { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
