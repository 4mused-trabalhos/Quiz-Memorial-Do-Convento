using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour {
  
    public GameObject _Music;
    public GameObject Button;
    private Image BtnImage;

    public Sprite On;
    public Sprite Off;

    void Start() {
        _Music = GameObject.FindGameObjectWithTag("Music");
        BtnImage = Button.GetComponent<Image>();
    }

    public void MusicToggle() {

        _Music.SetActive(!_Music.activeSelf);

        switch (_Music.activeSelf) {

            case true:
                BtnImage.sprite = On;
                break;
            
            default:
                BtnImage.sprite = Off;
                break;

        }

    }

}
