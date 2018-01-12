﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeModifier : SpellComponent {

    // Use this for initialization
    public override void applyAffect(GameObject spell)
    {
        //SpellCore spellCoreScript = spell.GetComponent<SpellCore>();
        //spellCoreScript.sizeMulti *= (float)1.5;

        spell.transform.localScale = spell.transform.localScale * 1.5f;

    }
}
