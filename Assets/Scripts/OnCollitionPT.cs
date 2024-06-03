using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySimpleLiquid;

public class OnCollitionPT : MonoBehaviour
{
    public GameObject Beaker;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag=="PracticeBeaker")
        {
            Beaker.GetComponent<LiquidContainer>().fillAmountPercent=0.9f;
        }
    }
}
