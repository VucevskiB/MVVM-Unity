using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IApp 
{
    public IContext Context { get; set; }
    void SetContext(IContext context);
}
