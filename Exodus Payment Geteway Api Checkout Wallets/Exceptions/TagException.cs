﻿using Exodus.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exodus.Exceptions
{

    public class TagException : ExodusException
    {
        public override string Header { get; set; } = typeof(TagException).Name.Replace("Exception", "");
        public override EN_ErrorCodes ErrorCode { get; set; } = EN_ErrorCodes.TagException;
        public override string ErrorPath { get => base.ErrorPath; set => base.ErrorPath = value; }
        public TagException() : base("Tag Exeption")
        {
        }

        public TagException(string message)
            : base(message)
        {
        }

        public TagException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}