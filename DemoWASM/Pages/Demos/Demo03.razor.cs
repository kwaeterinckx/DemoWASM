namespace DemoWASM.Pages.Demos
{
    public partial class Demo03
    {
        public List<Guid> Liste { get; set; }

        public Demo03() { 
            Liste = new List<Guid>();
            for (int i = 0; i < 50; i++)
            {
                Liste.Add(Guid.NewGuid());
            }
        }
    }
}
