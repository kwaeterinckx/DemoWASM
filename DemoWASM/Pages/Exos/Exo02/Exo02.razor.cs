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
        public List<Exo02_Gamer> Gamers { get; set; }

        public Exo02()
        {
            Gamers = new List<Exo02_Gamer>();
            Gamers.Add(new Exo02_Gamer()
            {
                Pseudo = "Kévin",
                Email = "Waeterinckx",
                Password = "Test123456",
                DateNaissance = DateOnly.Parse("1983-03-11")
            });
            GamerForm = new Exo02_Gamer();
        }

        public void SubmitAddForm()
        {
            Gamers.Add(GamerForm);
            GamerForm = new Exo02_Gamer();
        }
        public void SubmitEditForm()
        {
            Gamers.Add(GamerForm);
            GamerForm = new Exo02_Gamer();
        }
    }
}
