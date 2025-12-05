using UnityEngine;

public class SeesawController : MonoBehaviour
{
    public float tiltSpeed = 30f;
    public float returnSpeed = 20f;
    public float targetAngle = 0f;

    private void Update()
    {
        // ƒ}ƒEƒX‰Ÿ‚µ‚Ä‚é ¨ ¶‚ÉŒX‚­
        if (Input.GetMouseButton(0))
        {
            targetAngle = -20f;    // ¶‚Ö
        }
        else
        {
            targetAngle = 20f;     // ‰E‚Ö
        }

        // Œ»ÝŠp“x
        float current = transform.eulerAngles.z;
        if (current > 180f) current -= 360f;

        // ‚È‚ß‚ç‚©‚ÉŠp“xˆÚ“®
        float speed = Input.GetMouseButton(0) ? tiltSpeed : returnSpeed;
        float newAngle = Mathf.Lerp(current, targetAngle, Time.deltaTime * speed);

        transform.rotation = Quaternion.Euler(0, 0, newAngle);
    }
}
