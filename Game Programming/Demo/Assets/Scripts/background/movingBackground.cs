using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBackground : MonoBehaviour
{
    public float bgSpeed = 0.1f;
    public Renderer bgRend;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //set background di chuyển
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
