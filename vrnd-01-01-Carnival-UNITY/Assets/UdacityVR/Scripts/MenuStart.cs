using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStart : MonoBehaviour {

    public void startGame(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
