using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    public void RMenu ()
    {
        SceneManager.LoadScene(0);
    }
    public void Rep ()
    {
        SceneManager.LoadScene(1);
    }

    public void Store()
    {
        SceneManager.LoadScene(3);
    }

    public void Dell()
    {
        PlayerPrefs.DeleteAll();
    }
}
