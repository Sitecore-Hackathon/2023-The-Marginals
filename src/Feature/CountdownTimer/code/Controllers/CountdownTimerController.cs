using Marginals.Feature.CountdownTimer.Repositories;
using Sitecore.XA.Foundation.RenderingVariants.Controllers.Base;

namespace Marginals.Feature.CountdownTimer.Controllers
{
    public class CountdownTimerController : PaginableController
    {
        protected ICountdownTimerItemRepository CountdownTimerItemRepository { get; set; }

        public CountdownTimerController()
        {

        }

        public CountdownTimerController(ICountdownTimerItemRepository Repository)
        {
            CountdownTimerItemRepository = Repository;
        }

        protected override object GetModel()
        {
            CountdownTimerItemRepository = new CountdownTimerItemRepository();
            return CountdownTimerItemRepository.GetModel();
        }
    }
}