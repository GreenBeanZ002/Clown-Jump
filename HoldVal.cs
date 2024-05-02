using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldVal : MonoBehaviour
{
    public int Val; 
    private Value ValueScript; 
    private List<Value> ValueScripts = new List<Value>();
    private bool hasAddedIngVal;
    // Start is called before the first frame update
    void Start()
    {
        Val = 0;
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
                Val += valueScript.IngVal;
                hasAddedIngVal = true;  
                break;
            }
        } 
        }
    
    }
}