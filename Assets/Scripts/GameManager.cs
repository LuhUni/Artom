using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void botão()
    {
        menu.SetActive(true);
    }

    public void voltar()
    {
        menu.SetActive(false);
    }

    public void link()
    {
        Application.OpenURL("https://drive.google.com/file/d/1CFgmoDIG08c5_WbACltFSub1bu9cum4n/view?usp=sharing");
        menu.SetActive(false);
    }
}
