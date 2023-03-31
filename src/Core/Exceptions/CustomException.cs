using System;

namespace Fwks.FwksApp.Core.Exceptions;

public class CustomException : Exception
{
    public CustomException()
        : base("This is a custom exception message")
    {

    }
}
