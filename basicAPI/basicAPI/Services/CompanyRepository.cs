using basicAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicAPI.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        CompanyContext _ctx;
        public CompanyRepository(CompanyContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Company> GetCompanies()
        {
            return _ctx.Companies.ToList();
        }

        public Company GetCompany(int companyId, bool returnTechnology)
        {
            if (returnTechnology)
            {
                return _ctx.Companies.Include(c => c.Technologies).FirstOrDefault(c => c.Id == companyId);
            }

            return _ctx.Companies.FirstOrDefault(c => c.Id == companyId);
        }

        public IEnumerable<Technology> GetTechnologies(int companyId)
        {
            return _ctx.Technologies.Where(t => t.CompanyId == companyId);
        }

        public Technology GetTechnology(int companyId, int technologyId)
        {
            return _ctx.Technologies.FirstOrDefault(t => t.CompanyId == companyId && t.Id == technologyId);
        }

        public bool IsCompanyExists(int companyId)
        {
            return _ctx.Companies.Any(c => c.Id == companyId);
        }
    }
}
