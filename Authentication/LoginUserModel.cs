

using System.ComponentModel.DataAnnotations;

public class LoginUserModel{
    public string UserName{get;set;} = default!; 
    [Required]
    public string Password{get;set;} = default!;
}