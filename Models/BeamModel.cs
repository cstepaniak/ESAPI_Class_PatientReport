using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientReport.Models
{
    public class BeamModel
    {
        public string BeamId { get; set; }
        public string BeamName { get; set; }
        public string MachineId { get; set; }
        public string Energy { get; set; }
        public double DoseRate { get; set; }
        public double GantryAngle { get; set; }
        public double CollimatorAngle { get; set; }
        public double CouchAngle { get; set; }
        public double FieldX { get; set; }
        public double FieldY { get; set; }
        public double SSD { get; set; }
        public double MU { get; set; }
    }
}
