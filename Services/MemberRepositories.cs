using btvn.Interfaces;
using btvn.Models;
using btvn.Data;
using Microsoft.EntityFrameworkCore;

namespace btvn.Services;

public class MemberRepositories : IMemberRepositories
{
    private readonly ApplicationContext _context;

    public MemberRepositories(ApplicationContext context)
    {
        _context = context;
    }

    public Member CreateMember(Member member)
    {
        throw new NotImplementedException();
    }

    public Task<List<Member>> GetMembers()
    {
        return _context.Members.ToListAsync();
    }
}
