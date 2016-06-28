using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ParticipantsRepository
    {
        public IQueryable<Participant> Query => new List<Participant>
        {
            new Participant(1, "David", "Tielke", "mail@david-tielke.de", "www.David-Tielke.de",
                "www.David-Tielke.de"),
            new Participant(1, "Lena", "Tielke", "mail@david-tielke.de", "www.David-Tielke.de",
                "www.David-Tielke.de"),
            new Participant(1, "Maximlian", "Tielke", "mail@david-tielke.de", "www.David-Tielke.de",
                "www.David-Tielke.de"),
            new Participant(1, "Hasi", "Tielke", "mail@david-tielke.de", "www.David-Tielke.de",
                "www.David-Tielke.de"),
        }.AsQueryable();
    }
}