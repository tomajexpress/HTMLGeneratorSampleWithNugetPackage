﻿using System;

namespace API.Controls
{
    public class Input : Control
    {
        public string InputType { get; set; }

        public override string Html()
        {
            return string.Format("{0}<input type='{1}' {2} {3}/>{0}", Environment.NewLine, InputType, GenerateAttributes(), GenerateStyles());
        }
    }
}
