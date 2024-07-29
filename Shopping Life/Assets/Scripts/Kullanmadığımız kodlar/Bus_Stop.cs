/*using UnityEngine;
using System.Collections;

public class BusController : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isMoving = false;
    private bool shouldWait = false;
    private Collider2D mainCollider; // Otobüsün ana collider'ý
    public Collider2D secondCollider; // Otobüsün ikinci collider'ý

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (isMoving && !shouldWait)
        {
            rb.velocity = new Vector2(-5f, 0f); // Buradaki (-5f, 0f) hýzý ayarlamak için kullanýlýr, istediðiniz hýza göre deðiþtirin.
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == secondCollider) // Ýkinci collider ile çarpýþma kontrolü
        {
            if (!mainCollider.IsTouching(secondCollider)) // Otobüsün ana collider'ý ikinci collider ile temas halinde deðilse, iþlemi yapma
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