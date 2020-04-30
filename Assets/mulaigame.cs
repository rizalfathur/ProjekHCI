using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mulaigame : MonoBehaviour
{
    public string namaScene;
    
    public void mulaike()
    {
        Scene sceneIni = SceneManager.GetActiveScene();

        if (sceneIni.name != namaScene)
        {
            SceneManager.LoadScene(namaScene);
        }
    }
}
