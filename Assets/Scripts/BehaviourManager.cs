using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourManager : MonoBehaviour
{
    public MyBehaviour[] behaviours;
    public MyMobBehavior[] mobBehaviors;

    private int number;

    private void Start()
    {
        behaviours = GetComponents<MyBehaviour>();
        mobBehaviors = GetComponents<MyMobBehavior>();
        number = Random.Range(1,3);
        IniInitializeBehaviours();
        Debug.LogError(number);
    }

    private void IniInitializeBehaviours()
    {
        foreach (MyMobBehavior behaviour in mobBehaviors)
        {
            behaviour.enabled = false;
        }

        foreach (MyBehaviour behaviour in behaviours)
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
