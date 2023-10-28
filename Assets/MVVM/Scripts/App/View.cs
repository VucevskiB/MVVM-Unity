using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View<T> : MonoBehaviour where T : class, IContext
{
    [Dependency]
    protected IServiceLocator _serviceLocator;

    [Dependency]
    protected IApp _app;

    [SerializeField]
    private bool _autoBind;

    protected T _context;

    public void Awake()
    {
        this.Inject();

        if (_autoBind)
        {
            SetContext((T)_app.Context);
        }
    }

    public abstract void Open();

    public abstract void SetContext(T context);
}
