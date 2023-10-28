public class App : IApp
{
    public IContext Context { get; set; }

    public void SetContext(IContext context)
    {
        Context = context;
        Context.Init();
    }
}
