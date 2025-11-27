using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Lütfen başlık giriniz.")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Lütfen açıklama giriniz.")]
        public string Description { get; set; }

        [Display(Name = "Görsel URL")]
        [Required(ErrorMessage = "Lütfen görsel URL'si giriniz.")]
        public string ImageUrl { get; set; }

    }
}
