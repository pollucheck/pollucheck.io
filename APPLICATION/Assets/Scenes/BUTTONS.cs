using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTONS : MonoBehaviour
{
    public void mainPage()
    {
        SceneManager.LoadScene(1);
    }
    public void payment()
    {
        SceneManager.LoadScene(2);
    }
    public void AAA()
    {
        SceneManager.LoadScene(3);
    }
    public void AAB()
    {
        SceneManager.LoadScene(4);
    }
    public void AAC()
    {
        SceneManager.LoadScene(4);
    }
    public void BACK()
    {
        SceneManager.LoadScene(1);
    }
}
