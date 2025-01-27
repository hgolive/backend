using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Validation;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.Commands;
using Ambev.DeveloperEvaluation.WebApi.Features.Customer.RequestResponse;
using AutoMapper;
using MediatR;


namespace Ambev.DeveloperEvaluation.WebApi.Features.Customer;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public CustomerController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateCustomerResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequest request, CancellationToken cancellationToken)
    {
 

        var command = _mapper.Map<CreateCustomerCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateCustomerResponse>
        {
            Success = true,
            Message = "Customer created successfully",
            Data = _mapper.Map<CreateCustomerResponse>(response)
        });
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetCustomerResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetCustomer([FromRoute] int id, CancellationToken cancellationToken)
    {
        var request = new GetCustomerRequest { Id = id };
        var validator = new GetCustomerRequestValidator();
       

        var command = _mapper.Map<GetCustomerCommand>(request.Id);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetCustomerResponse>
        {
            Success = true,
            Message = "Customer retrieved successfully",
            Data = _mapper.Map<GetCustomerResponse>(response)
        });
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteCustomer([FromRoute] int id, CancellationToken cancellationToken)
    {
        var request = new DeleteCustomerRequest { Id = id };
        var validator = new DeleteCustomerRequestValidator();
     

        var command = _mapper.Map<DeleteCustomerCommand>(request.Id);
        await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponse
        {
            Success = true,
            Message = "Customer deleted successfully"
        });
    }
}