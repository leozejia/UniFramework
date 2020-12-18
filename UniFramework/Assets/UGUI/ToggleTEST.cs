using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

public class ToggleTEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Toggle>().onValueChanged.AddListener(OnToggleSelect);
    }

    private void OnToggleSelect(bool arg0)
    {
        if (arg0)
            Debug.Log(this.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
