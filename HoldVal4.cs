using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldVal4 : MonoBehaviour
{
    public int Val4; 
    private Value ValueScript; 
    private List<Value> ValueScripts = new List<Value>();
    private bool hasAddedIngVal;
    // Start is called before the first frame update
    void Start()
    {
        Val4 = 0;
        Value[] values = FindObjectsOfType<Value>();
        foreach (Value valueScript in values) 
        {
            ValueScripts.Add(valueScript);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasAddedIngVal)
        {
            foreach (Value valueScript in ValueScripts)
        {
            if (valueScript != null && transform.position == valueScript.transform.position)
            {
                Val4 += valueScript.IngVal;
                hasAddedIngVal = true;  
                break;
            }
        } 
        }
    
    }
}
