using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public System.String nextScene;
    public void SceneSwitcher()
    {
        SceneManager.LoadScene(nextScene);
    }

}
