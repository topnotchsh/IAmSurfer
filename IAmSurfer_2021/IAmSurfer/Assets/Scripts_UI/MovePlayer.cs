﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public JoystickValue value;

    void Update()
    {
        transform.Translate(value.joyTouch / 15);
    }
}
