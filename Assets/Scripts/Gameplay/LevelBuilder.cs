using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Builds a level
/// </summary>	
public class LevelBuilder : MonoBehaviour
{
    #region Fields

    [SerializeField]
    GameObject prefabPaddle;

    [SerializeField]
    GameObject prefabStandardBlock;

<<<<<<< HEAD
    [SerializeField]
    GameObject prefabStandardBlock2;//add-horada

    [SerializeField]
    GameObject prefabadd_seoBlock;

=======
>>>>>>> b3a51123685a66cd35bff95a7ae07304ce78df1d
    #endregion

    #region Unity methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        Instantiate(prefabPaddle);

        // retrieve block size
        GameObject tempBlock = Instantiate<GameObject>(prefabStandardBlock);
        BoxCollider2D collider = tempBlock.GetComponent<BoxCollider2D>();
        float blockWidth = collider.size.x;
        float blockHeight = collider.size.y;
        Destroy(tempBlock);

        //add-horada//////////////////////////////////////////////////////////////////////
        GameObject tempBlock2 = Instantiate<GameObject>(prefabStandardBlock2);
        BoxCollider2D collider2 = tempBlock2.GetComponent<BoxCollider2D>();
        float blockWidth2 = collider2.size.x;
        float blockHeight2 = collider2.size.y;
        Destroy(tempBlock2);
        //////////////////////////////////////////////////////////////////////////////////

        // calculate blocks per row and make sure left block position centers row
        float screenWidth = ScreenUtils.ScreenRight - ScreenUtils.ScreenLeft;
        int blocksPerRow = (int)(screenWidth / blockWidth);
        float totalBlockWidth = blocksPerRow * blockWidth;
        float leftBlockOffset = ScreenUtils.ScreenLeft +
            (screenWidth - totalBlockWidth) / 2 +
            blockWidth / 2;

        float topRowOffset = ScreenUtils.ScreenTop -
            (ScreenUtils.ScreenTop - ScreenUtils.ScreenBottom) / 5 -
            blockHeight / 2;

        // add rows of blocks
        Vector2 currentPosition = new Vector2(leftBlockOffset, topRowOffset);
        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < blocksPerRow; column++)
            {
                if (column % 2 == 0)
                {
                    Instantiate(prefabStandardBlock, currentPosition,
                    Quaternion.identity); currentPosition.x += blockWidth;
                }
                else
                {
                    Instantiate(prefabStandardBlock2, currentPosition,
                        Quaternion.identity); currentPosition.x += blockWidth;
                }
            }

            // move to next row
            currentPosition.x = leftBlockOffset;
            currentPosition.y += blockHeight;
        }
<<<<<<< HEAD

        Vector2 currentPrePosition = new Vector2(leftBlockOffset, topRowOffset-(2* blockHeight));
        for (int column = 0; column <blocksPerRow-2; column++)
        {

            currentPrePosition.x = leftBlockOffset + blockWidth * Random.Range(0, blocksPerRow);
            currentPrePosition.y = topRowOffset - blockHeight * Random.Range(2, 6);
            Instantiate(prefabadd_seoBlock, currentPrePosition, Quaternion.identity);
            }
=======
>>>>>>> b3a51123685a66cd35bff95a7ae07304ce78df1d
    }

    /// <summary>
	/// Update is called once per frame
	/// </summary>	
    void Update()
    {

    }

    #endregion
}
