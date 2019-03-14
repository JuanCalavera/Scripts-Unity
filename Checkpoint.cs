using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    [SerializeField]
    private GameObject _effect, _pergaminho, _portal, _joystick;
    public CharController _charControl;
    private bool _turn = false;
    [SerializeField]
    private Joystick _joystickhandle;
    [SerializeField] private Toggle _isA;
    [SerializeField] private Toggle _isB;
    [SerializeField] private Toggle _isC;
    private int _resposta;
    [SerializeField] private int _correta;

    void Awake()
    {
        _charControl = GameObject.FindObjectOfType<CharController>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _effect.SetActive(true);
            _joystickhandle.handle.anchoredPosition = Vector2.zero;
            if (_turn == false)
            {
                _pergaminho.SetActive(true);
                _charControl._switchControl = false;

            }
        }

    }
    public void ActiveToggle()
    {
        if (_isA.isOn)
        {
            _resposta = 1;
        }
        if (_isB.isOn)
        {
            _resposta = 2;
        }
        if (_isC.isOn)
        {
            _resposta = 3;
        }
    }

    public void PressButton()
    {
        ActiveToggle();

        if (_correta == _resposta)
        {
            _turn = true;
            _charControl._switchControl = true;
            _pergaminho.SetActive(false);
        }
    }
}