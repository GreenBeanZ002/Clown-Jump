using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Output : MonoBehaviour
{
    public GameObject potionPrefab; 
    public Transform resultSlot; 

    int potionA = 4;
    int WholeVal = 0; 

    private HoldVal HoldValScript;
    private HoldVal2 HoldVal2Script;
    private HoldVal3 HoldVal3Script;
    private HoldVal4 HoldVal4Script;
    private bool isResFull;

    void Start()
    {
        HoldValScript = FindObjectOfType<HoldVal>();
        HoldVal2Script = FindObjectOfType<HoldVal2>();
        HoldVal3Script = FindObjectOfType<HoldVal3>();
        HoldVal4Script = FindObjectOfType<HoldVal4>();
    }

    void Update()
    {
        if (HoldValScript == null || HoldVal2Script == null || HoldVal3Script == null || HoldVal4Script == null)
        {
            Debug.LogError("One or more HoldVal scripts are missing!");
            return; 
        }

        WholeVal = HoldValScript.Val + HoldVal2Script.Val2 + HoldVal3Script.Val3 + HoldVal4Script.Val4; 

        if (WholeVal == potionA && !isResFull)
        {
            AssignPotionToResultSlot();
            isResFull = true; 
        }
    }

    void AssignPotionToResultSlot()
    {
        GameObject potion = Instantiate(potionPrefab, resultSlot.position, Quaternion.identity);
        potion.transform.SetParent(resultSlot);
    }
}
// this should be attached to where the output area is ps i used chatgtp to error check this code 