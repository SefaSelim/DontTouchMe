using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextNumberAct : MonoBehaviour
{
    [SerializeField]private string _text;
    
    [SerializeField] private GameObject O;
    [SerializeField] private GameObject N;
    [SerializeField] private GameObject E;

    public void O_Active()
    {
        O.SetActive(true);
    }
    public void N_Active()
    {
        N.SetActive(true);
    }
    public void E_Active()
    {
        E.SetActive(true);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(_text);
    }
    
}
