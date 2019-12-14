using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistent : MonoBehaviour {

    void Start() {

        DontDestroyOnLoad(this.gameObject);
        
    }
    
}
