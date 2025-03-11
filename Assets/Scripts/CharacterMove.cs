using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    void Update(){
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, y);
    }
}
