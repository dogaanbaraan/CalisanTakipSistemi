using AutoMapper;
using CalisanTakip.Common.ViewModels;
using CalisanTakip.DataAccess.Contracts;
using CalisanTakip.DataAccess.DbModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CalisanTakip.ViewComponents
{
    public class UserNameViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _map;

        public UserNameViewComponent(IUnitOfWork uow, IMapper map)
        {
            _map = map;
            _uow = uow;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userFromDb = _uow.employeeRepository.GetFirstOfDefault(u => u.Id == claims.Value);
            var employeeToDb = _map.Map<Employee, EmployeeVM>(userFromDb);
            return View(employeeToDb);
        }
    }
}
