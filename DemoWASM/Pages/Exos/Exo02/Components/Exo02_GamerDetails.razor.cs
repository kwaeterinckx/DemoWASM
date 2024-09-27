using DemoWASM.Models;
using Microsoft.AspNetCore.Components;

namespace DemoWASM.Pages.Exos.Exo02.Components
{
    public partial class Exo02_GamerDetails
    {
        [Parameter]
        public Exo02_Gamer Gamer { get; set; }
    }
}
