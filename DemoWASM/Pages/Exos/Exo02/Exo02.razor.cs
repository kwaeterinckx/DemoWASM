using DemoWASM.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace DemoWASM.Pages.Exos.Exo02
{
    public partial class Exo02
    {
        [Parameter]
        public string? info { get; set; }

        [Parameter]
        public int? gamerId { get; set; }

        public Exo02_Gamer GamerForm { get; set; }
        public Dictionary<int, Exo02_Gamer> Gamers { get; set; }

        public Exo02()
        {
            Gamers = new Dictionary<int, Exo02_Gamer>();
            GamerForm = new Exo02_Gamer();
        }

        public void SubmitAddForm()
        {
            Gamers.Add(GamerForm.Id, GamerForm);
            GamerForm = new Exo02_Gamer();
        }
        public void SubmitEditForm(Exo02_Gamer gamer)
        {
            Gamers[(int)gamerId] = gamer;
        }
    }
}
