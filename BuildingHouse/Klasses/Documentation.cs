using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildingHouse.Klasses
{
    class Documentation
    {
        public Project Project { get; }
        public ProgressBook ProgressBook { get; set; }
        public ActWorkPerformed ActWorkPerformed { get; set; }
        public Documentation(Project project)
        {
            ProgressBook = new ProgressBook();
            ActWorkPerformed = new ActWorkPerformed();
            Project = project;
        }
    }
}
