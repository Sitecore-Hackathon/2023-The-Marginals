using Marginals.Feature.CountdownTimer.Models;
using Sitecore.XA.Foundation.Mvc.Repositories.Base;
using Sitecore.XA.Foundation.RenderingVariants.Repositories;

namespace Marginals.Feature.CountdownTimer.Repositories
{
    public class CountdownTimerItemRepository : VariantsRepository, ICountdownTimerItemRepository
    {
        public CountdownTimerItemRepository()
        {

        }

        public override IRenderingModelBase GetModel()
        {
            CountdownTimerItemModel model = new CountdownTimerItemModel();
            FillBaseProperties(model);
            return model;
        }
    }
}