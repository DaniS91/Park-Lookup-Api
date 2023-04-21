using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    public string ParkName { get; set; }
    
    public string ParkCode { get; set; }
   
    public string Designation { get; set; }

    public string LocationState { get; set; }

    public string GoverningBody { get; set; }

    public string URL { get; set; }

    public int AreaInAcres { get; set; }

  }
}