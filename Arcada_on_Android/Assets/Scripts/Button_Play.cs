using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button_Play : MonoBehaviour
{
    public void SceneLoad(int IndexScene)
    {
        SceneManager.LoadScene(IndexScene);
    }
}
