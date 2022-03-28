using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;
    public Transform myLight;

    private Rigidbody2D _rigidbody;

    private SpriteRenderer _sprite;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
    }



    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (movement > 0)
        {
            _sprite.flipX = false;
            if (myLight.localScale.x < 0)
            { myLight.localScale = Vector3.Scale(myLight.localScale, new Vector3(-1, 1, 1)); }
        }
        else
        {
            if (movement != 0)
            {
                _sprite.flipX = true;
                if (myLight.localScale.x > 0)
                { myLight.localScale = Vector3.Scale(myLight.localScale, new Vector3(-1, 1, 1)); }
            }
        }
    }
}
