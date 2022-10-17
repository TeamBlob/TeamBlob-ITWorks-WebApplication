using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ChatModel
    {
        public int AccountID { get; set; }
        public string DeviceCategory { get; set; }
        public string Brand { get; set; }
        public string Issue { get; set; }
        public string SubIssue { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public DateTime MeetingSession { get; set; }
        public String join_url { get; set; }
        public String password { get; set; }
        public String start_time { get; set; }
        public String topic { get; set; }
        public String host_email { get; set; }
    }
}
