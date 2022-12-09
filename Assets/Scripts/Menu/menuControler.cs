using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuControler : MonoBehaviour
{

   public GameObject Mainmenu;
   public GameObject SettingsMenu;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Mainmenu.SetActive(true);
            SettingsMenu.SetActive(false);
        }
        
    }


    // Start is called before the first frame update
    public void callExitGame()
    {
        Application.Quit();
    }

    public void callSettings()
    {
        Mainmenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }

    public void callBack()
    {
        Mainmenu.SetActive(true);
        SettingsMenu.SetActive(false);
    }

    public void callPlay()
    {
        SceneManager.LoadScene(1);
    }

}
