using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class i_has_keesburger : MonoBehaviour{
    public void Gimme_Kee()
    {
        var game = FindObjectOfType<Adventure_Game>();
        game.ur_a_mess.text = "\"Hm? yea, I has kee, u want kee?\n ok.\" \n oookay? what happened? never mind I have the key now...";
        game.Key.gameObject.SetActive(true);
    }
}
