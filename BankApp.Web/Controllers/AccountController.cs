using BankApp.Web.Data.Context;
using BankApp.Web.Data.Interfaces;
using BankApp.Web.Data.Repositories;
using BankApp.Web.Mapping;
using BankApp.Web.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly BankContext _context;
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IUserMapper _userMapper;

        public AccountController(BankContext context, IUserMapper userMapper, IApplicationUserRepository applicationUserRepository, IAccountRepository accountRepository)
        {
            _context = context;
            _userMapper = userMapper;
            _applicationUserRepository = applicationUserRepository;
            _accountRepository = accountRepository;
        }

        public IActionResult Create(int id)
        {
            var userInfo = _userMapper.MapToUserList(_applicationUserRepository.GetById(id));
            return View(userInfo);
        }

        [HttpPost]
        public IActionResult Create(AccountCreateModel model)
        {
           
            return RedirectToAction("Index", "Home");
        }
    }
}
