using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content() {
            Visualizations = new List<Visualization>();
            Comments = new List<Comment>();
            Subjects = new List<Subject>();
        }
        public Content(string contentURI, string description, Boolean isPublic, string title, DateTime uploadDate, Member owner):this() { 
            this.ContentURI = contentURI;
            this.Description = description;
            this.IsPublic = isPublic;
            this.Title = title;
            this.UploadDate = uploadDate;
            Owner = owner;
        }
        public void AddSubject(Subject s) {
            if (Subjects.Count < 3)
            {
                Subjects.Add(s);
            }
        }
         public void AddComment(Comment cm1) {
            Comments.Add(cm1);
        }
        public void AddEvaluation(Evaluation e) { 
            this.Evaluation = e;
        }
        public void AddVisualization(Visualization v)
        {
            Visualizations.Add(v);
        }

    }
}
