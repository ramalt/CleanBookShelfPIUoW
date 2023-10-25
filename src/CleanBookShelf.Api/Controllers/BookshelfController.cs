using CleanBookShelf.Application.interfaces;
using CleanBookShelf.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanBookShelf.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookshelfController : ControllerBase
{
    private readonly IBookRepository _bookRepository;
    private readonly ILibraryRepository _libraryRepository;

    public BookshelfController(ILibraryRepository libraryRepository, IBookRepository bookRepository)
    {
        _libraryRepository = libraryRepository;
        _bookRepository = bookRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetBooks()
    {
        var response = _bookRepository.GetAll();
        return Ok(response);
    }
}
