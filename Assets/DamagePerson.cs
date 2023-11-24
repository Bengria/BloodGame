using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePerson : MonoBehaviour
{

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
        player.transform.position = new Vector3(-2.76f, -2.89f, 0);

    }
}
