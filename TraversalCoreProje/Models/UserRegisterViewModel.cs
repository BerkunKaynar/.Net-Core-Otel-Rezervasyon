﻿using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz!")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz!")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi giriniz!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi onaylayınız!")]
        [Compare("Password", ErrorMessage = "Şifre uyuşmuyor! Lütfen tekrar deneyiniz.")]
        public string ConfirmPassword { get; set; }
    }
}
