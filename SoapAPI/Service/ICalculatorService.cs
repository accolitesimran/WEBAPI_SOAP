using System.ServiceModel;

namespace SoapAPI.Service
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        public double Add(double num1, double num2);
        [OperationContract]
        public double Subtract(double num1, double num2);
        [OperationContract]
        public double Multiply(double num1, double num2);
        [OperationContract]
        public double Divide(double num1, double num2);
    }
}
