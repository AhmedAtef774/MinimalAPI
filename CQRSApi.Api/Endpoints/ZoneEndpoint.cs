using CQRSApi.Application.Contract.Repositories;
namespace CQRSAPi.Api.Endpoints;
public static class ZoneEndpoint {

    public static void MapZoneEndpoints(this IEndpointRouteBuilder app){
        app.MapGet("Zone/Zones",GetZones);

    }



    private async static Task<IResult> GetZones(IZoneService zoneService){
        var result = await zoneService.GetZonesAsync();

        return Results.Ok(result);
    }
}