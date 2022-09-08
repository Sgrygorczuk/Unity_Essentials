using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    
    //==================================================================================================================
    // Variables  
    //==================================================================================================================
    //The ball that we will spawn 
    [SerializeField] private GameObject preFab;
    //Where the ball will be spawned 
    private Transform _spawnPoint;
    //What object the ball will be the child of 
    private GameObject _ballGameObject;
    
    //All of the music audio clips 
    [SerializeField] private AudioClip[] audioClips;
    //All of the names of the songs 
    [SerializeField] private string[] audioNames;
    //Audio source that will play them
    private AudioSource _audioSource;
    //The text that will display the name 
    private TextMeshProUGUI _textMeshProUGUI;
    //The current position in the track list 
    private int _currentIndex;
    
    //==================================================================================================================
    // Base Methods 
    //==================================================================================================================
    
    //Connects the values and starts update to the current position in the track list 
    private void Start()
    {
        _spawnPoint = GameObject.Find("SpawnPoint").transform;
        _ballGameObject = GameObject.Find("Spheres").gameObject;

        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = audioClips[_currentIndex];
        _audioSource.Play();
        
        _textMeshProUGUI = GameObject.Find("Canvas").transform.Find("Song").GetComponent<TextMeshProUGUI>();
        _textMeshProUGUI.text = audioNames[_currentIndex];
    }
    
    //==================================================================================================================
    // Ball Controls   
    //==================================================================================================================

    //Creates a new ball 
    public void SpawnBall()
    {
        var spawn = Instantiate(preFab, _spawnPoint.position, Quaternion.identity);
        spawn.transform.parent = _ballGameObject.transform;
    }

    //Destroys all balls 
    public void ResetSpawns()
    {
        foreach (Transform child in _ballGameObject.transform) {
            Destroy(child.gameObject);
        }
    }
    
    //==================================================================================================================
    // Music Controls   
    //==================================================================================================================

    //Increase the track number and starts to play the song
    public void Next()
    {
        _currentIndex++;
        if (_currentIndex > audioClips.Length - 1)
        {
            _currentIndex = 0;
        }
        SetData();
    }

    //Decreases the track number and start to play the song 
    public void Previous()
    {
        _currentIndex--;
        if (_currentIndex < 0)
        {
            _currentIndex = audioClips.Length - 1;
        }
        SetData();
    }

    //Updates the text and audio to the new position and start to play the song 
    private void SetData()
    {
        _audioSource.clip = audioClips[_currentIndex];
        _textMeshProUGUI.text = audioNames[_currentIndex];
        _audioSource.Play();
    }
    
    //==================================================================================================================
    // Exit Button
    //==================================================================================================================
    public void GoToScene()
    {
        SceneManager.LoadScene($"Scene_Selector");
    }
    
}
