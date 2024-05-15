using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 4;
    private float move;
    private Rigidbody2D rb;

    //The player's inventory
    public float metal = 0;
    public float wood = 0;

    //Text to signify the materials that the player has
    public TextMeshProUGUI metaltext;
    public TextMeshProUGUI woodtext;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

        //Keep text updated according to their stats
        metaltext.text = ("Metal: " + metal);
        woodtext.text = ("Wood: " + wood);
    }
}
