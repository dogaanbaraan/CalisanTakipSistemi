﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CalisanTakip.Common.SessionOperations;
using CalisanTakip.DataAccess.Implementation;
using CalisanTakip.DataAccess.Contracts;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using CalisanTakip.DataAccess.DbModels;
using CalisanTakip.Common.ConstantsModel;

namespace CalisanTakip.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IUnitOfWork _uow;

        public LoginModel(SignInManager<Employee> signInManager,
            ILogger<LoginModel> logger,
            UserManager<Employee> userManager,
            IUnitOfWork uow)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _uow = uow;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    #region 1.yöntem
                    //var user = _userManager.FindByNameAsync(Input.Email);
                    ////var user = _uow.employeeRepository.GetFirstOfDefault(u => u.Email == Input.Email);
                    //if (user != null)
                    //{
                    //    var sessionContext = new SessionContext();
                    //    sessionContext.Email = user.Result.Email;
                    //    sessionContext.FirstName = user.Result.NormalizedEmail;

                    //    sessionContext.LoginId = user.Result.Id;
                    //    HttpContext.Session.SetString("AppUserSession", JsonConvert.SerializeObject(sessionContext));
                    //}
                    #endregion
                    var user = _uow.employeeRepository.GetFirstOfDefault(u=>u.Email == Input.Email);
                    var userInfo = new SessionContext()
                    {

                        Email = user.Email,
                        FirstName = user.FirstName,
                        IsAdmin = false,
                        LastName = user.LastName,
                        LoginId = user.Id

                    };

                    HttpContext.Session.SetString(ResultConstant.LoginUserInfo, JsonConvert.SerializeObject(userInfo));
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
