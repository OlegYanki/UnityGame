using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {

    void OnMouseDown ()
    {
        SceneManager.LoadScene("main");
        Player.lose = false;
    }
}
