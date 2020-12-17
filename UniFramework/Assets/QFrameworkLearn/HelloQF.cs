using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

public class HelloQF : MonoBehaviour
{
    ResLoader mResLoader = ResLoader.Allocate();

    // Start is called before the first frame update
    void Start()
    {
        Log.I("Hello QF");

        "I am leo".LogInfo();

        mResLoader.Add2Load("TestObj",(succeed,res)=> { 
            
        });

        mResLoader.LoadAsync();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
