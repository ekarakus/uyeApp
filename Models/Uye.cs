using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace uyeler.Models
{
    public class Uye
    {
        [MinLength(3, ErrorMessage = "En az 3 karakter")]
        [MaxLength(20, ErrorMessage = "En fazla 20 karakter")]
        [Required(ErrorMessage = "Ad alanı Gereklidir")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı Gereklidir")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Email alanı Gereklidir")]
        [EmailAddress(ErrorMessage = "Geçerli bir Email giriniz.")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı Gereklidir")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Harf ve sayıdan oluşan 8 karakter giriniz.")]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }

        [DataType(DataType.Password)]
        [Compare("Sifre")]
        [Display(Name = "Şifre Tekrarı")]
        public string SifreTekrari { get; set; }
       
        [Required(ErrorMessage = "Doğum yılı alanı Gereklidir")]
        [RegularExpression(@"^(19|20)\d{2}$",ErrorMessage ="Lütfen 19xx veya 20xx olarak tarih giriniz")]
        [Display(Name = "Doğum Yılı")]
        public int DogumYili { get; set; }
    }
}