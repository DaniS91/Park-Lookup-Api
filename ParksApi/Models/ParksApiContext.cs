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
          new Park { ParkId = 5, ParkName = "Mt. Hood National Forest", ParkCode = "mthood", Designation = "National Forest", LocationState = "Oregon", GoverningBody = "USFS", URL = "https://www.fs.usda.gov/mthood", AreaInAcres = 1071466 },
          new Park { ParkId = 6, ParkName = "Devil's Tower National Monument", ParkCode = "DETO", Designation = "National Monument", LocationState = "Wyoming", GoverningBody = "NPS", URL = "https://www.nps.gov/deto/index.htm" },
          new Park { ParkId = 7, ParkName = "Silver Falls State Parlk", Designation = "State Park", LocationState = "Oregon", GoverningBody = "OPRD", URL = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=151", AreaInAcres = 9000 },
          new Park { ParkId = 8, ParkName = "Crater Lake National Park", ParkCode = "CRLA", Designation = "National Park", LocationState = "Oregon", GoverningBody = "NPS", URL = "https://www.nps.gov/crla/index.htm", AreaInAcres = 183224 },
          new Park { ParkId = 9, ParkName = "Gates Of The Arctic National Park", ParkCode = "GAAR", Designation = "National Park", LocationState = "Alaska", GoverningBody = "NPS", URL = "https://www.nps.gov/gaar/index.htm", AreaInAcres = 8472506 },
          new Park { ParkId = 10, ParkName = "Everglades National Park", ParkCode = "EVER", Designation = "National Park", LocationState = "Florida", GoverningBody = "NPS", URL = "https://www.nps.gov/gaar/index.htm", AreaInAcres = 8472506 }
        );
    }
  }
}