using basicAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicAPI.Services
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanies();
        Company GetCompany(int companyId, bool returnTechnology);
        IEnumerable<Technology> GetTechnologies(int companyId);
        Technology GetTechnology(int companyId, int technologyId);
        bool IsCompanyExists(int companyId);
    }
}
