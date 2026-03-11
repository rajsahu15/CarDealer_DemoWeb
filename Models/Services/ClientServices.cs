
using System;
using WebApplication1.Models.DataBaseConnection;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Services
{
    public class ClientServices {
   static DatabaseLoader loadDB = new DatabaseLoader();
        public bool AddClient(Clients user) {
          
            try
            {
                loadDB.Clients.Add(user);

               
                int rowsAffected = loadDB.SaveChanges();

                // 4. Verification Logs
                if (rowsAffected > 0)
                {
                    Console.WriteLine($"--- SUCCESS: {user.ClientName} added to the Brotherhood database ---");
                }

                return true; // Returns 1 if saved successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine("MISSION FAILED: " + ex.Message);
                return false;
            }
          return false;

        }

        public static bool isValid(LoginModel model)
        {
            

            return loadDB.Clients.Any(c =>
                (c.ClientEmail == model.Identity || c.PhoneNumber == model.Identity)
                && c.Password == model.Password
            );
           

        }
    }
}

    
