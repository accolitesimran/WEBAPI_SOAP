using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceReference1;
using SoapAPI.Models;

namespace SoapAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("/Add")]
        public async Task<Output> AddAsync(double num1,double num2)
        {
            Output output = new Output();
            output.Response = null;
            output.ErrorMessage = null;
            try
            {
                ServiceReference1.ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
                double result=await calculatorService.AddAsync(num1, num2);
                output.Response = result;
                return output;
            }
            catch (Exception ex)
            {
                output.ErrorMessage = "Exception occured while adding";
                return output;
            }
        }

        [HttpGet("/Subtract")]
        public async Task<Output> SubtractAsync(double num1,double num2)
        {
            Output output = new Output();
            output.Response = null;
            output.ErrorMessage = null;
            try
            {
                ServiceReference1.ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
                double result=await calculatorService.SubtractAsync(num1, num2);
                output.Response=result;
                return output;
            }
            catch(Exception ex)
            {
                output.ErrorMessage = "Exception occured while subtracting";
                return output;
            }
        }
        [HttpGet("/Multiply")]
        public async Task<Output> MultiplyAsync(double num1,double num2)
        {
            Output output = new Output();
            output.Response = null;
            output.ErrorMessage = null;
            try
            {
                ServiceReference1.ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
                double result=await calculatorService.MultiplyAsync(num1, num2);
                output.Response=(result);
                return output;
            }
            catch(Exception ex)
            {
                output.ErrorMessage="Exception occured while multiplying";
                return output;
            }
        }
        [HttpGet("/Divide")]
        public async Task<Output> DivideAsync(double num1, double num2)
        {
            Output output = new Output();
            output.Response = null;
            output.ErrorMessage = null;
            try
            {
                ServiceReference1.ICalculatorService calculatorService = new CalculatorServiceClient(CalculatorServiceClient.EndpointConfiguration.BasicHttpBinding_ICalculatorService);
                double result=await calculatorService.DivideAsync(num1, num2);
                output.Response = result;
                return output;
            }
            catch(Exception ex)
            {
                output.ErrorMessage="Exception occured while dividing";
                return output;
            }
            
        }
    }
}
