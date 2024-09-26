using Microsoft.AspNetCore.Components;

namespace DemoWASM.Pages.Demos
{
	public partial class Enfant
	{
		[Parameter]
		public int ValeurDuParent { get; set; }

		[Parameter]
		public string Chaine { get; set; }

		protected override void OnParametersSet()
		{
			Chaine = (ValeurDuParent * 3).ToString();
		}

		[Parameter]
		public EventCallback<string> ReponseEvent { get; set; }

		public void EnvoieReponse()
		{
			ReponseEvent.InvokeAsync("Réponse !");
		}
	}
}
