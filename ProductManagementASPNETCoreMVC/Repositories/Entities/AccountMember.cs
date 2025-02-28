using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repositories.Entities;

public partial class AccountMember
{
    public string? MemberId { get; set; } = null!;

    [Required(ErrorMessage = "Password is required.")]
    public string MemberPassword { get; set; } = null!;

    public string? FullName { get; set; } = null!;

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string EmailAddress { get; set; } = null!;

    public int? MemberRole { get; set; }
}
