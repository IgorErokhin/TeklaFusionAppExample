using Fusion;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace TeklaFusionAppExample
{
    public class ExampleViewModel : ViewModel
    {
        private string profile;
        public string Profile
        {
            get { return profile; }
            set { SetValue(ref profile, value); }
        }

        private string material;
        public string Material
        {
            get { return material; }
            set { SetValue(ref material, value); }
        }

        public ExampleViewModel()
        {
            Profile = "HI300-15-20*300";
            Material = "C245";
        }

        [CommandHandler]
        public void OkCommand()
        {
            Model model = new Model();
            if (model.GetConnectionStatus())
            {
                Beam beam = new Beam(new Point(0, 0, 0), new Point(1000, 0, 0));
                beam.Profile.ProfileString = Profile;
                beam.Material.MaterialString = Material;
                
                if(beam.Insert())
                {
                    _ = model.CommitChanges();
                }
            }
        }
    }
}
