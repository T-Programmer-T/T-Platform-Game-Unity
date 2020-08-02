using System.Collections;

using System.Collections.Generic;

using System.Net.Http.Headers;

using UnityEngine;

  public class JumpPlatform : MonoBehaviour
  {
      private void OnCollisionEnter2D(Collision2D collision)
      
      {

         if (collision.gameObject.tag == "Player")
         {

             collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 2500));
        
         }
       
       }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
