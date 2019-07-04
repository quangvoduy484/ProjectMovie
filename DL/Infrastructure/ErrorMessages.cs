using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Infrastructure
{
    public class ErrorMessages : IErrorHandler
    {
        public string GetMessage(ErrorMessagesEnum message)
        {
            switch (message)
            {
                case ErrorMessagesEnum.EntityNull:
                    return "The entity passed is null {0}. Additional information: {1}";

                case ErrorMessagesEnum.ModelValidation:
                    return "The request data is not correct. Additional information: {0}";

                case ErrorMessagesEnum.ListEntityEmpty:
                    return "List Entity is Empty";
                case ErrorMessagesEnum.LoadSuccess:
                    return "Load Success";
                case ErrorMessagesEnum.AddSuccess:
                    return "Add Success";
                default:
                    throw new ArgumentOutOfRangeException(nameof(message), message, null);
            }
        }
    }
}
