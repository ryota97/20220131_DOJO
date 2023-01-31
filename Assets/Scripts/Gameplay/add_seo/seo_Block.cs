using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A block
/// </summary>	
public class seo_Block : Block
{
    #region Unity methods

    private int Collcount = 0;

    /// <summary>
    /// Destroys the block on collision with a ball
    /// </summary>
    /// <param name="coll">Coll.</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ball"))
        {
            Collcount += 1;
            //if (Collcount == 4)
            //{
            //    gameObject.GetComponent<Sprite>() = Sprite.standerd;
            //}

            if (Collcount == 5)
            {
                Destroy(gameObject);
            }
        }
    }

    #endregion
}
