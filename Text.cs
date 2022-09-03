using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Hit!!!!");
    }
}
