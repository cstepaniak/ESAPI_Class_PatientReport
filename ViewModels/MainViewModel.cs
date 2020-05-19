using PatientReport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVHPlot.ViewModels
{
    public class MainViewModel {
        public MainViewModel(DVHViewModel dVHViewModel,
            DVHSelectionViewModel dVHSelectionViewModel,
            BeamViewModel beamViewModel) {
            DVHViewModel = dVHViewModel;
            DVHSelectionViewModel = dVHSelectionViewModel;
            BeamViewModel = beamViewModel;
        }

        public DVHViewModel DVHViewModel { get; }
        public DVHSelectionViewModel DVHSelectionViewModel { get; }
        public BeamViewModel BeamViewModel { get; }
        // All this is hoodoo to hand through the various ViewModels to the MainViewModel
    }
}
