using UnityEngine;

class Jumper : MonoBehaviour
{
    [SerializeField] float speed = 10;

    void Update()
    {
        Vector3 jumpVector = Vector3.zero;
        jumpVector += GetJump(KeyCode.W, KeyCode.UpArrow, Vector3.up * 2);
        jumpVector += GetJump(KeyCode.A, KeyCode.LeftArrow, Vector3.left * 2);
        jumpVector += GetJump(KeyCode.S, KeyCode.DownArrow, Vector3.down);
        jumpVector += GetJump(KeyCode.D, KeyCode.RightArrow, Vector3.right);

        transform.position += jumpVector;
    }

    Vector3 GetJump(KeyCode key1, KeyCode key2, Vector3 dir)
    {
        bool anyKeyPressed = Input.GetKeyDown(key1) || Input.GetKeyDown(key2);
        if (anyKeyPressed)
            return dir;
        else
            return Vector3.zero;
    }
}
