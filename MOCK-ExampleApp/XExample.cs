namespace Conductus.MOCK.Example
{
    public class ExampleNotImplentedException : BaseException
    {
        public ExampleNotImplentedException()
        {
            this.Name = "ExampleNotImplentedException";
        }
        public ExampleNotImplentedException(string message)
            : base(message)
        {
        }
        public ExampleNotImplentedException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
        public string Display()
        {
            return this.Display();
        }
    }
    public class ExampleAlreadyExistsException : BaseException
    {
        public ExampleAlreadyExistsException()
        {
            this.Name = "ExampleAlreadyExistsException";
        }
        public ExampleAlreadyExistsException(string message)
            : base(message)
        {
        }
        public ExampleAlreadyExistsException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
        public string Display()
        {
            return this.Display();
        }
    }
    public class ExampleNotFoundException : BaseException
    {
        public ExampleNotFoundException()
        {
            this.Name = "ExampleNotFoundException";
        }
        public ExampleNotFoundException(string message)
            : base(message)
        {
        }
        public ExampleNotFoundException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
        public string Display()
        {
            return this.Display();
        }
    }
}
