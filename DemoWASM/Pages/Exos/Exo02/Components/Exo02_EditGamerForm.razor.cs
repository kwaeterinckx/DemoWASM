using DemoWASM.Models;
using Microsoft.AspNetCore.Components;

namespace DemoWASM.Pages.Exos.Exo02.Components
{
    public partial class Exo02_EditGamerForm
    {
        [Parameter]
        public Exo02_Gamer EditGamerForm { get; set; }

        [Parameter]
        public EventCallback<Exo02_Gamer> ReponseEvent { get; set; }

        public void EditGamer()
        {
            ReponseEvent.InvokeAsync(EditGamerForm);
        }
    }

}
