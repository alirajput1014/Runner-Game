using UnityEngine;

public class background_repeat : MonoBehaviour
{
    private Vector3 Startpos;
    private float repeatwidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Startpos = transform.position;
        repeatwidth = GetComponent<BoxCollider>() .size.x /2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < Startpos.x -repeatwidth)
        {
            transform.position = Startpos;
        }
    }
}
