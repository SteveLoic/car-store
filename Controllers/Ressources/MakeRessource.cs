using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace digitalcar.Controllers.Ressources
{
    public class MakeRessource
    {
        public int Id { get; set; }


        public string Name { get; set; }


        public ICollection<ModelRessource> Models { get; set; }

        public MakeRessource()
        {
            Models = new Collection<ModelRessource>();
        }


    }
}