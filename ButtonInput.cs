using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ButtonInput : MonoBehaviour
{
    public GameObject potionAPrefab; 
    public GameObject potionBPrefab; 
    public GameObject potionCPrefab; 
    public GameObject potionDPrefab; 
    public GameObject potionEPrefab; 

    public Transform resultSlot; 
    public HoldVal HoldValScript;
    public HoldVal2 HoldVal2Script;
    public HoldVal3 HoldVal3Script;
    public HoldVal4 HoldVal4Script;
    public Holder HolderScript; 
    public ArrayCollection ArrayCollectionScript; 

    private int WholeVal = 0;
    private bool isResFull = false;

    public void ButtonPressed()
    {
        if (HoldValScript.Val > 0 || HoldVal2Script.Val2 > 0 || HoldVal3Script.Val3 > 0 || HoldVal4Script.Val4 > 0)
        {
            WholeVal = HoldValScript.Val + HoldVal2Script.Val2 + HoldVal3Script.Val3 + HoldVal4Script.Val4; 
          
            if (WholeVal > 0 && !isResFull)
            {
                isResFull = true; 
                ArrayCollectionScript.Execute(); 

                switch (WholeVal)
                {
                    case 4:
                        GameObject potionA = Instantiate(potionAPrefab, resultSlot.position, Quaternion.identity);
                        potionA.transform.SetParent(resultSlot);
                        break;

                    case 8:
                        GameObject potionB = Instantiate(potionBPrefab, resultSlot.position, Quaternion.identity);
                        potionB.transform.SetParent(resultSlot);
                        break; 

                    case 12:
                        GameObject potionC = Instantiate(potionCPrefab, resultSlot.position, Quaternion.identity);
                        potionC.transform.SetParent(resultSlot);
                        break;

                    case 16:
                        GameObject potionD = Instantiate(potionDPrefab, resultSlot.position, Quaternion.identity);
                        potionD.transform.SetParent(resultSlot);
                        break; 
                    
                    case 20:
                        GameObject potionE = Instantiate(potionEPrefab, resultSlot.position, Quaternion.identity);
                        potionE.transform.SetParent(resultSlot);
                        break;
                }
            }   
        }
        else
        {
            Debug.Log("Error: No positive values in HoldVal scripts.");
        }
    }

}