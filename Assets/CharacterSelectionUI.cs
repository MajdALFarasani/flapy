using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelectionUI : MonoBehaviour
{
    public GameObject optionPrefab;

    public Transform prevCharacter;
    public Transform selectedCharacter;

    private void Start()
    {
        foreach (Character c in GameManeger.Instance.characters)
        {
            GameObject option = Instantiate(optionPrefab, transform);
            Button button = option.GetComponent<Button>();

            button.onClick.AddListener(() =>
            {
                GameManeger.Instance.SetCharacter(c);
                if (selectedCharacter != null)
                {
                    prevCharacter = selectedCharacter;
                }

                selectedCharacter = option.transform;
            });

            //Text text = option.GetComponentInChildren<Text>();
            //text.text = c.name;

            Image image = option.GetComponentInChildren<Image>();
            image.sprite = c.icon;

        }
    }
}
