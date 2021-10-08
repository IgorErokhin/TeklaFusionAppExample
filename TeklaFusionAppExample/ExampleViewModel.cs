using Fusion;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace TeklaFusionAppExample
{
    public class ExampleViewModel : ViewModel
    {
        [CommandHandler]
        public void OkCommand()
        {
            Model model = new Model();
            if (model.GetConnectionStatus())
            {
                Beam beam = new Beam(new Point(0, 0, 0), new Point(1000, 0, 0));
                beam.Profile.ProfileString = "I30B1_20_93";
                beam.Material.MaterialString = "C245";
                
                if(beam.Insert())
                {
                    _ = model.CommitChanges();
                }
            }
        }
    }
}
