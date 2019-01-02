using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour {
    public string Scene_Name;
    private void OnTriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene(Scene_Name);
    }
}
