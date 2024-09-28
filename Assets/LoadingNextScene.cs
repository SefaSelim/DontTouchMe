using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingNextScene : MonoBehaviour
{
    [SerializeField] private GameObject D;
    public void LoadNewScene()
    {
        SceneManager.LoadScene("Finish");
    }

    public void DoneWriter()
    {
        D.SetActive(true);
    }

    public void LoadPartI()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
