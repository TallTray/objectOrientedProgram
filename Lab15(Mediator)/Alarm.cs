
using Mediator.Request;

namespace Lab15_Mediator_
{
    internal class Alarm
    {
        private AlarmMediator _mediator;

        public Alarm(AlarmMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public void OnEvent()
        {
            _mediator.Execute(new AlarmRequest(new TimeOnly(9, 30)));
        }
    }
}