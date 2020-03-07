using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyId = table.Column<string>(nullable: true),
                    AgencyName = table.Column<string>(nullable: true),
                    AgencyUrl = table.Column<string>(nullable: true),
                    AgencyTimezone = table.Column<string>(nullable: true),
                    AgencyLang = table.Column<string>(nullable: true),
                    AgencyPhone = table.Column<string>(nullable: true),
                    AgencyFareUrl = table.Column<string>(nullable: true),
                    AgencyEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalendarDates",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<string>(nullable: true),
                    ServiceId = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    ExceptionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FareAttributes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionType = table.Column<string>(nullable: true),
                    FareId = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    CurrencyType = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<string>(nullable: true),
                    Transfers = table.Column<string>(nullable: true),
                    AgencyId = table.Column<string>(nullable: true),
                    TransferDuration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FareAttributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FareRules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferDuration = table.Column<string>(nullable: true),
                    FareId = table.Column<string>(nullable: true),
                    RouteId = table.Column<string>(nullable: true),
                    OriginId = table.Column<string>(nullable: true),
                    DestinationId = table.Column<string>(nullable: true),
                    ContainsId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FareRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedInfo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelName = table.Column<string>(nullable: true),
                    FeedPublisherName = table.Column<string>(nullable: true),
                    FeedPublisherUrl = table.Column<string>(nullable: true),
                    FeedLang = table.Column<string>(nullable: true),
                    FeedStartDate = table.Column<string>(nullable: true),
                    FeedEndDate = table.Column<string>(nullable: true),
                    FeedVersion = table.Column<string>(nullable: true),
                    FeedContactEmail = table.Column<string>(nullable: true),
                    FeedContactUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformCode = table.Column<string>(nullable: true),
                    RouteId = table.Column<string>(nullable: true),
                    AgencyId = table.Column<string>(nullable: true),
                    RouteShortName = table.Column<string>(nullable: true),
                    RouteLongName = table.Column<string>(nullable: true),
                    RouteDesc = table.Column<string>(nullable: true),
                    RouteType = table.Column<string>(nullable: true),
                    RouteUrl = table.Column<string>(nullable: true),
                    RouteColor = table.Column<string>(nullable: true),
                    RouteTextColor = table.Column<string>(nullable: true),
                    RouteSortOrder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContainsId = table.Column<string>(nullable: true),
                    ShapeId = table.Column<string>(nullable: true),
                    ShapePtLat = table.Column<string>(nullable: true),
                    ShapePtLon = table.Column<string>(nullable: true),
                    ShapePtSequence = table.Column<string>(nullable: true),
                    ShapeDistTraveled = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StopAmentities",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StopId = table.Column<string>(nullable: true),
                    Shelter = table.Column<string>(nullable: true),
                    Washroom = table.Column<string>(nullable: true),
                    BikeRack = table.Column<string>(nullable: true),
                    Bench = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopAmentities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stops",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgencyEmail = table.Column<string>(nullable: true),
                    StopId = table.Column<string>(nullable: true),
                    StopCode = table.Column<string>(nullable: true),
                    StopName = table.Column<string>(nullable: true),
                    StopDesc = table.Column<string>(nullable: true),
                    StopLat = table.Column<string>(nullable: true),
                    StopLon = table.Column<string>(nullable: true),
                    ZoneId = table.Column<string>(nullable: true),
                    StopUrl = table.Column<string>(nullable: true),
                    LocationType = table.Column<string>(nullable: true),
                    ParentStation = table.Column<string>(nullable: true),
                    StopTimezone = table.Column<string>(nullable: true),
                    WheelchairBoarding = table.Column<string>(nullable: true),
                    LevelId = table.Column<string>(nullable: true),
                    PlatformCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StopTimes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BikesAllowed = table.Column<string>(nullable: true),
                    TripId = table.Column<string>(nullable: true),
                    ArrivalTime = table.Column<string>(nullable: true),
                    DepartureTime = table.Column<string>(nullable: true),
                    StopId = table.Column<string>(nullable: true),
                    StopSequence = table.Column<string>(nullable: true),
                    StopHeadsign = table.Column<string>(nullable: true),
                    PickupType = table.Column<string>(nullable: true),
                    DropOffType = table.Column<string>(nullable: true),
                    ShapeDistTraveled = table.Column<string>(nullable: true),
                    Timepoint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopTimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExactTimes = table.Column<string>(nullable: true),
                    FromStopId = table.Column<string>(nullable: true),
                    ToStopId = table.Column<string>(nullable: true),
                    TransferType = table.Column<string>(nullable: true),
                    MinTransferTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteSortOrder = table.Column<string>(nullable: true),
                    RouteId = table.Column<string>(nullable: true),
                    ServiceId = table.Column<string>(nullable: true),
                    TripId = table.Column<string>(nullable: true),
                    TripHeadsign = table.Column<string>(nullable: true),
                    TripShortName = table.Column<string>(nullable: true),
                    DirectionId = table.Column<string>(nullable: true),
                    BlockId = table.Column<string>(nullable: true),
                    ShapeId = table.Column<string>(nullable: true),
                    WheelchairAccessible = table.Column<string>(nullable: true),
                    BikesAllowed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "CalendarDates");

            migrationBuilder.DropTable(
                name: "FareAttributes");

            migrationBuilder.DropTable(
                name: "FareRules");

            migrationBuilder.DropTable(
                name: "FeedInfo");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Shapes");

            migrationBuilder.DropTable(
                name: "StopAmentities");

            migrationBuilder.DropTable(
                name: "Stops");

            migrationBuilder.DropTable(
                name: "StopTimes");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
