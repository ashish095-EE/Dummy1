using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;
    public float restartDelay = 1f;

    public void EndGame(){
        if(gameEnd == false){
            gameEnd = true;
            Invoke("Restart",restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
