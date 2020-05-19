using PatientReport.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;

namespace PatientReport.ViewModels
{
    public class BeamViewModel {
        public ObservableCollection<BeamModel> BeamData { get; private set; }
        private PlanSetup _plan;
        public BeamViewModel(PlanSetup plan) {
            BeamData = new ObservableCollection<BeamModel>();
            _plan = plan;
            GetBeams();
        }

        private void GetBeams() {
            foreach (var beam in _plan.Beams.Where(x => !x.IsSetupField).OrderBy(x => x.BeamNumber)) {
                BeamData.Add(new BeamModel {
                    BeamId = beam.Id,
                    BeamName = beam.Name,
                    MachineId = beam.TreatmentUnit.Id,
                    Energy = beam.EnergyModeDisplayName,
                    DoseRate = beam.DoseRate,
                    GantryAngle = beam.ControlPoints.First().GantryAngle,
                    CollimatorAngle = beam.ControlPoints.First().CollimatorAngle,
                    CouchAngle = beam.ControlPoints.First().PatientSupportAngle,
                    FieldX = (beam.ControlPoints.Max(x => x.JawPositions.X2) - beam.ControlPoints.Min(x => x.JawPositions.X1))/10.0,
                    FieldY = (beam.ControlPoints.Max(x => x.JawPositions.Y2) - beam.ControlPoints.Min(x => x.JawPositions.Y1))/10.0,
                    SSD = Math.Round(beam.SSD/10.0,2),
                    MU = beam.Meterset.Value
                });
            }
                
        }
    }
}
