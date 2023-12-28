using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() { 
            
        }
        public Visualization(DateTime visualizationDate, Content content, Member member) {
            this.VisualizationDate = visualizationDate;
            Content = content;
            Member = member;
        }
    }
}
