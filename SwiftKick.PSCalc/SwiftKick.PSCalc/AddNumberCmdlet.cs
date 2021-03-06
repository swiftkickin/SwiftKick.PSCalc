﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

// https://www.red-gate.com/simple-talk/dotnet/net-development/using-c-to-create-powershell-cmdlets-the-basics/#third

namespace SwiftKick.PSCalc
{
    [Cmdlet("Add", "Number")]
    [OutputType(typeof(Answer))]
    public class AddNumberCmdlet : Cmdlet
    {
        [Parameter]
        public int A { get; set; }

        [Parameter]
        public int B { get; set; }

        protected override void ProcessRecord()
        {
            var result = new Answer { Result = A + B };
            WriteObject(result);
        }
    }
}
