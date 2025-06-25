using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public static GameManeger Instance;

    public Character[] characters;

    public Character currentCharacter;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (characters.Length > 0 )
        {
            currentCharacter = characters[0];   
        }
    }

    public void SetCharacter(Character character)
    {
        currentCharacter = character;
    }
}
