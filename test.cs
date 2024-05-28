using system
using [System.Serializable]
public class testException : System.Exception
{
  public testException() { }
  public testException(string message) : base(message) { }
  public testException(string message, System.Exception inner) : base(message, inner) { }
  protected testException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}