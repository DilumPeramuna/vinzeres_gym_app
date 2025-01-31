using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    internal class Session
    {
        private string sessionId;
        private string date;
        private string time;
        private string trainerId;  // Fetched from Trainer class
        private string memberId1; // Fetched from Member class
        private string memberId2;
        private string memberId3;
        private string memberId4;

        public string SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string TrainerId
        {
            get { return trainerId; }
            private set { trainerId = value; } // Set privately
        }

        public string MemberId1
        {
            get { return memberId1; }
            private set { memberId1 = value; } // Set privately
        }
        public string MemberId2
        {
            get { return memberId2; }
            private set { memberId2 = value; } // Set privately
        }
        public string MemberId3
        {
            get { return memberId3; }
            private set { memberId3 = value; } // Set privately
        }
        public string MemberId4
        {
            get { return memberId4; }
            private set { memberId4 = value; } // Set privately
        }

        public Session(string sessionId, string date, string time, Trainer trainer, Member member1, Member member2, Member member3, Member member4)
        {
            this.SessionId = sessionId;
            this.Date = date;
            this.Time = time;

            // Fetch and assign TrainerId
            this.TrainerId = trainer.TrainerId;

            // Fetch and assign Member IDs
            this.MemberId1 = member1.MemberId;
            this.MemberId2 = member2.MemberId;
            this.MemberId3 = member3.MemberId;
            this.MemberId4 = member4.MemberId;
        }
    }
}
