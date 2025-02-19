using AzureSQLDapperNet8MVCApp.Models;

namespace AzureSQLDapperNet8MVCApp.DBContext
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetCompanies();
        Task<Company> GetCompany(int? id);
        Task CreateCompany(Company company);
        Task UpdateCompany(int id, Company company);
        Task DeleteCompany(int id);
    }
}
