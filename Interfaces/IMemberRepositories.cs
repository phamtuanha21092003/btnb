using btvn.Models;

namespace btvn.Interfaces;

public interface IMemberRepositories
{
    public Task<List<Member>> GetMembers();

    public Member CreateMember(Member member);
}
