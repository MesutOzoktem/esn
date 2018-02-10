using DataLayer.Database;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Operations
{
    public class AccountOperations
    {
        public OperationResult Login(string mail, string password)
        {
            try
            {
                using (ESNEntities db = new ESNEntities())
                {
                    var user = db.User.First(r => r.Mail == mail && r.Password == password);
                    if (user != null)
                    {
                        return OperationResult.GetSuccessResult(user);
                    }
                    else
                    {
                        return OperationResult.GetFailResult("User can not be found");
                    }
                }
            }
            catch (Exception ex)
            {
                return OperationResult.GetFailResult("Login operation failed");
            }
            
        }
    }
}
