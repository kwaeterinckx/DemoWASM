namespace DemoWASM.Pages.Demos
{
	public partial class Demo01
	{
		public int Valeur { get; set; } = 42;

		public void Ajouter()
		{
			Valeur++;
		}

		public void Ajouter5(int value)
		{
			Valeur += value;
		}
	}
}
