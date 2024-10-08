using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPelletsLib
{
    public class WoodPelletRepository
    {
        private List<WoodPellet> _woodPellets = new List<WoodPellet>
        {
            new WoodPellet(1, "BioWood", 4995, 4),
            new WoodPellet(2, "BioWood", 5195, 4),
            new WoodPellet(3, "BilligPille", 4125, 1),
            new WoodPellet(4, "GoldenWoodPellet", 5995, 5),
            new WoodPellet(5, "GoldenWoodPellet", 5795, 5)
        };

        public List<WoodPellet> GetAll()
        {
            return _woodPellets;
        }

        public WoodPellet GetById(int id)
        {
            foreach (WoodPellet woodPellet in _woodPellets)
            {
                if (woodPellet.Id == id)
                {
                    return woodPellet;
                }
            }
            return null;
        }

        public WoodPellet Add(WoodPellet woodPellet)
        {
            woodPellet.Validate();
            _woodPellets.Add(woodPellet);
            return woodPellet;
        }

        public WoodPellet Update(WoodPellet woodPellet)
        {
            woodPellet.Validate();
            WoodPellet existingWoodPellet = GetById(woodPellet.Id);
            if (existingWoodPellet != null)
            {
                existingWoodPellet.Brand = woodPellet.Brand;
                existingWoodPellet.Price = woodPellet.Price;
                existingWoodPellet.Quality = woodPellet.Quality;
            }
            return existingWoodPellet;
        }
    }
}
