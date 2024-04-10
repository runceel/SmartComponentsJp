using System.ComponentModel.DataAnnotations;

namespace SmartComponentsJp.Models;

public class Employee
{
    [Required(ErrorMessage = "名前を入力してください。")]
    public string Name { get; set; } = "";
    [Required(ErrorMessage = "郵便番号を入力してください。")]
    public string ZipCode { get; set; } = "";
    [Required(ErrorMessage = "住所を入力してください。")]
    public string Address { get; set; } = "";
    [Required(ErrorMessage = "電話番号を入力してください。")]
    public string PhoneNumber { get; set; } = "";
    [Required(ErrorMessage = "メールアドレスを入力してください。")]
    public string EmailAddress { get; set; } = "";
}
