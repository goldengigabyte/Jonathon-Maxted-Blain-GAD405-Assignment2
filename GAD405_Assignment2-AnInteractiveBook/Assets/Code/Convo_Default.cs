using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convo_Default : MonoBehaviour {
    public void Talk()
    {
        var game = FindObjectOfType<Adventure_Game>();
        game.ur_a_mess.text = "\"Hey!\" \n \n He looks... odd. \n Artistic choices? ";
    }
}
