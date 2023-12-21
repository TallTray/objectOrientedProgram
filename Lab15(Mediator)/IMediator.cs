using Mediator.Request;

namespace Lab15_Mediator_
{
    internal interface IMediator
    {
        public void Execute(IRequest request);
    }
}