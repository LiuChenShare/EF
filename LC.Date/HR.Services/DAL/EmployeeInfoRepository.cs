using LC.DAL.Entity;
using LC.Data.HR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Services.DAL
{
    public class EmployeeInfoRepository
    {
        #region
        private IRepository<EmployeeInfo> _employeeInfoRepository;
        public EmployeeInfoRepository(IRepository<EmployeeInfo> employeeInfoRepository)
        {
            _employeeInfoRepository = employeeInfoRepository;
        }
        #endregion

        public EmployeeInfo GetById(Guid id)
        {
            var result = _employeeInfoRepository.Table.Where(x => !x.Deleted && x.Id == id);
            return result.FirstOrDefault();
        }

        public void Insert(EmployeeInfo info)
        {
            _employeeInfoRepository.Insert(info);
        }

        public void Update(EmployeeInfo info)
        {
            _employeeInfoRepository.Update(info);
        }

    }
}
