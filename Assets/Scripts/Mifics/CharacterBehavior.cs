using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehavior : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject[] goodBehaviors;
    public GameObject[] badBehaviors;

    void Start()
    {
        List<GameObject> selectedCharacters = new List<GameObject>();

        // Выбираем двух персонажей для которых добавляем скрипт с плохим поведением
        int badBehaviorCount = 2;
        for (int i = 0; i < badBehaviorCount; i++)
        {
            int randomIndex = Random.Range(0, characters.Length);
            GameObject character = characters[randomIndex];
            selectedCharacters.Add(character);
            Instantiate(badBehaviors[randomIndex], character.transform);
        }

        // Для остальных персонажей добавляем скрипт с хорошим поведением
        foreach (GameObject character in characters)
        {
            if (!selectedCharacters.Contains(character))
            {
                Instantiate(goodBehaviors[Random.Range(0, goodBehaviors.Length)], character.transform);
            }
        }
    }
}