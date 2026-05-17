using UnityEngine;

public class startmanue : MonoBehaviour
{
    public GameObject startUI;
    public playermovement PlayerSC;


    void Start()
    {

            startUI.SetActive(true);
            Time.timeScale = 0f;
            PlayerSC.gamestated = false;
       
    }

    public void startgame()
    {
        startUI.SetActive(false);
        PlayerSC.gamestated = true;
        Time.timeScale = 1f;
        PlayerSC.StartBackgroundMusic();

        
    }
}
