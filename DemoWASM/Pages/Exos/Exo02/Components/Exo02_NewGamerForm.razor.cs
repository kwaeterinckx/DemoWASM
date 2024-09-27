using DemoWASM.Models;
using Microsoft.AspNetCore.Components;

namespace DemoWASM.Pages.Exos.Exo02.Components
{
    public partial class Exo02_NewGamerForm
    {
        [Parameter]
        public Exo02_Gamer GamerForm { get; set; }

        [Parameter]
        public EventCallback ReponseEvent { get; set; }

        public void CreateGamer()
        {
            ReponseEvent.InvokeAsync();
        }
    }
}
