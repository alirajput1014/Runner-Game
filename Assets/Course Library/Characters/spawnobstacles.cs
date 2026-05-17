using UnityEngine;

public class obstaclemovement : MonoBehaviour
{
    public GameObject[] obstacleprefabs;
    private playermovement PlayerSC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerSC = GameObject.Find("Player").GetComponent<playermovement>();
        InvokeRepeating("Spawn", 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        if (PlayerSC.gameover == false)
        {
            int randomindex = Random.Range(0, obstacleprefabs.Length);
            Vector3 pos = new Vector3(30, 0, 0);
            Instantiate(obstacleprefabs[randomindex], pos, Quaternion.identity);
           
        }
       

    }
}
