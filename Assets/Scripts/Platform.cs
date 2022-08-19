using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    
    public class Platform : MonoBehaviour
    {

        public Transform player;

        public AudioSource platformBreak;
        

        public void Start()
        {
            // player = GameObject.FindGameObjectWithTag("Player").transform;
            // audioSource = GetComponent<AudioSource>();
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                player.CurrentPlatform = this;
            }
        }

        

        public void Update()
        {
            if (transform.position.y > player.position.y)
            {
                // Debug.Log("Platform Break!");
                // platformBreak.Play();
                Destroy(gameObject);
                
                
            }
        }
    }


}

