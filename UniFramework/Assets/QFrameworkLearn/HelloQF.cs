using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

public class HelloQF : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Log.I("Hello QF");

        "I am leo".LogInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
