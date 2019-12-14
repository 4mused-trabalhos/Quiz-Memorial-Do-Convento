using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoChangeScene : MonoBehaviour {

    void Start() {
            this.gameObject.GetComponent<AudioSource>().Play();
    }
    
    void LateUpdate()
    {

        if(!this.gameObject.GetComponent<AudioSource>().isPlaying) {
            SceneManager.LoadScene("Quiz");
        }
            
    }

}