using UnityEngine;

public class GladiatorController : MonoBehaviour {

    Animator anim;

    public GameObject player;

    public float speed1 = 4f;
    public float speed2 = 4f;
    public float speed3 = 4f;
    public float speed4 = 4f;

    void Start()
    {
        anim = player.GetComponentInChildren<Animator>();
    }
    
    void Update () {

        if (gameObject.tag == "Player")
        {
            //Player1
            if (anim != null) // checks if the player still exists.
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    anim.SetBool("WalkUp", true);

                    player.transform.Translate(Vector2.up * speed1 * Time.deltaTime);

                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkUp", false);
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    anim.SetBool("WalkRight", true);
                    player.transform.Translate(Vector2.right * speed1 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkRight", false);
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    anim.SetBool("WalkLeft", true);
                    player.transform.Translate(Vector2.left * speed1 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkLeft", false);
                }


                if (Input.GetKey(KeyCode.DownArrow))
                {
                    anim.SetBool("WalkDown", true);
                    player.transform.Translate(Vector2.down * speed1 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkDown", false);
                }
            }
        }

        if (gameObject.tag == "Player2")
        {
            //Player2
            if (anim != null)
            {
                if (Input.GetKey(KeyCode.Keypad8))
                {
                    anim.SetBool("WalkUp", true);
                    player.transform.Translate(Vector2.up * speed2 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkUp", false);
                }

                if (Input.GetKey(KeyCode.Keypad6))
                {
                    anim.SetBool("WalkRight", true);
                    player.transform.Translate(Vector2.right * speed2 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkRight", false);
                }

                if (Input.GetKey(KeyCode.Keypad4))
                {
                    anim.SetBool("WalkLeft", true);
                    player.transform.Translate(Vector2.left * speed2 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkLeft", false);
                }

                if (Input.GetKey(KeyCode.Keypad2))
                {
                    anim.SetBool("WalkDown", true);
                    player.transform.Translate(Vector2.down * speed2 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkDown", false);
                }
            }
        }

        if (gameObject.tag == "Player3")
        {
            //Player3
            if (anim != null)
            {
                if (Input.GetKey(KeyCode.I))
                {
                    anim.SetBool("WalkUp", true);
                    player.transform.Translate(Vector2.up * speed3 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkUp", false);
                }

                if (Input.GetKey(KeyCode.L))
                {
                    anim.SetBool("WalkRight", true);
                    player.transform.Translate(Vector2.right * speed3 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkRight", false);
                }

                if (Input.GetKey(KeyCode.J))
                {
                    anim.SetBool("WalkLeft", true);
                    player.transform.Translate(Vector2.left * speed3 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkLeft", false);
                }

                if (Input.GetKey(KeyCode.K))
                {
                    anim.SetBool("WalkDown", true);
                    player.transform.Translate(Vector2.down * speed3 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkDown", false);
                }
            }
        }

        if (gameObject.tag == "Player4")
        {
            //Player4
            if (anim != null)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    anim.SetBool("WalkUp", true);
                    player.transform.Translate(Vector2.up * speed4 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkUp", false);
                }

                if (Input.GetKey(KeyCode.D))
                {
                    anim.SetBool("WalkRight", true);
                    player.transform.Translate(Vector2.right * speed4 * Time.deltaTime);
                    anim.SetBool("Idle", false);
                }
                else
                {
                    anim.SetBool("WalkRight", false);
                }

                if (Input.GetKey(KeyCode.A))
                {
                    anim.SetBool("WalkLeft", true);
                    player.transform.Translate(Vector2.left * speed4 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkLeft", false);
                }

                if (Input.GetKey(KeyCode.S))
                {
                    anim.SetBool("WalkDown", true);
                    player.transform.Translate(Vector2.down * speed4 * Time.deltaTime);
                }
                else
                {
                    anim.SetBool("WalkDown", false);
                }
            }
        }
    }
}

