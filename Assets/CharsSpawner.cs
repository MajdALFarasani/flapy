using UnityEngine;

public class CharsSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Instantiate(GameManeger.Instance.currentCharacter.prefab, transform.position,
            Quaternion.identity);
    }
}
