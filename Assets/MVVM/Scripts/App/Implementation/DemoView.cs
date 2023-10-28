using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoView : View<MainViewModel>
{
    [SerializeField]
    private GameObject _mainViewCanvas;

    [SerializeField]
    private Button _button;

    public override void Open()
    {
        _mainViewCanvas.SetActive(true);

        _button.onClick.AddListener(() => { OpenNewScene(); });
    }

    private void OpenNewScene()
    {
        _app.SetContext(_serviceLocator.Resolve<IContext>("miniGame"));
    }

    public override void SetContext(MainViewModel context)
    {
        _context = context;

        Open();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
