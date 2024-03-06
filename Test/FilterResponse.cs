public class FilterResponse
{
    public FilterResponse(bool success, string message="", string error="")
    {
        Success = success;
        Message = message;
        Error = error;
    }

    public FilterResponse()
    {
        
    }

    public FilterResponse(bool success)
    {
        Success = success;
    }

    public void SetSuccessFull(string message)
    {
        Success = true;
        Message = message;
        Error = "";
    }

    public void SetFail(string error)
    {
        Success = false;
        Message = "";
        Error = error;
    }

    public bool Success { get; set; } = false;
    public string? Message { get; set; }
    public string? Error { get; set; }
}