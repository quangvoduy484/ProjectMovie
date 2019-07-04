using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Infrastructure
{
    public interface IErrorHandler
    {
        string GetMessage(ErrorMessagesEnum message);
    }


    public enum ErrorMessagesEnum
    {
        EntityNull = 1,
        ModelValidation = 2,
        ListEntityEmpty = 3,
        LoadSuccess = 4,
        AddSuccess=5
    }
}
