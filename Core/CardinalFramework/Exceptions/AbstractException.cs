namespace Cardinal.Exceptions;
using System;
public class AbstractException : Exception
{
    public AbstractException() { }

    public AbstractException(string message)
        : base(message) { }

    public AbstractException(string message, Exception inner)
        : base(message, inner) { }
}