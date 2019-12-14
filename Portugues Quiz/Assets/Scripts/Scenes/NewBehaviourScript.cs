using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    void Start() {
            this.gameObject.GetComponent<AudioSource>().Play();
    }
    
    void LateUpdate()
    {

        if(!this.gameObject.GetComponent<AudioSource>().isPlaying) {
            SceneManager.LoadScene("Menu");
        }
            
    }
}
