using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Button : MonoBehaviour {
    public string Scene_Name;
    public void Scene_Change(){
        print("changing");
        SceneManager.LoadScene(Scene_Name);

    }
}
