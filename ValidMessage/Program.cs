using HL7.Dotnetcore;
using System;

namespace ValidMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message();

            message.AddSegmentMSH(null, null, null, null, null, "ORU^R01^ACK", "1", "T", "2.3");

            var encoding = new HL7Encoding();

            var pid = new Segment("PID", encoding);
            pid.AddEmptyField();
            pid.AddEmptyField();
            pid.AddNewField("1");
            pid.AddEmptyField();
            pid.AddNewField("test");
            message.AddNewSegment(pid);

            var pv1 = new Segment("PV1", encoding);
            pv1.AddEmptyField();
            pv1.AddNewField("U");
            message.AddNewSegment(pv1);

            var obr = new Segment("OBR", encoding);
            obr.AddEmptyField();
            obr.AddEmptyField();
            obr.AddEmptyField();
            obr.AddNewField("test");
            obr.AddEmptyField();
            obr.AddEmptyField();
            obr.AddNewField("2021");
            message.AddNewSegment(obr);

            var obx = new Segment("OBX", encoding);
            obx.AddEmptyField();
            obx.AddNewField("TX");
            obx.AddNewField("1");
            obx.AddEmptyField();
            obx.AddNewField("1");
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddNewField("F");
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddEmptyField();
            obx.AddNewField("APT");
            message.AddNewSegment(obx);

            var spm = new Segment("SPM", encoding);
            spm.AddEmptyField();
            spm.AddEmptyField();
            spm.AddEmptyField();
            spm.AddNewField("ABS");
            message.AddNewSegment(spm);

            message.SerializeMessage(true);
        }
    }
}
