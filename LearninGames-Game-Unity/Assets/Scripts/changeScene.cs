using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Scene_Changer : MonoBehaviour
{
    // Start is called before the first frame update
    public int SceneNumber;
    public void Next_scene()
    {
        SceneManager.LoadScene(SceneNumber);

    }

    // Update is called once per frame
    public void QuitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #else
        Application.quit();
        #endif
    }
}
