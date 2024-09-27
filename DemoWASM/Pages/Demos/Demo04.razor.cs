using DemoWASM.Models;
using System.Text.Json;

namespace DemoWASM.Pages.Demos
{
    public partial class Demo04
    {
        public Jeu JeuForm { get; set; }
        public List<string> Genres { get; set; }

        public Demo04()
        {
            JeuForm = new Jeu();
            Genres = new List<string>();
            Genres.AddRange(new string[] {"FPS", "RTS", "RPG", "Autres" });
        }
        
        public void SubmitForm()
        {
            Console.WriteLine(JsonSerializer.Serialize(JeuForm));
        }
    }
}
