using UnityEngine;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif

namespace CustomPlayerInput {
	public class PlayerInputCustom : MonoBehaviour {
        [Header("Prefabs")]
        public GameObject missile;

		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;
		public bool fire;

		[Header("Movement Settings")]
		public bool analogMovement;

        public GameObject attackRoot;
        public Camera mainCamera;
        ParticleSystem sprayParticles;

void Start() {
    sprayParticles = attackRoot.GetComponent<ParticleSystem>();
    sprayParticles.Stop();
}
 

#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
		public void OnMissileFire(InputValue value) {
			MissileFireInput();
		}

        public void OnSprayFire(InputValue value) {
            SprayFireInput(value);
        }
#else
	// old input sys if we do decide to have it (most likely wont)...
#endif
		public void MissileFireInput() {
			Instantiate(missile, new Vector3(attackRoot.transform.position.x, attackRoot.transform.position.y, attackRoot.transform.position.z), mainCamera.transform.rotation);
		}
        
        public void SprayFireInput(InputValue value) {
            Debug.Log("spraying..." + value.isPressed);
            if (value.isPressed) {
                sprayParticles.Play();
            } else {
                sprayParticles.Stop();
            }
        }

	}
	
}