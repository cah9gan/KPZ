namespace ClassLibrary.Chain_of_responsibility
{
    public abstract class Handler
    {
        protected Handler? nextHandler;

        public void SetNext(Handler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void HandleRequest(int level);
    }
}