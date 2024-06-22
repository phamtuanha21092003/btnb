using Microsoft.AspNetCore.Mvc;
using btvn.Data;
using btvn.Interfaces;

namespace btvn.Controllers;

public class MemberController : Controller
{
    private readonly IMemberRepositories _member;

    public MemberController(IMemberRepositories context)
    {
        this._member = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _member.GetMembers());
    }
}
