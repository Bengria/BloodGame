using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePerson : MonoBehaviour
{
    public Vector3 perPos;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<XpController>())
        {
            StartCoroutine(SomeCoroutine(collision.gameObject));
        }
    }
    private IEnumerator SomeCoroutine(GameObject player)
    {
        yield return new WaitForSeconds(0.3f);
        player.GetComponent<XpController>().playerXP -= 10;
        player.transform.position = perPos;

    }
}
