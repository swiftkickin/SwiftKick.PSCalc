using System.Management.Automation;

namespace SwiftKick.PSCalc
{
    [Cmdlet("Subtract", "Number")]
    [OutputType(typeof(Answer))]
    public class SubtractNumberCmdlet : Cmdlet
    {
        [Parameter]
        public int A { get; set; }

        [Parameter]
        public int B { get; set; }

        protected override void ProcessRecord()
        {
            var result = new Answer {Result = A - B};
            WriteObject(result);
        }
    }
}