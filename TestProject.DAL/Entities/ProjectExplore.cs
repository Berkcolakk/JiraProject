using System.ComponentModel.DataAnnotations.Schema;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Entities
{
    public class ProjectExplore : EntityBase
    {
        public string PROJECTEXPLORE_NAME { get; set; }

        [ForeignKey("Item")]
        public int PROJECTEXPLORE_ITEM_ID { get; set; }

        [ForeignKey("Project")]
        public int PROJECTEXPLORE_PROJECT_ID { get; set; }
        public string PROJECTEXPLORE_CODE { get; set; }
        public double PROJECTEXPLORE_ITEMQUANTITY { get; set; } = 0;
        public double PROJECTEXPLORE_ITEMPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_ITEMASSMPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_ITEMDEASSMPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_ITEMDEASSMDEPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_PLACEITEMQUANTITY { get; set; } = 0;
        public double PROJECTEXPLORE_PLACEITEMPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_PLACEITEMASSMPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_PLACEITEMDEASSMPRICE { get; set; } = 0;
        public double PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE { get; set; } = 0;

        public string PROJECTEXPLORE_DESC { get; set; }

        public virtual Item Item { get; set; }

        public virtual Project Project { get; set; }
    }
}