using Ilumination;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
	public class PlayerController : MonoBehaviour
	{
		[Header("Player")]
		[SerializeField] private GameObject player;
		[SerializeField] private GameObject candle;
		[SerializeField] private float speed;
		public bool isHidden { get; set; } = false;
		private Animator playerAnimator;
		private Vector3 movement;
		private SpriteRenderer candleSprite;
		private SpriteRenderer playerSprite;
		private Rigidbody rb;
		private PlayerInput input;

		private void Start()
		{
			playerSprite = player.GetComponent<SpriteRenderer>();
			candleSprite = candle.GetComponent<SpriteRenderer>();
			playerAnimator = player.GetComponent<Animator>();

			rb = GetComponent<Rigidbody>();
			input = GetComponent<PlayerInput>();
		}

		void Update()
		{
			HandleMovement();
		}

		void HandleMovement()
		{
			movement = input.actions["Move"].ReadValue<Vector2>(); 
			playerAnimator.SetFloat("movement", movement.magnitude * speed);

			if (movement.magnitude > 0.1f)
			{
				// Right movement
				if (movement.x > 0)
				{
					playerSprite.flipX = false;
					candleSprite.flipX = true;
					candleSprite.transform.localPosition = new Vector3(-0.04f, 0.05f, -0.01f);
				}

				// Left movement
				else
				{
					playerSprite.flipX = true;
					candleSprite.flipX = false;
					candleSprite.transform.localPosition = new Vector3(0.04f, 0.05f, -0.01f);
				}
			}
		}

		private void FixedUpdate()
		{
			rb.MovePosition(new Vector3(rb.position.x + speed * Time.fixedDeltaTime * movement.x, 0, rb.position.z + speed * Time.fixedDeltaTime * movement.z));
		}
	}
}