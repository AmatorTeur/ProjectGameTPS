using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMKartoshka : MonoBehaviour
{
    public KartoshkaNPC[] behaviours;
    public KartoshkaMob[] mobBehaviors;

    private int number;

    private void Start()
    {
        behaviours = GetComponents<KartoshkaNPC>();
        mobBehaviors = GetComponents<KartoshkaMob>();
        number = Random.Range(1, 3);
        IniInitializeBehaviours();
        Debug.Log(number);
    }

    private void IniInitializeBehaviours()
    {
        foreach (KartoshkaMob behaviour in mobBehaviors)
        {
            behaviour.enabled = false;
        }

        foreach (KartoshkaNPC behaviour in behaviours)
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
