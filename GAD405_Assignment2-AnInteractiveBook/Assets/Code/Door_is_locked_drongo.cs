using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_is_locked_drongo : MonoBehaviour {
    public void TryOpen(){
        var game = FindObjectOfType<Adventure_Game>();
        game.ur_a_mess.text = "\"Eh? It's locked ya drongo!\" \n \n I guess I'll need a key";
    }
}
