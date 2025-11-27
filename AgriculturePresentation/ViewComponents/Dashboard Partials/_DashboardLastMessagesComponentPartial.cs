using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents.Dashboard_Partials
{
    public class _DashboardLastMessagesComponentPartial(IContactService _contactService): ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var values = _contactService.LastMessages();
            return View(values);
        }
    }
}
