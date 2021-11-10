using HL7.Dotnetcore;

namespace HL7Reproduce
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message();

            var encoding = new HL7Encoding();

            var msg = new Segment("MSG", encoding);
            message.AddNewSegment(msg);

            message.SerializeMessage(true);
        }
    }
}
