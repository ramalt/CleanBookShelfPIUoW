using CleanBookShelf.Application.interfaces;
using CleanBookShelf.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanBookShelf.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookshelfController : ControllerBase
{
    private readonly IRepositoryManager _repository;

    public BookshelfController(IRepositoryManager repository)
    {
        _repository = repository;
    }


    //TODO: create endpoints...
}
