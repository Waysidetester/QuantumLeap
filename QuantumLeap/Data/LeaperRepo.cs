using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Threading.Tasks;
using QuantumLeap.Models;

namespace QuantumLeap.Data
{
    public class LeaperRepo
    {
        const string connectionString = "Server=localhost;Database=QuantumLeap;Trusted_Connection=True;";
        
        public Leaper GatherCurrentIntel(int id)
        {
            using (var db = new SqlConnection(connectionString))
            {
                var selectLeaperQuery = "SELECT * FROM Leapers WHERE Id = @id";
                var selectLeapeeIdsQuery = "SELECT LeapeeId FROM LeaperLeapee WHERE LeaperId = @id";
                var selectEventIdsQuery = "SELECT EventId FROM LeaperEvent WHERE LeaperId = @id";
                var parameters = new { id = id };

                var LeapeesQuery = "SELECT id, name, currentleaper, timeperiod FROM Leapees";
                var EventsQuery = "SELECT * FROM Events";
           
                var leaper = db.QueryFirstOrDefault<Leaper>(selectLeaperQuery, parameters);
                var matchedLeapeeIds = db.Query<int>(selectLeapeeIdsQuery, parameters);
                var matchedEventIds = db.Query<int>(selectEventIdsQuery, parameters);
                var leapees = db.Query<LeapeeBasic>(LeapeesQuery);
                var events = db.Query<Event>(EventsQuery);

                leaper.PastEvents = events.Where(x => matchedEventIds.Contains(x.Id)).ToList();
                leaper.PastLeapees = leapees.Where(x => matchedLeapeeIds.Contains(x.Id)).ToList();

                return leaper;
            }

            throw new Exception("Could not get member");
        }

        public void GetJumpInfo(int id)
        {
            using (var db = new SqlConnection(connectionString))
            {
                /* Return to this section later
                 * 
                 * 
                var selectLeaperQuery = "SELECT * FROM Leapers WHERE Id = @id";
                var selectLeapeeIdsQuery = "SELECT LeapeeId FROM LeaperLeapee WHERE LeaperId = @id";
                var selectEventIdsQuery = "SELECT EventId FROM LeaperEvent WHERE LeaperId = @id";
                var parameters = new { id = id };

                var LeapeesQuery = "SELECT id, name, currentleaper, timeperiod FROM Leapees";
                var EventsQuery = "SELECT * FROM Events";

                var leaper = db.QueryFirstOrDefault<Leaper>(selectLeaperQuery, parameters);
                var matchedLeapeeIds = db.Query<int>(selectLeapeeIdsQuery, parameters);
                var matchedEventIds = db.Query<int>(selectEventIdsQuery, parameters);
                var leapees = db.Query<LeapeeBasic>(LeapeesQuery);
                var events = db.Query<Event>(EventsQuery);

                leaper.PastEvents = events.Where(x => matchedEventIds.Contains(x.Id)).ToList();
                leaper.PastLeapees = leapees.Where(x => matchedLeapeeIds.Contains(x.Id)).ToList();
                */
            }
        }
    }
}
