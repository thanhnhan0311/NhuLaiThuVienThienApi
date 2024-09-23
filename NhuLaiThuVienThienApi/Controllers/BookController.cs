using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NhuLaiThuVienThienApi.Data;
using NhuLaiThuVienThienApi.DTOs;
using NhuLaiThuVienThienApi.Features.Book.Request.Commands;
using NhuLaiThuVienThienApi.Features.Book.Request.Queries;
using NhuLaiThuVienThienApi.Repositories;
using TechWizWebApp.Services;
using ThuVienNhuLaiThien.Domain;

namespace NhuLaiThuVienThienApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllBook()
        {
            var result = await _mediator.Send(new GetAllBookQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromForm] CreateBookCommand bookCreateRequest)
        {
            var result = await _mediator.Send(bookCreateRequest);
            return Ok(result);
        }

        [HttpGet("book")]
        public async Task<IActionResult> GetBook([FromQuery] int bookId)
        {
            var result = await _mediator.Send(new GetDetailsBookQuery() { book_id = bookId });
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> PutBook([FromForm] UpdateBookCommand bookUpdateRequest)
        {
            var result = await _mediator.Send(bookUpdateRequest);
            return Ok(result);
        }
    }
}
