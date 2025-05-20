using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using AdvanceProjectObjects; // This is the correct namespace for the database model

namespace AdvancedProjectApp
{
    public static class LogHelper
    {
        public static void LogLogin(int userId, string action, string details = "")
        {
            try
            {
                using (var db = new EquipmentRentalDBContext())
                {
                    var log = new AdvanceProjectObjects.Log
                    {
                        UserId = userId,
                        Action = action,
                        Source = "Desktop",
                        Timestamp = DateTime.Now,
                        Details = details
                    };

                    db.Logs.Add(log);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("log-fallback.txt",
                    $"{DateTime.Now} | UserID: {userId} | Action: {action} | Error: {ex.Message}\n");
            }
        }
    }
}

