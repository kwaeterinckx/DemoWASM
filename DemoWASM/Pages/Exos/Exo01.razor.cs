using Microsoft.AspNetCore.Components;

namespace DemoWASM.Pages.Exos
{
	public partial class Exo01
	{
		[Parameter]
		public string Prenom { get; set; }

		public List<string> Questions { get; set; } = [
			"Est-ce que les licornes aiment le chocolat ?",
			"Les poissons portent-ils des chapeaux ?",
			"Peut-on faire voler une brique avec des ballons ?",
			"Est-ce que les arbres chantent la nuit ?",
			"Les fantômes peuvent-ils jouer au football ?",
			"Est-ce que les escargots dansent le tango ?",
			"Les nuages ont-ils des rêves ?",
			"Est-ce que les chaussettes parlent entre elles ?",
			"Les ordinateurs mangent-ils des chips ?",
			"Peut-on converser avec une plante ?"
			];

		public List<string> Reponses { get; set; } = new List<string>();

		public int CurrentQuestion { get; set; }
		public int TotalQuestions { get; set; }

        public Exo01()
        {
			TotalQuestions = Questions.Count;
            CurrentQuestion = 0;
        }

        public void TraitementReponse(string reponse)
		{
			Reponses.Add(reponse);
			CurrentQuestion++;
		}
	}
}
