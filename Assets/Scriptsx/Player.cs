using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animator myAnimator;

    private Rigidbody2D myRigidbody;
    public Button area;
  
    [SerializeField]
    private float hiz;
    private bool sagaBak;

    public bool jumpS=false;
    public float jumpHeight = 4;
    // Start is called before the first frame update
    void Start()
    {
        sagaBak = true;
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        TemelHareketler(yatay);
        YonCevir(yatay);
    }

    void TemelHareketler(float yatay){
        myRigidbody.velocity = new Vector2(yatay*hiz, myRigidbody.velocity.y);
        //Debug.Log(yatay);
        myAnimator.SetFloat("karakterHizi", Mathf.Abs(yatay));
    }

    void YonCevir(float yatay)
    {
        if(yatay >0 && !sagaBak || yatay<0 && sagaBak)
        {
            sagaBak = !sagaBak;
            Vector3 yon = transform.localScale;
            yon.x *= -1;
            transform.localScale = yon;
        }
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
        jumpS = true;
        //var obj = other.gameObject;
        if(other.gameObject.tag == "coin")
        {
            //other.gameObject.SetActive(false);
            Debug.Log("collision");
            Destroy(other.gameObject);
        }
       Debug.Log(other.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D other)
    {
        var obj = other.gameObject;
        if(obj.name == "zemin")
        {
            Debug.Log("çıkış");
            jumpS = false;
        }
    }
}
