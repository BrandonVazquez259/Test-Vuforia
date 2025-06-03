using UnityEngine;
using UnityEngine.Events;
public class FailChecker : MonoBehaviour
{
    [SerializeField]

    private UnityEvent _onNoteDestroyed;

    private void OnTiggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            _onNoteDestroyed?.Invoke();
            Destroy(collision.gameObject);
        }

     }
}
