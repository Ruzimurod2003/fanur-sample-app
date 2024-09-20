using System.ComponentModel.DataAnnotations;

namespace FanurApp.ViewModels;

public class ContactUsVM
{
    [Required(ErrorMessage = "Iltimos buni kiiting")]
    public string ContactName { get; set; }
    [Required(ErrorMessage = "Iltimos buni kiiting")]
    public string ContactPhone { get; set; }
    [Required(ErrorMessage = "Iltimos buni kiiting")]
    public string Subject { get; set; }
    [Required(ErrorMessage = "Iltimos buni kiiting")]
    public string Message { get; set; }
}