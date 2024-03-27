using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMX : MonoBehaviour
{
    public XNPC[] behaviours;
    public XMob[] mobBehaviors;

    private int number;

    private void Start()
    {
        behaviours = GetComponents<XNPC>();
        mobBehaviors = GetComponents<XMob>();
        number = Random.Range(1, 3);
        IniInitializeBehaviours();
        Debug.Log(number);
    }

    private void IniInitializeBehaviours()
    {
        foreach (XMob behaviour in mobBehaviors)
        {
            behaviour.enabled = false;
        }

        foreach (XNPC behaviour in behaviours)
        {
            behaviour.enabled = false;
        }

        if (number == 1)
        {
            behaviours[Random.Range(0, behaviours.Length)].enabled = true;
        }
        else
        {
            mobBehaviors[Random.Range(0, behaviours.Length)].enabled = true;
        }
    }
}
