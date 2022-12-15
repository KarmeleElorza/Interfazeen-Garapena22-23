using Wineshop.Models;
namespace Wineshop.ViewModels
{
    public class OsatuViewModel
    {
        public string Bezeroa { get; set; }
        public string SaskiaId { get; set; }
        public IList<SaskiaAlea> SaskiaAleak { get; set; }
    }
}