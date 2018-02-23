using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour {

    public GameObject bomb;
    float TimeBirth = 0.8f;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn ()
    {
        while (!Player.lose)
        {
            Instantiate(bomb, new Vector2( Random.Range(-3f, 3f), 7.85f), Quaternion.identity);
            yield return new WaitForSeconds(TimeBirth);
            if (TimeBirth > 0.3f)
                TimeBirth -= 0.001f;
        }
    }
}
