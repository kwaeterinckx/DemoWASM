namespace DemoWASM.Pages.Demos
{
	public partial class Demo02
	{
		public int Valeur { get; set; }
        public string Reponse { get; set; }

        public void TraitementReponseEnfant(string reponse)
		{
			Reponse = reponse;
		}

		public void Increment()
		{
			Valeur++;
		}
	}
}
