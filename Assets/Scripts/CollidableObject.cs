using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D _Collider;

    private void Start(){
        _Collider = GetComponent<Collider2D>();
    }
}
