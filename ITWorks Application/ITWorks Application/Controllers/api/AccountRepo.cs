using ITWorks_Application.Data;
using ITWorks_Application.Models;
using System.Linq;

namespace ITWorks_Application.Controllers.api
{
    public class AccountRepo
    {
        private readonly itworkxdevdatabaseContext _context = new itworkxdevdatabaseContext();
        public bool isLoginCredentialExist(string username, string password)
        {
            return _context.AccountData.Any(x => x.AccountName == username && x.AccountPassword == password);
        }
        public AccountData GetLoginCredential(string username, string password)
        {
            return new AccountData()
            {
                AccountID = _context.AccountData.FirstOrDefault(x => x.AccountName == username && x.AccountPassword == password).AccountId,
                AccountTypeID = _context.AccountData.FirstOrDefault(x => x.AccountName == username && x.AccountPassword == password).AccountTypeId,
                AccountName = username,
            };
        
                
        }
    }
}
