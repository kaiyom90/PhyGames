using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
   // Use this for initialization
    void Awake ()
    {
        Destroy (this.gameObject, 1f);
    }
}
