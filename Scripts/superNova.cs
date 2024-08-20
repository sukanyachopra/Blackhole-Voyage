using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superNova : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotateSpeed;
    void Start()
    {
        rotateSpeed=5;
    }
        void update() {
            transform.Rotate(0,rotateSpeed,0,Space.World);
        }
}
