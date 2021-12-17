namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(succes:true,message)
        {

        }

        public SuccessResult(bool succes) : base(true)
        {

        }
    }
}