using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMZontik : MonoBehaviour
{
    public Zontik_NPC[] behaviours;
    public Zontic_Mob[] mobBehaviors;

    private int number;

    private void Start()
    {
        behaviours = GetComponents<Zontik_NPC>();
        mobBehaviors = GetComponents<Zontic_Mob>();
        number = Random.Range(1, 3);
        IniInitializeBehaviours();
        Debug.Log(number);
    }

    private void IniInitializeBehaviours()
    {
        foreach (Zontic_Mob behaviour in mobBehaviors)
        {
            behaviour.enabled = false;
        }

        foreach (Zontik_NPC behaviour in behaviours)
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
