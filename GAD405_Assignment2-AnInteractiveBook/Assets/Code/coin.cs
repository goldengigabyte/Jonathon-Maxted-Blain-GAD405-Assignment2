using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
    public void Collict(){
        var Game = FindObjectOfType<Adventure_Game>();
        Game.Coins += Random.Range(1, 10);
    }
}
