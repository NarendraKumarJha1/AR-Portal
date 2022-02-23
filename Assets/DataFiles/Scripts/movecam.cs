using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecam : MonoBehaviour
{


    public int speed;


    void Start()
    {
        
    }

    void Update()
    {
        float movecam = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(0,0,movecam);

        float rotate=0;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotate = rotate - 1;
            transform.Rotate(0, rotate, 0);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotate = rotate + 1;
            transform.Rotate(0, rotate, 0);
        }

    }
}
