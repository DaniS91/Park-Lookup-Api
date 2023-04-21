using Microsoft.EntityFrameworkCore;

namespace ParksApi.Models
{
  public class ParksApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParksApiContext(DbContextOptions<ParksApiContext> options) : base(options)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, ParkName = "Olympic National Park", ParkCode = "OLYM", Designation = "National Park", LocationState = "Washington", GoverningBody = "NPS", URL = "https://www.nps.gov/olym/index.htm", AreaInAcres = 922650 },
          new Park { ParkId = 2, ParkName = "Death Valley National Park", ParkCode = "DEVA", Designation = "National Park", LocationState = "California", GoverningBody = "NPS", URL = "https://www.nps.gov/deva/index.htm", AreaInAcres = 3373063 },
          new Park { ParkId = 3, ParkName = "Ozark-St. Francis National Forest", ParkCode = "osfnf", Designation = "National Forest", LocationState = "Arkansas", GoverningBody = "USFS", URL = "https://www.fs.usda.gov/osfnf", AreaInAcres = 1159801 },
          new Park { ParkId = 4, ParkName = "Yosemite National Park", ParkCode = "YOSE", Designation = "National Park", LocationState = "California", GoverningBody = "NPS", URL = "https://www.nps.gov/yose/index.htm", AreaInAcres = 759620 },
          new Park { ParkId = 5, ParkName = "Yosemite National Park", ParkCode = "YOSE", Designation = "National Park", LocationState = "California", GoverningBody = "NPS", URL = "https://www.nps.gov/yose/index.htm", AreaInAcres = 759620 }
        );
    }
  }
}