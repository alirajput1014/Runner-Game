using UnityEngine;

public class leftmove : MonoBehaviour
{
    private playermovement PlayerSC;
    private float leftbound=-15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerSC=GameObject.Find("Player").GetComponent<playermovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerSC.gameover == false)
        {
            transform.Translate(Vector3.left * 10 * Time.deltaTime);
        }
        if(transform.position.x<leftbound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    
}
