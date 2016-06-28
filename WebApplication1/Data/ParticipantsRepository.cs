using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ParticipantsRepository
    {
        private readonly TpContext _database;

        public ParticipantsRepository()
        {
            _database = new TpContext();
        }

        public IQueryable<Participant> Query => _database.Participants;
    }
}