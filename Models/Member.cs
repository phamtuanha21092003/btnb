using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace btvn.Models;

[Table("tblMembers")]
public class Member
{
    [Key]
    public string? MemberName { get; set; }
    public int YearOfBirth { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public bool Gender { get; set; }
    public string? MemberPassword { get; set; }

}
