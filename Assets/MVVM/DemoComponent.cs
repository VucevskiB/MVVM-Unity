using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoComponent : MonoBehaviour
{
    [Dependency]
    public DemoManager DemoManager;

    private void Awake()
    {
        this.Inject();
    }


    // Start is called before the first frame update
    void Start()
    {
        DemoManager.DemoFunction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
