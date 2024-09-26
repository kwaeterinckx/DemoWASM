using Microsoft.AspNetCore.Components;

namespace DemoWASM.Pages.Exos
{
	public partial class Exo01_Question
	{
		[Parameter]
		public string Prenom { get; set; }

		[Parameter]
		public int NoQuestion { get; set; }

		[Parameter]
		public string Question { get; set; }

		[Parameter]
		public EventCallback<string> Reponse { get; set; }

		public void EnvoieReponse(string reponse)
		{
			Reponse.InvokeAsync(reponse);
		}
	}
}
