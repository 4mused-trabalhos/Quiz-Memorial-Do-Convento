using UnityEngine;

public class sound : MonoBehaviour
{

    private GameObject Audio_Holder;
    private AudioSource Audio;

    void Start() {

        Audio_Holder = this.gameObject;
        Audio = Audio_Holder.GetComponent<AudioSource>();
        
    }


    void Update() {

        if(!Audio.isPlaying) {
            Audio_Holder.SetActive(false);
        }
        
    }

}