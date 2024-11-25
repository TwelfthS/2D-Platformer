using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ButtonScript : MonoBehaviour
{
    public Tile highlightTileOne;
    public Tile highlightTileTwo;
    public Tile highlightTileThree;
    public Tilemap highlightMap;
    private Collider2D wall;
    private AudioSource clickSound;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.Find("Wall").GetComponent<Collider2D>();
        clickSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Vector3Int currentCell = highlightMap.WorldToCell(transform.position);
        currentCell.x += 1;
        highlightMap.SetTile(currentCell, highlightTileOne);
        currentCell.y += 1;
        highlightMap.SetTile(currentCell, highlightTileTwo);
        currentCell.y += 1;
        highlightMap.SetTile(currentCell, highlightTileThree);
        wall.enabled = false;
        GetComponent<Renderer>().enabled = false;
        clickSound.Play();
    }
    private void OnTriggerExit2D(Collider2D collision) {
        GetComponent<Renderer>().enabled = true;
    }
}
