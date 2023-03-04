using Sitecore.XA.Foundation.Variants.Abstractions.Models;

namespace Marginals.Feature.CountdownTimer.Models
{
    public class CountdownTimerItemModel : VariantsRenderingModel
    {
        public string Title { get; set; }
        public string Days { get; set; }
        public string Hours { get; set; }
        public string Minutes {  get; set; }
        public string Seconds {  get; set; }
        public string TargetDate { get; set; }
    }
}