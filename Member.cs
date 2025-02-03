using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYM_MANAGEMENT_FINALPROJECT
{
    internal class Member : Person
    {
        private string memberId;
        private bool membershipStatus;

        
        public Member( string name, int age , string memberId, bool membershipStatus) : base( name , age )
        {
            this.memberId = memberId;
            this.Name = name;
            this.Age = age;
            this.membershipStatus = membershipStatus;
        }

    
        public string MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }

       
    
       
        

        public bool MembershipStatus
        {
            get { return membershipStatus; }
            set { membershipStatus = value; }
        }
        
    }
   
}
