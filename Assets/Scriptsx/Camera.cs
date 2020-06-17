using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField]
    private float xMax, yMax, xMin, yMin;

    private Transform hedef;
    // Start is called before the first frame update
    void Start()
    {
      //  hedef = Object.FindObjectOfType<Player>().transform;
        hedef = GameObject.Find("Run__000").transform;
        Debug.Log(hedef.name);
    }




    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector2(Mathf.Clamp(hedef.position.x, xMin, xMax), Mathf.Clamp(hedef.position.y, yMin, yMax));
    }
}
