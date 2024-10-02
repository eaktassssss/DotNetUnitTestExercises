using MediatR;
using UnitTestExercises.Application.Commands;
using UnitTestExercises.Core.Services;

namespace UnitTestExercises.Application.Handlers
{
    public class ProcessOrderInStagesHandler : IRequestHandler<ProcessOrderInStagesCommand, bool>
    {
        private readonly IOrderService _orderService;

        public ProcessOrderInStagesHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<bool> Handle(ProcessOrderInStagesCommand request, CancellationToken cancellationToken)
        {
            return _orderService.ProcessOrderInStages(request.OrderId, request.Stages);
        }
    }
}