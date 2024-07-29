/*using UnityEngine;
using System.Collections;

public class BusController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isMoving = false;
    private bool shouldWait = false;
    private Collider2D mainCollider; // Otob�s�n ana collider'�
    public Collider2D secondCollider; // Otob�s�n ikinci collider'�

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (isMoving && !shouldWait)
        {
            rb.velocity = new Vector2(-5f, 0f); // Buradaki (-5f, 0f) h�z� ayarlamak i�in kullan�l�r, istedi�iniz h�za g�re de�i�tirin.
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == secondCollider) // �kinci collider ile �arp��ma kontrol�
        {
            if (!mainCollider.IsTouching(secondCollider)) // Otob�s�n ana collider'� ikinci collider ile temas halinde de�ilse, i�lemi yapma
                return;

            isMoving = false;
            shouldWait = true;
            StartCoroutine(ResumeMovementAfterDelay(7f)); // 7 saniye bekledikten sonra hareketi devam ettir
        }
    }

    IEnumerator ResumeMovementAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        isMoving = true;
        shouldWait = false;
    }
}
*/