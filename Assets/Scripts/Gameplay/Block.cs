using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A block
/// </summary>	
public class Block : MonoBehaviour
{
    #region Unity methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    [SerializeField]
    GameObject prefabExplosion;
    void Start()
    {

    }

    /// <summary>
	/// Update is called once per frame
	/// </summary>	
    void Update()
    {
        
    }

    /// <summary>
    /// Destroys the block on collision with a ball
    /// </summary>
    /// <param name="coll">Coll.</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
<<<<<<< HEAD
            Instantiate<GameObject>(prefabExplosion, transform.position, Quaternion.identity);
=======
>>>>>>> b3a51123685a66cd35bff95a7ae07304ce78df1d
            Destroy(gameObject);
        }
    }

    #endregion
}
