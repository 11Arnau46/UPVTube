using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Member
    {
        public Member ()
        {
            Visualizations = new List<Visualization>();
            Contents = new List<Content>();
            Evaluations = new List<Evaluation>();
            Comments = new List<Comment>();
            Subscriptors = new List<Member>();
            SubscribedTo = new List<Member>();
            StudentDomains = new List<string>() { "@dsic.upv.es", "@dsica.upv.es" };
            TeacherDomains = new List<string>() { "@inf.upv.es" };
        }

        public Member(string email, string fullName, DateTime lastAccessDate, string nick, string password):this()
        {
            this.Email = email;
            this.FullName = fullName;
            this.LastAccessDate = lastAccessDate;
            this.Nick = nick;
            this.Password = password;

        }
        public void AddContent(Content c) {
            Contents.Add(c);
        }
         public void AddEvaluation(Evaluation e) {
            Evaluations.Add(e);
        }
        public void AddVisualization(Visualization v) { 
            Visualizations.Add(v);
        }
        public void AddComment(Comment cm1) { 
            Comments.Add(cm1);
        }
        public bool IsTeacher()
        {
            foreach (string alias in TeacherDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }
        public bool IsStudent()
        {
            foreach (string alias in StudentDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }
    }

}
