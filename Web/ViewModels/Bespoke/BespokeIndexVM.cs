namespace Web.ViewModels.Bespoke
{
    public class BespokeIndexVM
    {
        public Core.Entities.BespokeAnimation bespokeAnimation { get; set; }
        public List<Core.Entities.BespokeInform> bespokeInforms { get; set; }
        public List<Core.Entities.FJProducts> FJProducts { get; set; }   
        public List<Core.Entities.Product> products { get; set; }   
    }
}
