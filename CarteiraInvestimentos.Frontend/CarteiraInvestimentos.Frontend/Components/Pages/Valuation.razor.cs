using Microsoft.AspNetCore.Components;

namespace CarteiraInvestimentos.Frontend.Components.Pages
{
    public partial class Valuation : ComponentBase
    {
        decimal lpa { get; set; } = 0;
        decimal vpa { get; set; } = 0;

        decimal resultado { get; set; } = 0;

        public void Calcular()
        {
            resultado = (decimal)Math.Sqrt(22.5 * (double)lpa * (double)vpa);
        }
    }
}
