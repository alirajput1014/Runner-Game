using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float jumpforce = 5f;
    private Rigidbody rb;
    private bool isground = true;
    public bool gameover=false;
    public AudioClip jumpsound;
    public AudioClip deathsound;
    private AudioSource PlayerAS;

    public AudioClip backSound;
    private AudioSource backAS;

    public Gameover_screen gameover_Screen;
    private float deathdelay = 2f;
    public bool gamestated=false;

    private Animator PlayerAnim;

    public ParticleSystem explosion;
    public ParticleSystem dirt;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb= GetComponent<Rigidbody>();

        PlayerAS = GetComponent<AudioSource>();

        backAS = GetComponent<AudioSource>();
        backAS.clip=backSound;
        backAS.loop = true;
        backAS.volume = 0.3f;

        PlayerAnim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isground && gameover==false && gamestated)
        {
            dirt.Stop();
            PlayerAS.PlayOneShot(jumpsound);
            rb.AddForce(Vector3.up * jumpforce , ForceMode.Impulse);
            isground = false;

            PlayerAnim.SetTrigger("Jump_trig");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            dirt.Play();
            isground = true;
            Debug.Log("ground");
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Gameover");
            PlayerAS.PlayOneShot(deathsound, 1.0f);
            gameover = true;
            PlayerAnim.SetBool("Death_b", true);
            PlayerAnim.SetInteger("DeathType_int", 1);
            explosion.Play();
            dirt.Stop();
            Debug.Log("Gameover");
            backAS.Stop();
            StartCoroutine(DelayedGameOver());
            //gameover_Screen.ShowGameOver();
        }
    }
    private System.Collections.IEnumerator DelayedGameOver()
    {
        yield return new WaitForSecondsRealtime(deathdelay);
            gameover_Screen.ShowGameOver();
    }
    public void StartBackgroundMusic()
{
    if (backAS != null && backSound != null)
        backAS.Play();
}

   
}
