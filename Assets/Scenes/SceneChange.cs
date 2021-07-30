using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NextScene(string next_scene)
    {
        SceneManager.LoadScene("Scene2");
    }

}
