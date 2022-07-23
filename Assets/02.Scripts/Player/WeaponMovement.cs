using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    private void FixedUpdate()
    {
        Vector2 origin = transform.parent.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float angle = Mathf.Atan2(mousePos.y - origin.y, mousePos.x - origin.x) * Mathf.Rad2Deg;

        transform.localScale = new Vector3(1, 1, 1);
        if (90 <= angle || angle <= -90)
        {
            transform.localScale = new Vector3(1, -1, 1);
        }

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
