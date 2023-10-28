public interface IContext
{
    public IApp App { get; set; }

    public IServiceLocator ServiceLocator { get; set; }

    public IInitializer Initializer { get; set; }

    void Init();
}