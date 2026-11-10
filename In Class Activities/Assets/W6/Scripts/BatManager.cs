using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatManager : MonoBehaviour
{
    [SerializeField] private float _overlapDistance;
    [SerializeField] private float _interactDistance;
    [SerializeField] private float _timeBetweenNewMessages = 0.5f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private TMP_Text _reactionUiPrefab;
    [SerializeField] private BatW6[] _bats;
    [SerializeField] private string[] _messages;

    private float[] _newTextTimers;

    private void Start()
    {
        _newTextTimers = new float[_bats.Length];
    }

    private void Update()
    {
        for (int i = 0; i < _bats.Length; i++)
        {
            _newTextTimers[i] += Time.deltaTime;

            BatW6 bat = _bats[i];
            float distance = Vector3.Distance(bat.transform.position, _playerTransform.position);
            if (distance < _interactDistance)
            {
                bat.StartChasing(_playerTransform);
            }
            else
            {
                bat.StopChasing();
            }

            if (distance < _overlapDistance)
            {
                CreateReactions(bat);
            }
        }
    }

    private void CreateReactions(BatW6 bat)
    {
        int messageIndex = Random.Range(0, _messages.Length);
        SpawnReactionUI(bat, _messages[messageIndex]);
    }

    private void SpawnReactionUI(BatW6 bat, string message)
    {
        int index = System.Array.IndexOf(_bats, bat);

        GridLayoutGroup layout = bat.GetComponentInChildren<GridLayoutGroup>();
        if (layout != null && _newTextTimers[index] >= _timeBetweenNewMessages)
        {
            _newTextTimers[index] = 0f;
            TMP_Text textObj = Instantiate(_reactionUiPrefab, layout.transform);
            textObj.text = message;
        }
    }
}
