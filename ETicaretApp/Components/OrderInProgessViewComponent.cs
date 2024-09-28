using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace ETicaretApp.Components
{
    public class OrderInProgessViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public OrderInProgessViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public string Invoke()
        {
            return _manager.OrderService.NumberOfInProcess.ToString();
        }
    }
}