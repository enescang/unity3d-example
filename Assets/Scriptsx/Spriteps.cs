using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spriteps : MonoBehaviour
{
    [SerializeField]
    public GameObject obj;
    public Button btn;

    public Player pp;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
        btn.onClick.AddListener(HiJump);
    }

 public void HiJump()
    {
        if (pp.jumpS)
        {
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, pp.jumpHeight), ForceMode2D.Impulse);
        }
    }
}
